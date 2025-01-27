namespace HW_ApiWinForms
{
    partial class RenamingForm
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
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.RenamingUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNameLabel.Location = new System.Drawing.Point(26, 25);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(144, 29);
            this.NewNameLabel.TabIndex = 0;
            this.NewNameLabel.Text = "New name:";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(195, 28);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(229, 22);
            this.RenameTextBox.TabIndex = 1;
            // 
            // RenamingUpdateButton
            // 
            this.RenamingUpdateButton.Location = new System.Drawing.Point(349, 65);
            this.RenamingUpdateButton.Name = "RenamingUpdateButton";
            this.RenamingUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.RenamingUpdateButton.TabIndex = 2;
            this.RenamingUpdateButton.Text = "update";
            this.RenamingUpdateButton.UseVisualStyleBackColor = true;
            this.RenamingUpdateButton.Click += new System.EventHandler(this.RenamingUpdateButton_Click);
            // 
            // RenamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 100);
            this.Controls.Add(this.RenamingUpdateButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.NewNameLabel);
            this.Name = "RenamingForm";
            this.Text = "RenamingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.Button RenamingUpdateButton;
    }
}