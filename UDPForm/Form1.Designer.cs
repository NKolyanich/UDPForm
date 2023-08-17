namespace UDPForm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SendTerminalMSG = new System.Windows.Forms.Button();
            this.textBoxTerminal = new System.Windows.Forms.TextBox();
            this.textBoxDestHost = new System.Windows.Forms.TextBox();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SendString = new System.Windows.Forms.TextBox();
            this.textBoxLoopback_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_SUSettings_Set = new System.Windows.Forms.Button();
            this.button_SUSettings_Get = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_SUSettings_Time = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_SUSettings_Pswd = new System.Windows.Forms.CheckBox();
            this.textBox_SUSettings_Pswd = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_SUSettings_DSTPort = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_SUSettings_SRCPort = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_SUSettings_IP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_SUSettings_MAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SendTerminalMSG
            // 
            this.button_SendTerminalMSG.Location = new System.Drawing.Point(381, 55);
            this.button_SendTerminalMSG.Name = "button_SendTerminalMSG";
            this.button_SendTerminalMSG.Size = new System.Drawing.Size(128, 32);
            this.button_SendTerminalMSG.TabIndex = 0;
            this.button_SendTerminalMSG.Text = "Send";
            this.button_SendTerminalMSG.UseVisualStyleBackColor = true;
            this.button_SendTerminalMSG.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBoxTerminal
            // 
            this.textBoxTerminal.BackColor = System.Drawing.Color.Black;
            this.textBoxTerminal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxTerminal.Location = new System.Drawing.Point(6, 92);
            this.textBoxTerminal.Multiline = true;
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTerminal.Size = new System.Drawing.Size(512, 251);
            this.textBoxTerminal.TabIndex = 1;
            this.textBoxTerminal.TextChanged += new System.EventHandler(this.textBoxTerminal_TextChanged);
            // 
            // textBoxDestHost
            // 
            this.textBoxDestHost.Location = new System.Drawing.Point(17, 21);
            this.textBoxDestHost.Name = "textBoxDestHost";
            this.textBoxDestHost.Size = new System.Drawing.Size(130, 20);
            this.textBoxDestHost.TabIndex = 2;
            this.textBoxDestHost.Text = "192.168.4.240";
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Location = new System.Drawing.Point(173, 21);
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(75, 20);
            this.textBoxDestPort.TabIndex = 3;
            this.textBoxDestPort.Text = "1200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "dest host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "dest port";
            // 
            // textBox_SendString
            // 
            this.textBox_SendString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SendString.Location = new System.Drawing.Point(17, 61);
            this.textBox_SendString.Name = "textBox_SendString";
            this.textBox_SendString.Size = new System.Drawing.Size(339, 20);
            this.textBox_SendString.TabIndex = 7;
            this.textBox_SendString.Text = "7A02B96B1AA1";
            // 
            // textBoxLoopback_port
            // 
            this.textBoxLoopback_port.Location = new System.Drawing.Point(276, 21);
            this.textBoxLoopback_port.Name = "textBoxLoopback_port";
            this.textBoxLoopback_port.Size = new System.Drawing.Size(80, 20);
            this.textBoxLoopback_port.TabIndex = 10;
            this.textBoxLoopback_port.Text = "1202";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "local port";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(381, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(128, 36);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "start/stop";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 377);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.textBoxDestHost);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_SendString);
            this.tabPage1.Controls.Add(this.textBoxTerminal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button_SendTerminalMSG);
            this.tabPage1.Controls.Add(this.textBoxDestPort);
            this.tabPage1.Controls.Add(this.textBoxLoopback_port);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Terminal";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.button_SUSettings_Set);
            this.tabPage2.Controls.Add(this.button_SUSettings_Get);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UDP Server Settings";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 329);
            this.progressBar1.Maximum = 6;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 9;
            // 
            // button_SUSettings_Set
            // 
            this.button_SUSettings_Set.Location = new System.Drawing.Point(303, 282);
            this.button_SUSettings_Set.Name = "button_SUSettings_Set";
            this.button_SUSettings_Set.Size = new System.Drawing.Size(140, 37);
            this.button_SUSettings_Set.TabIndex = 8;
            this.button_SUSettings_Set.Text = "SET Settings";
            this.button_SUSettings_Set.UseVisualStyleBackColor = true;
            // 
            // button_SUSettings_Get
            // 
            this.button_SUSettings_Get.Location = new System.Drawing.Point(81, 282);
            this.button_SUSettings_Get.Name = "button_SUSettings_Get";
            this.button_SUSettings_Get.Size = new System.Drawing.Size(140, 37);
            this.button_SUSettings_Get.TabIndex = 7;
            this.button_SUSettings_Get.Text = "GET Settings";
            this.button_SUSettings_Get.UseVisualStyleBackColor = true;
            this.button_SUSettings_Get.Click += new System.EventHandler(this.button_SUSettings_Get_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_SUSettings_Time);
            this.groupBox7.Location = new System.Drawing.Point(342, 204);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 49);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Time";
            // 
            // textBox_SUSettings_Time
            // 
            this.textBox_SUSettings_Time.Location = new System.Drawing.Point(8, 18);
            this.textBox_SUSettings_Time.Name = "textBox_SUSettings_Time";
            this.textBox_SUSettings_Time.Size = new System.Drawing.Size(100, 20);
            this.textBox_SUSettings_Time.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_SUSettings_Pswd);
            this.groupBox6.Controls.Add(this.textBox_SUSettings_Pswd);
            this.groupBox6.Location = new System.Drawing.Point(47, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(249, 49);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Password";
            // 
            // checkBox_SUSettings_Pswd
            // 
            this.checkBox_SUSettings_Pswd.AutoSize = true;
            this.checkBox_SUSettings_Pswd.Location = new System.Drawing.Point(143, 21);
            this.checkBox_SUSettings_Pswd.Name = "checkBox_SUSettings_Pswd";
            this.checkBox_SUSettings_Pswd.Size = new System.Drawing.Size(60, 17);
            this.checkBox_SUSettings_Pswd.TabIndex = 1;
            this.checkBox_SUSettings_Pswd.Text = "get/set";
            this.checkBox_SUSettings_Pswd.UseVisualStyleBackColor = true;
            // 
            // textBox_SUSettings_Pswd
            // 
            this.textBox_SUSettings_Pswd.Location = new System.Drawing.Point(6, 19);
            this.textBox_SUSettings_Pswd.Name = "textBox_SUSettings_Pswd";
            this.textBox_SUSettings_Pswd.Size = new System.Drawing.Size(89, 20);
            this.textBox_SUSettings_Pswd.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_SUSettings_DSTPort);
            this.groupBox5.Location = new System.Drawing.Point(342, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 49);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Destination port";
            // 
            // textBox_SUSettings_DSTPort
            // 
            this.textBox_SUSettings_DSTPort.Location = new System.Drawing.Point(8, 19);
            this.textBox_SUSettings_DSTPort.Name = "textBox_SUSettings_DSTPort";
            this.textBox_SUSettings_DSTPort.Size = new System.Drawing.Size(100, 20);
            this.textBox_SUSettings_DSTPort.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_SUSettings_SRCPort);
            this.groupBox4.Location = new System.Drawing.Point(342, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sources port";
            // 
            // textBox_SUSettings_SRCPort
            // 
            this.textBox_SUSettings_SRCPort.Location = new System.Drawing.Point(6, 19);
            this.textBox_SUSettings_SRCPort.Name = "textBox_SUSettings_SRCPort";
            this.textBox_SUSettings_SRCPort.Size = new System.Drawing.Size(100, 20);
            this.textBox_SUSettings_SRCPort.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_SUSettings_IP);
            this.groupBox3.Location = new System.Drawing.Point(47, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP-address";
            // 
            // textBox_SUSettings_IP
            // 
            this.textBox_SUSettings_IP.Location = new System.Drawing.Point(6, 19);
            this.textBox_SUSettings_IP.Name = "textBox_SUSettings_IP";
            this.textBox_SUSettings_IP.Size = new System.Drawing.Size(237, 20);
            this.textBox_SUSettings_IP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox_SUSettings_MAC);
            this.groupBox1.Location = new System.Drawing.Point(47, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAC-address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(256, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MAC-address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox_SUSettings_MAC
            // 
            this.textBox_SUSettings_MAC.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_SUSettings_MAC.Location = new System.Drawing.Point(6, 19);
            this.textBox_SUSettings_MAC.Name = "textBox_SUSettings_MAC";
            this.textBox_SUSettings_MAC.Size = new System.Drawing.Size(236, 20);
            this.textBox_SUSettings_MAC.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(174, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "UDP Server settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 377);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SendTerminalMSG;
        private System.Windows.Forms.TextBox textBoxTerminal;
        private System.Windows.Forms.TextBox textBoxDestHost;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SendString;
        private System.Windows.Forms.TextBox textBoxLoopback_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_SUSettings_MAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_SUSettings_IP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_SUSettings_Time;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_SUSettings_Pswd;
        private System.Windows.Forms.TextBox textBox_SUSettings_Pswd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_SUSettings_DSTPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_SUSettings_SRCPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_SUSettings_Set;
        private System.Windows.Forms.Button button_SUSettings_Get;
    }
}

