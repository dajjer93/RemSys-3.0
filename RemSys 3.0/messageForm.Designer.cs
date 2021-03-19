using System.Windows.Forms;
using System.Drawing;
using MetroFramework.Controls;

namespace RemSys_3._0
{
    partial class messageForm
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
            this.labelFrom = new MetroFramework.Controls.MetroLabel();
            this.labelMessage = new MetroFramework.Controls.MetroLabel();
            this.textBoxReply = new MetroFramework.Controls.MetroTextBox();
            this.buttonReply = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(3, 9);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(41, 19);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "from:";
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(3, 33);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(277, 96);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "from:";
            // 
            // textBoxReply
            // 
            // 
            // 
            // 
            this.textBoxReply.CustomButton.Image = null;
            this.textBoxReply.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.textBoxReply.CustomButton.Name = "";
            this.textBoxReply.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxReply.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxReply.CustomButton.TabIndex = 1;
            this.textBoxReply.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxReply.CustomButton.UseSelectable = true;
            this.textBoxReply.CustomButton.Visible = false;
            this.textBoxReply.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxReply.Lines = new string[0];
            this.textBoxReply.Location = new System.Drawing.Point(2, 132);
            this.textBoxReply.MaxLength = 80;
            this.textBoxReply.Name = "textBoxReply";
            this.textBoxReply.PasswordChar = '\0';
            this.textBoxReply.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxReply.SelectedText = "";
            this.textBoxReply.SelectionLength = 0;
            this.textBoxReply.SelectionStart = 0;
            this.textBoxReply.ShortcutsEnabled = true;
            this.textBoxReply.Size = new System.Drawing.Size(278, 25);
            this.textBoxReply.TabIndex = 2;
            this.textBoxReply.UseSelectable = true;
            this.textBoxReply.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxReply.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxReply.TextChanged += new System.EventHandler(this.textBoxReply_TextChanged);
            this.textBoxReply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReply_KeyPress);
            // 
            // buttonReply
            // 
            this.buttonReply.Location = new System.Drawing.Point(2, 158);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(75, 23);
            this.buttonReply.TabIndex = 3;
            this.buttonReply.Text = "Reply";
            this.buttonReply.UseSelectable = true;
            this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(206, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // messageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonReply);
            this.Controls.Add(this.textBoxReply);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.messageForm_Load);
            this.Shown += new System.EventHandler(this.messageForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel labelFrom;
        private MetroLabel labelMessage;
        private MetroTextBox textBoxReply;
        private MetroButton buttonReply;
        private MetroButton button2;
        private Timer timer1;
    }
}