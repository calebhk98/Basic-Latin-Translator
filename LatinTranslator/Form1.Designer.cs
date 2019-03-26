namespace LatinTranslator
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
            this.LeftBtn = new System.Windows.Forms.Button();
            this.CenterBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(24, 54);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(134, 88);
            this.LeftBtn.TabIndex = 0;
            this.LeftBtn.Tag = "English";
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // CenterBtn
            // 
            this.CenterBtn.Location = new System.Drawing.Point(197, 54);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(134, 88);
            this.CenterBtn.TabIndex = 1;
            this.CenterBtn.Tag = "English";
            this.CenterBtn.Text = "Center";
            this.CenterBtn.UseVisualStyleBackColor = true;
            this.CenterBtn.Click += new System.EventHandler(this.CenterBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(367, 54);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(134, 88);
            this.RightBtn.TabIndex = 2;
            this.RightBtn.Tag = "English";
            this.RightBtn.Text = "Right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // Language
            // 
            this.Language.Location = new System.Drawing.Point(24, 12);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(64, 31);
            this.Language.TabIndex = 6;
            this.Language.Tag = "English";
            this.Language.Text = "English";
            this.Language.UseVisualStyleBackColor = true;
            this.Language.Click += new System.EventHandler(this.Language_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 208);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.CenterBtn);
            this.Controls.Add(this.LeftBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button CenterBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button Language;
    }
}

