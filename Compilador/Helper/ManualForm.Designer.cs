namespace Compilador.Helper
{
    partial class ManualForm
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
            this.wb_help_text = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb_help_text
            // 
            this.wb_help_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_help_text.Location = new System.Drawing.Point(0, 0);
            this.wb_help_text.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_help_text.Name = "wb_help_text";
            this.wb_help_text.Size = new System.Drawing.Size(800, 450);
            this.wb_help_text.TabIndex = 0;
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wb_help_text);
            this.Name = "ManualForm";
            this.Text = "ManualForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_help_text;
    }
}