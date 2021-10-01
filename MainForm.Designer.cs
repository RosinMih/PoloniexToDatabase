
namespace PoloniexToDatabase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxAutent = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonToTray = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDownPause = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.MaximumSize = new System.Drawing.Size(450, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программа выгрузка информации о ценах криптовалютных пар с биржы POLONIEX и загру" +
    "зки их в базу данных SQL  SERVER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.checkBoxAutent);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения к SQL SERVER";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(392, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(218, 57);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя (IP адрес) SQL сервера";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(172, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // checkBoxAutent
            // 
            this.checkBoxAutent.AutoSize = true;
            this.checkBoxAutent.Location = new System.Drawing.Point(19, 56);
            this.checkBoxAutent.Name = "checkBoxAutent";
            this.checkBoxAutent.Size = new System.Drawing.Size(157, 17);
            this.checkBoxAutent.TabIndex = 0;
            this.checkBoxAutent.Text = "Аутентификация Windows";
            this.checkBoxAutent.UseVisualStyleBackColor = true;
            this.checkBoxAutent.CheckedChanged += new System.EventHandler(this.checkBoxAutent_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(580, 65);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 30);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(580, 106);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 28);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(27, 179);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(649, 163);
            this.textBoxMessage.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(580, 149);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 24);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonToTray
            // 
            this.buttonToTray.Location = new System.Drawing.Point(551, 349);
            this.buttonToTray.Name = "buttonToTray";
            this.buttonToTray.Size = new System.Drawing.Size(125, 23);
            this.buttonToTray.TabIndex = 6;
            this.buttonToTray.Text = "Свернуть в трей";
            this.buttonToTray.UseVisualStyleBackColor = true;
            this.buttonToTray.Click += new System.EventHandler(this.buttonToTray_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // numericUpDownPause
            // 
            this.numericUpDownPause.Location = new System.Drawing.Point(186, 151);
            this.numericUpDownPause.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPause.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownPause.Name = "numericUpDownPause";
            this.numericUpDownPause.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPause.TabIndex = 7;
            this.numericUpDownPause.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пауза между запросами, с";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownPause);
            this.Controls.Add(this.buttonToTray);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PoloniextToDatabase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxAutent;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numericUpDownPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

