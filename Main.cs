using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RiftSharp_Launcher
{
    public partial class Main
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\WoWClient.exe"))
            {
                MessageBox.Show("Please copy the Launcher next to the 'WoWClient.exe'.");
                return;
            }

            if (!string.IsNullOrEmpty(txtUserName.Text) & !string.IsNullOrEmpty(txtPassword.Text))
            {
                // Declare those variables!
                string sFileName = Application.StartupPath + @"\wow.ses";
                var myFileStream = new FileStream(sFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);

                // Create the stream writer
                var myWriter = new StreamWriter(myFileStream);

                // Write in what is in the text box
                myWriter.Write(txtUserName.Text + "\r\n" + txtPassword.Text);

                // Flush before we close
                myWriter.Flush();

                // Close everything
                myWriter.Close();
                myFileStream.Close();
                var startInfo = new ProcessStartInfo(Application.StartupPath + @"\WoWClient.exe");
                if (chkboxWindowed.Checked)
                {
                    startInfo.Arguments = "-uptodate -windowed -console";
                }
                else
                {
                    startInfo.Arguments = "-uptodate -console";
                }

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Username and Password could not be empty.");
                return;
            }
        }
        internal partial class MainExe
        {
            /// The main entry point for the application.
            [STAThread()]
            internal static void Main(string[] Args)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}