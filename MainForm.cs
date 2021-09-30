using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoloniexToDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public static bool WorkFlag;


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


            textBoxMessage.Text = connection.ToString();

            buttonStart.BackColor = Color.Red;
            buttonStart.Enabled = false;
            WorkFlag = true;

            Execution.Exec(connection.ToString(), numericUpDownPause.Value);

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
            //textBoxMessage.Text = textBoxMessage.Text+"Check";
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
    }
}
