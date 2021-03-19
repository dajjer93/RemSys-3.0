using MetroFramework.Controls;
using MetroFramework.Forms;

namespace RemSys_3._0
{
    partial class mainForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxLocalKeypass = new MetroFramework.Controls.MetroTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBoxStartup = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxHideStartup = new MetroFramework.Controls.MetroCheckBox();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.buttonHide = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxIPAddress = new MetroFramework.Controls.MetroTextBox();
            this.buttonRun = new MetroFramework.Controls.MetroButton();
            this.buttonNew = new MetroFramework.Controls.MetroButton();
            this.buttonDelete = new MetroFramework.Controls.MetroButton();
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxKeypass = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxArguments = new MetroFramework.Controls.MetroTextBox();
            this.labelCommand = new MetroFramework.Controls.MetroLabel();
            this.textBoxCommand = new MetroFramework.Controls.MetroTextBox();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.textBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.runSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRemoteKeypass = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.textBoxChatRemoteHost = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.textBoxMessage = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAlias = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Local Keypass";
            // 
            // textBoxLocalKeypass
            // 
            // 
            // 
            // 
            this.textBoxLocalKeypass.CustomButton.Image = null;
            this.textBoxLocalKeypass.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.textBoxLocalKeypass.CustomButton.Name = "";
            this.textBoxLocalKeypass.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxLocalKeypass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxLocalKeypass.CustomButton.TabIndex = 1;
            this.textBoxLocalKeypass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxLocalKeypass.CustomButton.UseSelectable = true;
            this.textBoxLocalKeypass.CustomButton.Visible = false;
            this.textBoxLocalKeypass.Lines = new string[0];
            this.textBoxLocalKeypass.Location = new System.Drawing.Point(106, 41);
            this.textBoxLocalKeypass.MaxLength = 32767;
            this.textBoxLocalKeypass.Name = "textBoxLocalKeypass";
            this.textBoxLocalKeypass.PasswordChar = '*';
            this.textBoxLocalKeypass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxLocalKeypass.SelectedText = "";
            this.textBoxLocalKeypass.SelectionLength = 0;
            this.textBoxLocalKeypass.SelectionStart = 0;
            this.textBoxLocalKeypass.ShortcutsEnabled = true;
            this.textBoxLocalKeypass.Size = new System.Drawing.Size(107, 20);
            this.textBoxLocalKeypass.TabIndex = 13;
            this.textBoxLocalKeypass.UseSelectable = true;
            this.textBoxLocalKeypass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxLocalKeypass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLocalKeypass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RemSys 3.0";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(17, 15);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(94, 15);
            this.checkBoxStartup.TabIndex = 18;
            this.checkBoxStartup.Text = "run at startup";
            this.checkBoxStartup.UseSelectable = true;
            this.checkBoxStartup.CheckedChanged += new System.EventHandler(this.checkBoxStartup_CheckedChanged);
            // 
            // checkBoxHideStartup
            // 
            this.checkBoxHideStartup.AutoSize = true;
            this.checkBoxHideStartup.Location = new System.Drawing.Point(113, 15);
            this.checkBoxHideStartup.Name = "checkBoxHideStartup";
            this.checkBoxHideStartup.Size = new System.Drawing.Size(144, 15);
            this.checkBoxHideStartup.TabIndex = 19;
            this.checkBoxHideStartup.Text = "hide window at startup";
            this.checkBoxHideStartup.UseSelectable = true;
            this.checkBoxHideStartup.CheckedChanged += new System.EventHandler(this.checkBoxHideStartup_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 400);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.buttonHide);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxIPAddress);
            this.tabPage1.Controls.Add(this.buttonRun);
            this.tabPage1.Controls.Add(this.buttonNew);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxKeypass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxArguments);
            this.tabPage1.Controls.Add(this.labelCommand);
            this.tabPage1.Controls.Add(this.textBoxCommand);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.metroComboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Commands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(245, 323);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 32);
            this.metroButton1.TabIndex = 46;
            this.metroButton1.Text = "Close App";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            this.metroButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.metroButton1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(335, 323);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(84, 32);
            this.buttonHide.TabIndex = 10;
            this.buttonHide.Text = "Hide Window";
            this.buttonHide.UseSelectable = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            this.buttonHide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.buttonHide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Host";
            // 
            // textBoxIPAddress
            // 
            // 
            // 
            // 
            this.textBoxIPAddress.CustomButton.Image = null;
            this.textBoxIPAddress.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.textBoxIPAddress.CustomButton.Name = "";
            this.textBoxIPAddress.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBoxIPAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxIPAddress.CustomButton.TabIndex = 1;
            this.textBoxIPAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxIPAddress.CustomButton.UseSelectable = true;
            this.textBoxIPAddress.CustomButton.Visible = false;
            this.textBoxIPAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxIPAddress.Lines = new string[0];
            this.textBoxIPAddress.Location = new System.Drawing.Point(234, 118);
            this.textBoxIPAddress.MaxLength = 32767;
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.PasswordChar = '\0';
            this.textBoxIPAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxIPAddress.SelectedText = "";
            this.textBoxIPAddress.SelectionLength = 0;
            this.textBoxIPAddress.SelectionStart = 0;
            this.textBoxIPAddress.ShortcutsEnabled = true;
            this.textBoxIPAddress.Size = new System.Drawing.Size(150, 29);
            this.textBoxIPAddress.TabIndex = 5;
            this.textBoxIPAddress.UseSelectable = true;
            this.textBoxIPAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxIPAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxIPAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // buttonRun
            // 
            this.buttonRun.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonRun.Location = new System.Drawing.Point(162, 175);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(136, 20);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "Run Command";
            this.buttonRun.UseSelectable = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            this.buttonRun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.buttonRun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // buttonNew
            // 
            this.buttonNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonNew.Location = new System.Drawing.Point(343, 151);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(65, 20);
            this.buttonNew.TabIndex = 9;
            this.buttonNew.Text = "New";
            this.buttonNew.UseSelectable = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            this.buttonNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.buttonNew.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonDelete.Location = new System.Drawing.Point(233, 151);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 20);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseSelectable = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.buttonDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // buttonSave
            // 
            this.buttonSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonSave.Location = new System.Drawing.Point(162, 151);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 20);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseSelectable = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.buttonSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Keypass";
            // 
            // textBoxKeypass
            // 
            // 
            // 
            // 
            this.textBoxKeypass.CustomButton.Image = null;
            this.textBoxKeypass.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxKeypass.CustomButton.Name = "";
            this.textBoxKeypass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxKeypass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxKeypass.CustomButton.TabIndex = 1;
            this.textBoxKeypass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxKeypass.CustomButton.UseSelectable = true;
            this.textBoxKeypass.CustomButton.Visible = false;
            this.textBoxKeypass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxKeypass.Lines = new string[0];
            this.textBoxKeypass.Location = new System.Drawing.Point(234, 90);
            this.textBoxKeypass.MaxLength = 32767;
            this.textBoxKeypass.Name = "textBoxKeypass";
            this.textBoxKeypass.PasswordChar = '*';
            this.textBoxKeypass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxKeypass.SelectedText = "";
            this.textBoxKeypass.SelectionLength = 0;
            this.textBoxKeypass.SelectionStart = 0;
            this.textBoxKeypass.ShortcutsEnabled = true;
            this.textBoxKeypass.Size = new System.Drawing.Size(177, 25);
            this.textBoxKeypass.TabIndex = 4;
            this.textBoxKeypass.UseSelectable = true;
            this.textBoxKeypass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxKeypass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxKeypass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxKeypass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Arguments";
            // 
            // textBoxArguments
            // 
            // 
            // 
            // 
            this.textBoxArguments.CustomButton.Image = null;
            this.textBoxArguments.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxArguments.CustomButton.Name = "";
            this.textBoxArguments.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxArguments.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxArguments.CustomButton.TabIndex = 1;
            this.textBoxArguments.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxArguments.CustomButton.UseSelectable = true;
            this.textBoxArguments.CustomButton.Visible = false;
            this.textBoxArguments.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxArguments.Lines = new string[0];
            this.textBoxArguments.Location = new System.Drawing.Point(234, 61);
            this.textBoxArguments.MaxLength = 32767;
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.PasswordChar = '\0';
            this.textBoxArguments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxArguments.SelectedText = "";
            this.textBoxArguments.SelectionLength = 0;
            this.textBoxArguments.SelectionStart = 0;
            this.textBoxArguments.ShortcutsEnabled = true;
            this.textBoxArguments.Size = new System.Drawing.Size(177, 25);
            this.textBoxArguments.TabIndex = 3;
            this.textBoxArguments.UseSelectable = true;
            this.textBoxArguments.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxArguments.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxArguments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxArguments.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(160, 35);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(72, 19);
            this.labelCommand.TabIndex = 25;
            this.labelCommand.Text = "Command";
            // 
            // textBoxCommand
            // 
            // 
            // 
            // 
            this.textBoxCommand.CustomButton.Image = null;
            this.textBoxCommand.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxCommand.CustomButton.Name = "";
            this.textBoxCommand.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCommand.CustomButton.TabIndex = 1;
            this.textBoxCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCommand.CustomButton.UseSelectable = true;
            this.textBoxCommand.CustomButton.Visible = false;
            this.textBoxCommand.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxCommand.Lines = new string[0];
            this.textBoxCommand.Location = new System.Drawing.Point(234, 32);
            this.textBoxCommand.MaxLength = 32767;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.PasswordChar = '\0';
            this.textBoxCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCommand.SelectedText = "";
            this.textBoxCommand.SelectionLength = 0;
            this.textBoxCommand.SelectionStart = 0;
            this.textBoxCommand.ShortcutsEnabled = true;
            this.textBoxCommand.Size = new System.Drawing.Size(177, 25);
            this.textBoxCommand.TabIndex = 2;
            this.textBoxCommand.UseSelectable = true;
            this.textBoxCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(160, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 19);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            // 
            // 
            // 
            this.textBoxTitle.CustomButton.Image = null;
            this.textBoxTitle.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.textBoxTitle.CustomButton.Name = "";
            this.textBoxTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTitle.CustomButton.TabIndex = 1;
            this.textBoxTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTitle.CustomButton.UseSelectable = true;
            this.textBoxTitle.CustomButton.Visible = false;
            this.textBoxTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxTitle.Lines = new string[0];
            this.textBoxTitle.Location = new System.Drawing.Point(234, 3);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.ShortcutsEnabled = true;
            this.textBoxTitle.Size = new System.Drawing.Size(177, 25);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.UseSelectable = true;
            this.textBoxTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.metroContextMenu1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(146, 342);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSelectedToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(142, 48);
            // 
            // runSelectedToolStripMenuItem
            // 
            this.runSelectedToolStripMenuItem.Name = "runSelectedToolStripMenuItem";
            this.runSelectedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.runSelectedToolStripMenuItem.Text = "Run selected";
            this.runSelectedToolStripMenuItem.Click += new System.EventHandler(this.runSelectedToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(234, 118);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(175, 29);
            this.metroComboBox1.TabIndex = 47;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBoxLocalKeypass);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkBoxHideStartup);
            this.tabPage2.Controls.Add(this.checkBoxStartup);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(245, 323);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(84, 32);
            this.metroButton2.TabIndex = 47;
            this.metroButton2.Text = "Close App";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Hide Window";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroButton3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBoxRemoteKeypass);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBoxChatRemoteHost);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBoxMessage);
            this.tabPage3.Controls.Add(this.textBoxAlias);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(421, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Messaging";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(245, 323);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(84, 32);
            this.metroButton3.TabIndex = 62;
            this.metroButton3.Text = "Close App";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 33);
            this.button3.TabIndex = 60;
            this.button3.Text = "Hide Window";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(5, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(412, 231);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Alias";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Message";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IPPort";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 61;
            // 
            // textBoxRemoteKeypass
            // 
            // 
            // 
            // 
            this.textBoxRemoteKeypass.CustomButton.Image = null;
            this.textBoxRemoteKeypass.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.textBoxRemoteKeypass.CustomButton.Name = "";
            this.textBoxRemoteKeypass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxRemoteKeypass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxRemoteKeypass.CustomButton.TabIndex = 1;
            this.textBoxRemoteKeypass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxRemoteKeypass.CustomButton.UseSelectable = true;
            this.textBoxRemoteKeypass.CustomButton.Visible = false;
            this.textBoxRemoteKeypass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxRemoteKeypass.Lines = new string[0];
            this.textBoxRemoteKeypass.Location = new System.Drawing.Point(269, 270);
            this.textBoxRemoteKeypass.MaxLength = 32767;
            this.textBoxRemoteKeypass.Name = "textBoxRemoteKeypass";
            this.textBoxRemoteKeypass.PasswordChar = '*';
            this.textBoxRemoteKeypass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRemoteKeypass.SelectedText = "";
            this.textBoxRemoteKeypass.SelectionLength = 0;
            this.textBoxRemoteKeypass.SelectionStart = 0;
            this.textBoxRemoteKeypass.ShortcutsEnabled = true;
            this.textBoxRemoteKeypass.Size = new System.Drawing.Size(150, 25);
            this.textBoxRemoteKeypass.TabIndex = 26;
            this.textBoxRemoteKeypass.UseSelectable = true;
            this.textBoxRemoteKeypass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxRemoteKeypass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Keypass";
            // 
            // textBoxChatRemoteHost
            // 
            // 
            // 
            // 
            this.textBoxChatRemoteHost.CustomButton.Image = null;
            this.textBoxChatRemoteHost.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.textBoxChatRemoteHost.CustomButton.Name = "";
            this.textBoxChatRemoteHost.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxChatRemoteHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxChatRemoteHost.CustomButton.TabIndex = 1;
            this.textBoxChatRemoteHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxChatRemoteHost.CustomButton.UseSelectable = true;
            this.textBoxChatRemoteHost.CustomButton.Visible = false;
            this.textBoxChatRemoteHost.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxChatRemoteHost.Lines = new string[0];
            this.textBoxChatRemoteHost.Location = new System.Drawing.Point(41, 269);
            this.textBoxChatRemoteHost.MaxLength = 32767;
            this.textBoxChatRemoteHost.Name = "textBoxChatRemoteHost";
            this.textBoxChatRemoteHost.PasswordChar = '\0';
            this.textBoxChatRemoteHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxChatRemoteHost.SelectedText = "";
            this.textBoxChatRemoteHost.SelectionLength = 0;
            this.textBoxChatRemoteHost.SelectionStart = 0;
            this.textBoxChatRemoteHost.ShortcutsEnabled = true;
            this.textBoxChatRemoteHost.Size = new System.Drawing.Size(145, 25);
            this.textBoxChatRemoteHost.TabIndex = 25;
            this.textBoxChatRemoteHost.UseSelectable = true;
            this.textBoxChatRemoteHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxChatRemoteHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Host";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Send Message";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessage
            // 
            // 
            // 
            // 
            this.textBoxMessage.CustomButton.Image = null;
            this.textBoxMessage.CustomButton.Location = new System.Drawing.Point(393, 1);
            this.textBoxMessage.CustomButton.Name = "";
            this.textBoxMessage.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxMessage.CustomButton.TabIndex = 1;
            this.textBoxMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxMessage.CustomButton.UseSelectable = true;
            this.textBoxMessage.CustomButton.Visible = false;
            this.textBoxMessage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxMessage.Lines = new string[0];
            this.textBoxMessage.Location = new System.Drawing.Point(2, 297);
            this.textBoxMessage.MaxLength = 80;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.PasswordChar = '\0';
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMessage.SelectedText = "";
            this.textBoxMessage.SelectionLength = 0;
            this.textBoxMessage.SelectionStart = 0;
            this.textBoxMessage.ShortcutsEnabled = true;
            this.textBoxMessage.Size = new System.Drawing.Size(417, 25);
            this.textBoxMessage.TabIndex = 27;
            this.textBoxMessage.UseSelectable = true;
            this.textBoxMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // textBoxAlias
            // 
            // 
            // 
            // 
            this.textBoxAlias.CustomButton.Image = null;
            this.textBoxAlias.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.textBoxAlias.CustomButton.Name = "";
            this.textBoxAlias.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxAlias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAlias.CustomButton.TabIndex = 1;
            this.textBoxAlias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAlias.CustomButton.UseSelectable = true;
            this.textBoxAlias.CustomButton.Visible = false;
            this.textBoxAlias.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxAlias.Lines = new string[0];
            this.textBoxAlias.Location = new System.Drawing.Point(43, 6);
            this.textBoxAlias.MaxLength = 32767;
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.PasswordChar = '\0';
            this.textBoxAlias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAlias.SelectedText = "";
            this.textBoxAlias.SelectionLength = 0;
            this.textBoxAlias.SelectionStart = 0;
            this.textBoxAlias.ShortcutsEnabled = true;
            this.textBoxAlias.Size = new System.Drawing.Size(143, 25);
            this.textBoxAlias.TabIndex = 22;
            this.textBoxAlias.UseSelectable = true;
            this.textBoxAlias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAlias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxAlias.TextChanged += new System.EventHandler(this.textBoxAlias_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Alias";
            // 
            // comboBox1
            // 
            this.comboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 19;
            this.comboBox1.Location = new System.Drawing.Point(43, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 25);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 480);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 519);
            this.MinimumSize = new System.Drawing.Size(422, 395);
            this.Name = "mainForm";
            this.Text = "RemSys 3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroLabel label1;
        private MetroTextBox textBoxLocalKeypass;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroCheckBox checkBoxStartup;
        private MetroCheckBox checkBoxHideStartup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroButton buttonHide;
        private MetroLabel label2;
        private MetroTextBox textBoxIPAddress;
        private MetroButton buttonRun;
        private MetroButton buttonNew;
        private MetroButton buttonDelete;
        private MetroButton buttonSave;
        private MetroLabel label4;
        private MetroTextBox textBoxKeypass;
        private MetroLabel label3;
        private MetroTextBox textBoxArguments;
        private MetroLabel labelCommand;
        private MetroTextBox textBoxCommand;
        private MetroLabel labelTitle;
        private MetroTextBox textBoxTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroTextBox textBoxAlias;
        private MetroLabel label5;
        private MetroButton button1;
        private MetroTextBox textBoxMessage;
        private MetroTextBox textBoxChatRemoteHost;
        private MetroLabel label6;
        private MetroTextBox textBoxRemoteKeypass;
        private MetroLabel label7;
        private MetroGrid dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroButton button2;
        private MetroButton button3;
        private MetroComboBox comboBox1;
        private MetroButton metroButton1;
        private MetroButton metroButton2;
        private MetroButton metroButton3;
        private MetroComboBox metroComboBox1;
        private MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem runSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

