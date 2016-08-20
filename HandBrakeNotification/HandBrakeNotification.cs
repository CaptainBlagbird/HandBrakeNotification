using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace HandBrakeNotification
{
    public partial class frm_main : Form
    {
        private const String version   = "v1.0.0";
        private const String sourceUrl = "https://github.com/CaptainBlagbird/HandBrakeNotification";

        private String movieFile;
        private String soundFile = AppDomain.CurrentDomain.BaseDirectory + @"\sound.wav";
        private SoundPlayer notificationPlayer;

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            String[] arguments = Environment.GetCommandLineArgs();

            if (arguments.Length >= 2)
            {
                movieFile = Path.GetFullPath(arguments[1]);

                if (File.Exists(movieFile))
                {
                    lbl_file_text.Text = Path.GetFileName(movieFile);

                    try
                    {
                        notificationPlayer = new SoundPlayer(soundFile);
                        notificationPlayer.Play();
                    }
                    catch
                    {
                    }

                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("HandBrake finished, but file '"+Path.GetFileName(movieFile)+"' cannot be found...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("No argument specified, aborting", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if (File.Exists(movieFile))
            {
                Process.Start(movieFile);
            }
            else
            {
                MessageBox.Show("File couldn't be found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(movieFile)))
            {
                Process.Start("\"" + Path.GetDirectoryName(movieFile)+"\"");
            }
            else
            {
                MessageBox.Show("Directory couldn't be found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void itm_about_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("HandBrake Notification " + version + " by CaptainiBlagbird\n\nSource code and versions can be found at\n" + sourceUrl + "\nOpen the page?", "About", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if(res == DialogResult.OK)
            {
                Process.Start(sourceUrl);
            }
        }
    }
}
