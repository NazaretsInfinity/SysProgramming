namespace HW_ApiWinForms
{
    partial class MainForm
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
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.UpdateCaptionButton = new System.Windows.Forms.Button();
            this.BeepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseWindowButton.Location = new System.Drawing.Point(83, 32);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(269, 59);
            this.CloseWindowButton.TabIndex = 0;
            this.CloseWindowButton.Text = "Close Window";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // UpdateCaptionButton
            // 
            this.UpdateCaptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateCaptionButton.Location = new System.Drawing.Point(83, 119);
            this.UpdateCaptionButton.Name = "UpdateCaptionButton";
            this.UpdateCaptionButton.Size = new System.Drawing.Size(269, 59);
            this.UpdateCaptionButton.TabIndex = 1;
            this.UpdateCaptionButton.Text = "Rename Window";
            this.UpdateCaptionButton.UseVisualStyleBackColor = true;
            this.UpdateCaptionButton.Click += new System.EventHandler(this.UpdateCaptionButton_Click);
            // 
            // BeepButton
            // 
            this.BeepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeepButton.Location = new System.Drawing.Point(83, 208);
            this.BeepButton.Name = "BeepButton";
            this.BeepButton.Size = new System.Drawing.Size(269, 59);
            this.BeepButton.TabIndex = 2;
            this.BeepButton.Text = "Sounds";
            this.BeepButton.UseVisualStyleBackColor = true;
            this.BeepButton.Click += new System.EventHandler(this.BeepButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 299);
            this.Controls.Add(this.BeepButton);
            this.Controls.Add(this.UpdateCaptionButton);
            this.Controls.Add(this.CloseWindowButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button UpdateCaptionButton;
        private System.Windows.Forms.Button BeepButton;
    }
}

