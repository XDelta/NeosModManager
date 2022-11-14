namespace NeosModManager {
    partial class ModInfoView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelMIV_Name = new System.Windows.Forms.Label();
            this.buttonMIV_ViewSource = new System.Windows.Forms.Button();
            this.labelMIV_Author = new System.Windows.Forms.Label();
            this.labelMIV_Categories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMIV_Desciption = new System.Windows.Forms.Label();
            this.labelMIV_InstalledHash = new System.Windows.Forms.Label();
            this.labelMIV_LatestHash = new System.Windows.Forms.Label();
            this.labelMIV_InstalledVersion = new System.Windows.Forms.Label();
            this.labelMIV_LatestVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMIV_Name
            // 
            this.labelMIV_Name.AutoSize = true;
            this.labelMIV_Name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMIV_Name.Location = new System.Drawing.Point(12, 9);
            this.labelMIV_Name.MaximumSize = new System.Drawing.Size(580, 60);
            this.labelMIV_Name.Name = "labelMIV_Name";
            this.labelMIV_Name.Size = new System.Drawing.Size(131, 30);
            this.labelMIV_Name.TabIndex = 0;
            this.labelMIV_Name.Text = "{ModName}";
            // 
            // buttonMIV_ViewSource
            // 
            this.buttonMIV_ViewSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMIV_ViewSource.Location = new System.Drawing.Point(12, 326);
            this.buttonMIV_ViewSource.Name = "buttonMIV_ViewSource";
            this.buttonMIV_ViewSource.Size = new System.Drawing.Size(146, 23);
            this.buttonMIV_ViewSource.TabIndex = 1;
            this.buttonMIV_ViewSource.Text = "Open Source Location";
            this.buttonMIV_ViewSource.UseVisualStyleBackColor = true;
            this.buttonMIV_ViewSource.Click += new System.EventHandler(this.viewSourceLocation_Click);
            // 
            // labelMIV_Author
            // 
            this.labelMIV_Author.AutoSize = true;
            this.labelMIV_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMIV_Author.Location = new System.Drawing.Point(12, 39);
            this.labelMIV_Author.Name = "labelMIV_Author";
            this.labelMIV_Author.Size = new System.Drawing.Size(125, 21);
            this.labelMIV_Author.TabIndex = 2;
            this.labelMIV_Author.Text = "by {Mod Author}";
            // 
            // labelMIV_Categories
            // 
            this.labelMIV_Categories.AutoSize = true;
            this.labelMIV_Categories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMIV_Categories.Location = new System.Drawing.Point(12, 60);
            this.labelMIV_Categories.Name = "labelMIV_Categories";
            this.labelMIV_Categories.Size = new System.Drawing.Size(68, 19);
            this.labelMIV_Categories.TabIndex = 3;
            this.labelMIV_Categories.Text = "Category:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 1);
            this.label2.TabIndex = 23;
            // 
            // labelMIV_Desciption
            // 
            this.labelMIV_Desciption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMIV_Desciption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMIV_Desciption.Location = new System.Drawing.Point(12, 84);
            this.labelMIV_Desciption.Name = "labelMIV_Desciption";
            this.labelMIV_Desciption.Size = new System.Drawing.Size(460, 167);
            this.labelMIV_Desciption.TabIndex = 24;
            this.labelMIV_Desciption.Text = "{Description}";
            // 
            // labelMIV_InstalledHash
            // 
            this.labelMIV_InstalledHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMIV_InstalledHash.AutoSize = true;
            this.labelMIV_InstalledHash.Location = new System.Drawing.Point(12, 266);
            this.labelMIV_InstalledHash.Name = "labelMIV_InstalledHash";
            this.labelMIV_InstalledHash.Size = new System.Drawing.Size(146, 15);
            this.labelMIV_InstalledHash.TabIndex = 25;
            this.labelMIV_InstalledHash.Text = "{Installed Hash} - {Version}";
            // 
            // labelMIV_LatestHash
            // 
            this.labelMIV_LatestHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMIV_LatestHash.AutoSize = true;
            this.labelMIV_LatestHash.Location = new System.Drawing.Point(12, 296);
            this.labelMIV_LatestHash.Name = "labelMIV_LatestHash";
            this.labelMIV_LatestHash.Size = new System.Drawing.Size(133, 15);
            this.labelMIV_LatestHash.TabIndex = 26;
            this.labelMIV_LatestHash.Text = "{Latest Hash} - {Version}";
            // 
            // labelMIV_InstalledVersion
            // 
            this.labelMIV_InstalledVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMIV_InstalledVersion.AutoSize = true;
            this.labelMIV_InstalledVersion.Location = new System.Drawing.Point(12, 251);
            this.labelMIV_InstalledVersion.Name = "labelMIV_InstalledVersion";
            this.labelMIV_InstalledVersion.Size = new System.Drawing.Size(95, 15);
            this.labelMIV_InstalledVersion.TabIndex = 27;
            this.labelMIV_InstalledVersion.Text = "Installed Version:";
            // 
            // labelMIV_LatestVersion
            // 
            this.labelMIV_LatestVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMIV_LatestVersion.AutoSize = true;
            this.labelMIV_LatestVersion.Location = new System.Drawing.Point(12, 281);
            this.labelMIV_LatestVersion.Name = "labelMIV_LatestVersion";
            this.labelMIV_LatestVersion.Size = new System.Drawing.Size(82, 15);
            this.labelMIV_LatestVersion.TabIndex = 28;
            this.labelMIV_LatestVersion.Text = "Latest Version:";
            // 
            // ModInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelMIV_LatestVersion);
            this.Controls.Add(this.labelMIV_InstalledVersion);
            this.Controls.Add(this.labelMIV_LatestHash);
            this.Controls.Add(this.labelMIV_InstalledHash);
            this.Controls.Add(this.labelMIV_Desciption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMIV_Categories);
            this.Controls.Add(this.labelMIV_Author);
            this.Controls.Add(this.buttonMIV_ViewSource);
            this.Controls.Add(this.labelMIV_Name);
            this.Icon = global::NeosModManager.Properties.Resources.NMGIcon;
            this.Name = "ModInfoView";
            this.Text = "Mod Info";
            this.Load += new System.EventHandler(this.ModInfoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMIV_Name;
        private Button buttonMIV_ViewSource;
        private Label labelMIV_Author;
        private Label labelMIV_Categories;
        private Label label2;
        private Label labelMIV_Desciption;
        private Label labelMIV_InstalledHash;
        private Label labelMIV_LatestHash;
        private Label labelMIV_InstalledVersion;
        private Label labelMIV_LatestVersion;
    }
}