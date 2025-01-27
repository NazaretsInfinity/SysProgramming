namespace ApiWindowsForms
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
            this.GuessButton = new System.Windows.Forms.Button();
            this.NotepadButton = new System.Windows.Forms.Button();
            this.NotepadUpsateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessButton
            // 
            this.GuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuessButton.Location = new System.Drawing.Point(78, 12);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(275, 67);
            this.GuessButton.TabIndex = 3;
            this.GuessButton.Text = "Guess Number";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // NotepadButton
            // 
            this.NotepadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotepadButton.Location = new System.Drawing.Point(78, 100);
            this.NotepadButton.Name = "NotepadButton";
            this.NotepadButton.Size = new System.Drawing.Size(275, 67);
            this.NotepadButton.TabIndex = 4;
            this.NotepadButton.Text = "Close Notepad";
            this.NotepadButton.UseVisualStyleBackColor = true;
            this.NotepadButton.Click += new System.EventHandler(this.NotepadButton_Click);
            // 
            // NotepadUpsateButton
            // 
            this.NotepadUpsateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotepadUpsateButton.Location = new System.Drawing.Point(78, 188);
            this.NotepadUpsateButton.Name = "NotepadUpsateButton";
            this.NotepadUpsateButton.Size = new System.Drawing.Size(275, 67);
            this.NotepadUpsateButton.TabIndex = 5;
            this.NotepadUpsateButton.Text = "Update Notepad";
            this.NotepadUpsateButton.UseVisualStyleBackColor = true;
            this.NotepadUpsateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 297);
            this.Controls.Add(this.NotepadUpsateButton);
            this.Controls.Add(this.NotepadButton);
            this.Controls.Add(this.GuessButton);
            this.Name = "MainForm";
            this.Text = "NumberGuesser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button NotepadButton;
        private System.Windows.Forms.Button NotepadUpsateButton;
    }
}

