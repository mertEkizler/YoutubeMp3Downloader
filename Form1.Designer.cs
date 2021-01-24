
namespace YoutubeMp3Downloader
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonMP3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMP4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHeader.Location = new System.Drawing.Point(25, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(411, 29);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Youtube MP3/MP4 Downloader";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Format:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 3;
            // 
            // radioButtonMP3
            // 
            this.radioButtonMP3.AutoSize = true;
            this.radioButtonMP3.Checked = true;
            this.radioButtonMP3.Location = new System.Drawing.Point(128, 93);
            this.radioButtonMP3.Name = "radioButtonMP3";
            this.radioButtonMP3.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMP3.TabIndex = 4;
            this.radioButtonMP3.TabStop = true;
            this.radioButtonMP3.Text = "MP3";
            this.radioButtonMP3.UseVisualStyleBackColor = true;
            this.radioButtonMP3.CheckedChanged += new System.EventHandler(this.radioButtonMP3_CheckedChanged);
            // 
            // radioButtonMP4
            // 
            this.radioButtonMP4.AutoSize = true;
            this.radioButtonMP4.Location = new System.Drawing.Point(181, 93);
            this.radioButtonMP4.Name = "radioButtonMP4";
            this.radioButtonMP4.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMP4.TabIndex = 5;
            this.radioButtonMP4.Text = "MP4";
            this.radioButtonMP4.UseVisualStyleBackColor = true;
            this.radioButtonMP4.CheckedChanged += new System.EventHandler(this.radioButtonMP4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(234, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDurum
            // 
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDurum.Location = new System.Drawing.Point(25, 133);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(411, 29);
            this.labelDurum.TabIndex = 9;
            this.labelDurum.Text = "-";
            this.labelDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDurum.Click += new System.EventHandler(this.labelDurum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 172);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonMP4);
            this.Controls.Add(this.radioButtonMP3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHeader);
            this.Name = "Form1";
            this.Text = "Chosen234";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonMP3;
        private System.Windows.Forms.RadioButton radioButtonMP4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDurum;
    }
}

