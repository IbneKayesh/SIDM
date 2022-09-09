using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace SIDM
{
    public partial class frmMain : Form
    {
        private Label[] label = new Label[1000];
        private ProgressBar[] progressBar = new ProgressBar[1000];


        long length;
        double fileSizeMB = 0;
        static int numConnection = 8;
        static byte[] fileByte;
        private delegate void UpdateProgessCallback1(Int64 BytesRead, Int64 TotalBytes, Int64 indexLabel, Stopwatch sw);
        private delegate void UpdateProgessCallback2(Int64 percent, Int64 speed);
        private static int percentProgressOfEachConnection;
        private static double speedOfEachlConnection;
        int[] speedConnection = new int[numConnection];
        static int percent = 0;
        static int speed = 0;
        double fileSizeLeftMB = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region TitleBar_Drag_Form
        //Drag Form
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Form Shadow Effect
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams сp = base.CreateParams;
                сp.ClassStyle |= 0x00020000;
                return сp;
            }
        }
        #endregion

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            frmAddLink newDownload = new frmAddLink();
            newDownload.ShowDialog();

            if (newDownload.DialogResult == DialogResult.OK)
            {
                lblLink.Text = newDownload.Link;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest webRequest;
                HttpWebResponse webResponse;
                Uri uri = new Uri(lblLink.Text);
                string filename = Path.GetFileName(uri.LocalPath);
                webRequest = (HttpWebRequest)WebRequest.Create(lblLink.Text);
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                length = webResponse.ContentLength;
                fileSizeMB = ((length / 1024) / 1024);
                lblFileSizeDownSize.Text = "0 MB of " + fileSizeMB.ToString("F2") + " MB (Est.)";
                webResponse.Close();
                object[] obj = new object[numConnection][];



                AddControls();

                for (int i = 0; i < numConnection; i++)
                {
                    long start_byte = (length / numConnection) * i;
                    long end_byte = ((length / numConnection) * (i + 1)) - 1;
                    if (i == numConnection - 1)
                    {
                        end_byte++;
                    }
                    obj[i] = new object[] { start_byte, end_byte, i };

                    task[i] = new Task<byte[]>(download, obj[i]);
                    task[i].Start();


                }
                //obj[numConnection - 1] = new object[] { length / numConnection * (numConnection - 1), length - 1, 7 }; //label no 9
                //task[numConnection - 1] = new Task<byte[]>(download, obj[numConnection - 1]);
                //task[numConnection - 1].Start();

                Task t1 = new Task(() =>
                {
                    Task.WaitAll(task);
                    FileStream strLocal;
                    strLocal = new FileStream(txtDiskPath.Text + "\\" + filename + "",
                              FileMode.Create, FileAccess.Write,
                              FileShare.ReadWrite);

                    byte[] fileByte = new byte[length];
                    for (int i = 0; i < numConnection; i++)
                    {
                        task[i].Result.CopyTo(fileByte, length / numConnection * i);
                    }
                    strLocal.Write(fileByte, 0, fileByte.Length);
                    strLocal.Close();
                    //MessageBox.Show("Download Completed.", this.Text);
                });
                t1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        Task<byte[]>[] task = new Task<byte[]>[numConnection];
        byte[] download(object obj)
        {
            try
            {
                HttpWebRequest webRequest;
                HttpWebResponse webResponse;
                Stream strResponse;
                object[] obj1 = (object[])obj;
                long from = (long)obj1[0];
                long offset = (long)obj1[1];
                int ilabel = (int)obj1[2];

                // Create a request to the file we are downloading
                webRequest = (HttpWebRequest)WebRequest.Create(lblLink.Text);

                // Set default authentication for retrieving the file
                webRequest.Credentials = CredentialCache.DefaultCredentials;

                //Range file requsest from , offset
                webRequest.AddRange((int)from, (int)offset);
                // Retrieve the response from the server
                webResponse = (HttpWebResponse)webRequest.GetResponse();

                //Store response in file stream
                strResponse = webResponse.GetResponseStream();
                Int64 fileSize = webResponse.ContentLength;
                MemoryStream msLocal = new MemoryStream();

                int bytesSize = 0;
                byte[] downBuffer = new byte[2048];
                Stopwatch sw = new Stopwatch();
                sw.Start();
                bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length);
                sw.Stop();
                while (bytesSize > 0)
                {
                    // Write the data from the buffer to the memory drive
                    msLocal.Write(downBuffer, 0, bytesSize);
                    this.Invoke(new UpdateProgessCallback1(this.updateProgress1), new object[] { msLocal.Length, fileSize, ilabel, sw });
                    sw.Start();
                    bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length);
                    sw.Stop();
                }
                fileByte = msLocal.ToArray();

                // updateProgress(msLocal.Length, fileSize);
                webResponse.Close();
                strResponse.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, this.Text);
            }
            return fileByte;
        }

        private void updateProgress1(Int64 byteRead, Int64 totalBytes, Int64 indexLabel, Stopwatch sw)
        {
            // Calculate the download progress in percentages
            percentProgressOfEachConnection = (Convert.ToInt32((byteRead * 100) / totalBytes));
            speedOfEachlConnection = Convert.ToInt32(((byteRead) / (sw.Elapsed.TotalSeconds)) / 1000);

            progressBar[indexLabel].Value = percentProgressOfEachConnection;
            speedConnection[indexLabel] = (int)speedOfEachlConnection;
            // Display the current progress on the form
            label[indexLabel].Text = (indexLabel + 1).ToString() + " : " +
                percentProgressOfEachConnection.ToString() + " % " +
                speedOfEachlConnection.ToString() + " kb/s";
            this.Invoke(new UpdateProgessCallback2(this.updateProgress2), new object[] { percent, speed });

        }
        private void updateProgress2(Int64 percent, Int64 speed)
        {
            for (int i = 0; i < numConnection; i++)
            {
                // Calculate the download progress in percentages in all connection
                percent += (int)(((double)progressBar[i].Value));
                speed += speedConnection[i];
            }
            progressBar9.Value = Convert.ToInt32(percent / numConnection);
            // Display the current progress on the form label
            label9.Text = "Downloaded : " + (percent / numConnection).ToString() + " % Average Speed : " + (speed / numConnection).ToString() + " kbit/s";

            fileSizeLeftMB = fileSizeMB - ((fileSizeMB * (percent / numConnection)) / 100);
            lblFileSizeDownSize.Text = (fileSizeMB - fileSizeLeftMB).ToString("F2") + " MB of " + fileSizeMB.ToString("F2") + " MB (Est.)";


            double seconds = (fileSizeLeftMB * 1024) / speed;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            lblLeftTime.Text = time.ToString(@"hh\:mm\:ss\:fff") + " left. End: " + DateTime.Now.AddSeconds(seconds).ToString();



        }

        private void AddControls()
        {
            int size = 9;
            pnlCurrentItem.Controls.OfType<ProgressBar>().Except(new[] { progressBar9 }).ToList().ForEach(c => c.Dispose());
            for (int i = 0; i < numConnection; i++)
            {
                progressBar[i] = new ProgressBar();
                this.progressBar[i].Location = new Point(size, 46);
                this.progressBar[i].Name = "progressBar" + i.ToString();
                this.progressBar[i].Size = new Size(90, 23);
                pnlCurrentItem.Controls.Add(progressBar[i]);
                size += 93;
            }
            //progressBar[9] = new ProgressBar();
            //this.progressBar[9].Location = new Point(9, 12);
            //this.progressBar[9].Name = "progressBar9";
            //this.progressBar[9].Size = new Size(742, 23);
            //pnlCurrentItem.Controls.Add(progressBar[9]);

            // pnlCurrentItem.Controls.OfType<Label>().Except(new[] { lblFileSizeDownSize, label9, lblLeftTime }).ToList().ForEach(c => c.Dispose());
            bool isTop = true;
            size = 9;
            for (int i = 0; i < numConnection; i++)
            {
                label[i] = new Label();
                this.label[i].AutoSize = true;
                if (isTop)
                {
                    this.label[i].Location = new Point(size, 74);
                }
                else
                {
                    this.label[i].Location = new Point(size, 91);
                }
                this.label[i].Name = "label" + (i + 4).ToString();
                this.label[i].ForeColor = Color.White;
                this.label[i].Font = new Font("Segoe UI", 9);
                pnlCurrentItem.Controls.Add(label[i]);
                size += 93;
                isTop = isTop == true ? false : true;
            }

        }

        private void txtDiskPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDiskPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}