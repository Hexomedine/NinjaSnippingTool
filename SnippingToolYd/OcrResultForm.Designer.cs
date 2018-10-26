namespace NinjaSnippingTool
{
    partial class OcrResultForm
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
            this.OcrTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OcrTextBox
            // 
            this.OcrTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OcrTextBox.Location = new System.Drawing.Point(0, 0);
            this.OcrTextBox.Name = "OcrTextBox";
            this.OcrTextBox.Size = new System.Drawing.Size(800, 450);
            this.OcrTextBox.TabIndex = 0;
            this.OcrTextBox.Text = "";
            // 
            // OcrResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OcrTextBox);
            this.Name = "OcrResultForm";
            this.Text = "Resultat de l\'OCR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OcrResultForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OcrTextBox;
    }
}