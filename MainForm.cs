using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace PoloniexToDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public static bool WorkFlag;
        public static StringBuilder StringBuilder_message = new StringBuilder(200);
        ParametersToExecut parametersToExecut = new ParametersToExecut();
        Thread ThreadToExecut = new Thread(new ParameterizedThreadStart(Execution.Exec));



        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                return;
            }
            if ((textBoxLogin.Text == "") & (!checkBoxAutent.Checked))
            {
                return;
            }
            StringBuilder connection = new StringBuilder();
            if (checkBoxAutent.Checked)
            {
                connection.Append(@"Data Source=" +textBoxName.Text +";Initial Catalog=master;Integrated Security=true");
            }
            else
            {
                connection.Append(@"Data Source=" + textBoxName.Text + ";Initial Catalog=master;Integrated Security=False;" +
                                  "User ID="+textBoxLogin.Text+";Password="+textBoxPassword.Text+";");
            }
            parametersToExecut.connection = connection.ToString();
            parametersToExecut.pause = numericUpDownPause.Value;
            if (!ThreadToExecut.IsAlive)
            {
                try
                {
                    ThreadToExecut.Start(parametersToExecut);
                }
                catch (Exception ex)
                {
                    MainForm.StringBuilder_message.Append(ex.ToString() + "\r\n"  + "Программа остановлена" + "\r\n");
                }
            }
            ThreadToExecut.IsBackground = true;
            buttonStart.BackColor = Color.Red;
            buttonStart.Enabled = false;
            WorkFlag = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.BackColor = Color.FromArgb(200, 200, 200, 200);
            buttonStart.Enabled = true;
            WorkFlag = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMessage.Clear();
        }

        private void buttonToTray_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void checkBoxAutent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutent.Checked)
            {
                textBoxLogin.Enabled = false;
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
            }
        }


        internal class ParametersToExecut
        {
            public string connection;
            public decimal pause;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StringBuilder_message.Length > 0)
            {
                textBoxMessage.Text = textBoxMessage.Text + StringBuilder_message.ToString();
                StringBuilder_message.Clear();
            }
        }
    }
}
