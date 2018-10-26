namespace NinjaSnippingTool
{
    partial class SnapForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnapForm));
            this.snapListView = new System.Windows.Forms.ListView();
            this.SaveCompressCB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetOcrButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.SnapBouton = new System.Windows.Forms.Button();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CopyBmpFileButton = new System.Windows.Forms.Button();
            this.CopyFileButton = new System.Windows.Forms.Button();
            this.FocusedItemLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyBmpButton = new System.Windows.Forms.Button();
            this.CopyBmpPathButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CopyJpgButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VideoRecordButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // snapListView
            // 
            this.snapListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapListView.Location = new System.Drawing.Point(0, 0);
            this.snapListView.Name = "snapListView";
            this.snapListView.Size = new System.Drawing.Size(166, 707);
            this.snapListView.TabIndex = 2;
            this.snapListView.UseCompatibleStateImageBehavior = false;
            this.snapListView.VirtualListSize = 100;
            this.snapListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SaveCompressCB
            // 
            this.SaveCompressCB.AutoSize = true;
            this.SaveCompressCB.Location = new System.Drawing.Point(183, 24);
            this.SaveCompressCB.Name = "SaveCompressCB";
            this.SaveCompressCB.Size = new System.Drawing.Size(205, 17);
            this.SaveCompressCB.TabIndex = 4;
            this.SaveCompressCB.Text = "Enregistrer la version non compressée";
            this.SaveCompressCB.UseVisualStyleBackColor = true;
            this.SaveCompressCB.CheckedChanged += new System.EventHandler(this.SaveCompressCB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VideoRecordButton);
            this.panel1.Controls.Add(this.GetOcrButton);
            this.panel1.Controls.Add(this.FullScreenButton);
            this.panel1.Controls.Add(this.SnapBouton);
            this.panel1.Controls.Add(this.OpenFolderButton);
            this.panel1.Controls.Add(this.SaveCompressCB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 63);
            this.panel1.TabIndex = 5;
            // 
            // GetOcrButton
            // 
            this.GetOcrButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GetOcrButton.Location = new System.Drawing.Point(722, 0);
            this.GetOcrButton.Name = "GetOcrButton";
            this.GetOcrButton.Size = new System.Drawing.Size(83, 63);
            this.GetOcrButton.TabIndex = 6;
            this.GetOcrButton.Text = "OCR";
            this.GetOcrButton.UseVisualStyleBackColor = true;
            this.GetOcrButton.Click += new System.EventHandler(this.GetOcrButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FullScreenButton.Image = global::NinjaSnippingTool.Properties.Resources.icons8_monitor_501;
            this.FullScreenButton.Location = new System.Drawing.Point(83, 0);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(85, 63);
            this.FullScreenButton.TabIndex = 5;
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // SnapBouton
            // 
            this.SnapBouton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SnapBouton.Image = global::NinjaSnippingTool.Properties.Resources.icons8_screenshot_26;
            this.SnapBouton.Location = new System.Drawing.Point(0, 0);
            this.SnapBouton.Name = "SnapBouton";
            this.SnapBouton.Size = new System.Drawing.Size(83, 63);
            this.SnapBouton.TabIndex = 2;
            this.SnapBouton.UseVisualStyleBackColor = true;
            this.SnapBouton.Click += new System.EventHandler(this.SnapBouton_Click);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenFolderButton.Image = global::NinjaSnippingTool.Properties.Resources.icons8_open_26;
            this.OpenFolderButton.Location = new System.Drawing.Point(805, 0);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(83, 63);
            this.OpenFolderButton.TabIndex = 3;
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 552);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.snapListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(894, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 707);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CopyBmpFileButton);
            this.panel4.Controls.Add(this.CopyFileButton);
            this.panel4.Controls.Add(this.FocusedItemLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CopyBmpButton);
            this.panel4.Controls.Add(this.CopyBmpPathButton);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.CopyJpgButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(894, 77);
            this.panel4.TabIndex = 7;
            // 
            // CopyBmpFileButton
            // 
            this.CopyBmpFileButton.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.CopyBmpFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyBmpFileButton.Location = new System.Drawing.Point(388, 27);
            this.CopyBmpFileButton.Name = "CopyBmpFileButton";
            this.CopyBmpFileButton.Size = new System.Drawing.Size(70, 40);
            this.CopyBmpFileButton.TabIndex = 13;
            this.CopyBmpFileButton.Text = "Fichier";
            this.CopyBmpFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyBmpFileButton.UseVisualStyleBackColor = true;
            this.CopyBmpFileButton.Click += new System.EventHandler(this.CopyBmpFileButton_Click);
            // 
            // CopyFileButton
            // 
            this.CopyFileButton.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.CopyFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyFileButton.Location = new System.Drawing.Point(155, 27);
            this.CopyFileButton.Name = "CopyFileButton";
            this.CopyFileButton.Size = new System.Drawing.Size(70, 40);
            this.CopyFileButton.TabIndex = 12;
            this.CopyFileButton.Text = "Fichier";
            this.CopyFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyFileButton.UseVisualStyleBackColor = true;
            this.CopyFileButton.Click += new System.EventHandler(this.CopyFileButton_Click);
            // 
            // FocusedItemLabel
            // 
            this.FocusedItemLabel.AutoSize = true;
            this.FocusedItemLabel.Location = new System.Drawing.Point(490, 41);
            this.FocusedItemLabel.Name = "FocusedItemLabel";
            this.FocusedItemLabel.Size = new System.Drawing.Size(0, 13);
            this.FocusedItemLabel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Image séléctionnée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Non Compressé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compressé";
            // 
            // CopyBmpButton
            // 
            this.CopyBmpButton.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.CopyBmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyBmpButton.Location = new System.Drawing.Point(312, 27);
            this.CopyBmpButton.Name = "CopyBmpButton";
            this.CopyBmpButton.Size = new System.Drawing.Size(70, 40);
            this.CopyBmpButton.TabIndex = 6;
            this.CopyBmpButton.Text = "Image";
            this.CopyBmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyBmpButton.UseVisualStyleBackColor = true;
            this.CopyBmpButton.Click += new System.EventHandler(this.CopyBmpButton_Click);
            // 
            // CopyBmpPathButton
            // 
            this.CopyBmpPathButton.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.CopyBmpPathButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyBmpPathButton.Location = new System.Drawing.Point(236, 27);
            this.CopyBmpPathButton.Name = "CopyBmpPathButton";
            this.CopyBmpPathButton.Size = new System.Drawing.Size(70, 40);
            this.CopyBmpPathButton.TabIndex = 7;
            this.CopyBmpPathButton.Text = "/.../";
            this.CopyBmpPathButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyBmpPathButton.UseVisualStyleBackColor = true;
            this.CopyBmpPathButton.Click += new System.EventHandler(this.CopyBmpPathButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 27);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "/.../";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAddPathToClip_Click);
            // 
            // CopyJpgButton
            // 
            this.CopyJpgButton.Image = global::NinjaSnippingTool.Properties.Resources.clipboard_24px;
            this.CopyJpgButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyJpgButton.Location = new System.Drawing.Point(79, 27);
            this.CopyJpgButton.Name = "CopyJpgButton";
            this.CopyJpgButton.Size = new System.Drawing.Size(70, 40);
            this.CopyJpgButton.TabIndex = 5;
            this.CopyJpgButton.Text = "Image";
            this.CopyJpgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyJpgButton.UseVisualStyleBackColor = true;
            this.CopyJpgButton.Click += new System.EventHandler(this.CopyJpgButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.82143F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.51064F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 630);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // VideoRecordButton
            // 
            this.VideoRecordButton.Location = new System.Drawing.Point(543, 24);
            this.VideoRecordButton.Name = "VideoRecordButton";
            this.VideoRecordButton.Size = new System.Drawing.Size(75, 23);
            this.VideoRecordButton.TabIndex = 7;
            this.VideoRecordButton.Text = "Video";
            this.VideoRecordButton.UseVisualStyleBackColor = true;
            this.VideoRecordButton.Click += new System.EventHandler(this.VideoRecordButton_Click);
            // 
            // SnapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnapForm";
            this.Text = "Ninja Snipping tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView snapListView;
        private System.Windows.Forms.Button SnapBouton;
        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.CheckBox SaveCompressCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CopyJpgButton;
        private System.Windows.Forms.Button CopyBmpButton;
        private System.Windows.Forms.Button CopyBmpPathButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FocusedItemLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CopyBmpFileButton;
        private System.Windows.Forms.Button CopyFileButton;
        private System.Windows.Forms.Button GetOcrButton;
        private System.Windows.Forms.Button VideoRecordButton;
    }
}

