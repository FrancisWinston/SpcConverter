﻿namespace SpcConverter.Forms
{
    partial class AboutForm
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
            about_text = new RichTextBox();
            SuspendLayout();
            // 
            // about_text
            // 
            about_text.Cursor = Cursors.No;
            about_text.Location = new Point(12, 12);
            about_text.Name = "about_text";
            about_text.ReadOnly = true;
            about_text.Size = new Size(600, 417);
            about_text.TabIndex = 0;
            about_text.Text = "";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(about_text);
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(640, 480);
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СПО \"Конвертер\" - Справка";
            FormClosing += AboutForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox about_text;
    }
}