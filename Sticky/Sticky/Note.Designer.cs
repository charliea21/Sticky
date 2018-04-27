namespace Sticky
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.topbar = new System.Windows.Forms.Panel();
            this.notif = new System.Windows.Forms.NotifyIcon(this.components);
            this.settings = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.YellowGreen;
            this.topbar.Controls.Add(this.close);
            this.topbar.Controls.Add(this.label1);
            this.topbar.Controls.Add(this.settings);
            this.topbar.ForeColor = System.Drawing.Color.White;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(400, 50);
            this.topbar.TabIndex = 0;
            // 
            // notif
            // 
            this.notif.Icon = ((System.Drawing.Icon)(resources.GetObject("notif.Icon")));
            this.notif.Text = "Sticky";
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(60, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 0;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sticky";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(351, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 36);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 350);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Type your note here";
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sticky";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Note_Load);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.NotifyIcon notif;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

