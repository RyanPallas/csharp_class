﻿namespace basic_collection
{
    partial class frmMouse_MouseDown
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
            this.SuspendLayout();
            // 
            // frmMouse_MouseDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMouse_MouseDown";
            this.Text = "frmMouse_MouseDown";
            this.Load += new System.EventHandler(this.frmMouse_MouseDown_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMouse_MouseDown_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMouse_MouseDown_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}