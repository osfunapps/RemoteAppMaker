namespace RemoteAppMaker
{
    partial class Form1
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
            this.tinyPngCB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prototypeRemotePathTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newRemotePathTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tinyPngCB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tinyPngCB
            // 
            this.tinyPngCB.Controls.Add(this.label4);
            this.tinyPngCB.Controls.Add(this.prototypeRemotePathTB);
            this.tinyPngCB.Location = new System.Drawing.Point(12, 12);
            this.tinyPngCB.Name = "tinyPngCB";
            this.tinyPngCB.Size = new System.Drawing.Size(533, 64);
            this.tinyPngCB.TabIndex = 24;
            this.tinyPngCB.TabStop = false;
            this.tinyPngCB.Text = "Prototype Remote Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Path";
            // 
            // prototypeRemotePathTB
            // 
            this.prototypeRemotePathTB.AllowDrop = true;
            this.prototypeRemotePathTB.Location = new System.Drawing.Point(98, 27);
            this.prototypeRemotePathTB.Name = "prototypeRemotePathTB";
            this.prototypeRemotePathTB.Size = new System.Drawing.Size(424, 20);
            this.prototypeRemotePathTB.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.newRemotePathTB);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 64);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Remote Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Path";
            // 
            // newRemotePathTB
            // 
            this.newRemotePathTB.AllowDrop = true;
            this.newRemotePathTB.Location = new System.Drawing.Point(98, 27);
            this.newRemotePathTB.Name = "newRemotePathTB";
            this.newRemotePathTB.Size = new System.Drawing.Size(424, 20);
            this.newRemotePathTB.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.HelpRequest += new System.EventHandler(this.outputFolderDialog_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tinyPngCB);
            this.Name = "Form1";
            this.Text = "Remote App Maker";
            this.tinyPngCB.ResumeLayout(false);
            this.tinyPngCB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tinyPngCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prototypeRemotePathTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newRemotePathTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
    }
}

