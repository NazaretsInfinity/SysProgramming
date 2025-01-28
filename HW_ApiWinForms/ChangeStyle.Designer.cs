namespace HW_ApiWinForms
{
    partial class ChangeStyle
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
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Location = new System.Drawing.Point(32, 113);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(332, 24);
            this.FontBox.TabIndex = 0;
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontLabel.Location = new System.Drawing.Point(27, 69);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(321, 29);
            this.FontLabel.TabIndex = 1;
            this.FontLabel.Text = "Choose new font for Form:";
            // 
            // ChangeStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 186);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.FontBox);
            this.Name = "ChangeStyle";
            this.Text = "ChangeStyle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.Label FontLabel;
    }
}