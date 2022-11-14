namespace NeosModManager {
    partial class NoPathSetPrompt {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettingsPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpacer2 = new System.Windows.Forms.Label();
            this.buttonIgnoreNeosInstallMissing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "To use the Neos Mod Manager,\r\nplease set where your game is installed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSettingsPage
            // 
            this.buttonSettingsPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSettingsPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSettingsPage.Location = new System.Drawing.Point(154, 129);
            this.buttonSettingsPage.Name = "buttonSettingsPage";
            this.buttonSettingsPage.Size = new System.Drawing.Size(157, 43);
            this.buttonSettingsPage.TabIndex = 1;
            this.buttonSettingsPage.Text = "Settings >";
            this.buttonSettingsPage.UseVisualStyleBackColor = true;
            this.buttonSettingsPage.Click += new System.EventHandler(this.buttonSettingsPage_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "No path set for NeosVR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpacer2
            // 
            this.labelSpacer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpacer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpacer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSpacer2.Location = new System.Drawing.Point(-1, 63);
            this.labelSpacer2.Name = "labelSpacer2";
            this.labelSpacer2.Size = new System.Drawing.Size(477, 1);
            this.labelSpacer2.TabIndex = 3;
            // 
            // buttonIgnoreNeosInstallMissing
            // 
            this.buttonIgnoreNeosInstallMissing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonIgnoreNeosInstallMissing.Location = new System.Drawing.Point(154, 178);
            this.buttonIgnoreNeosInstallMissing.Name = "buttonIgnoreNeosInstallMissing";
            this.buttonIgnoreNeosInstallMissing.Size = new System.Drawing.Size(157, 24);
            this.buttonIgnoreNeosInstallMissing.TabIndex = 4;
            this.buttonIgnoreNeosInstallMissing.Text = "Ignore and set later";
            this.buttonIgnoreNeosInstallMissing.UseVisualStyleBackColor = true;
            this.buttonIgnoreNeosInstallMissing.Click += new System.EventHandler(this.buttonIgnoreNeosInstallMissing_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonIgnoreNeosInstallMissing);
            this.Controls.Add(this.labelSpacer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSettingsPage);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(475, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button buttonSettingsPage;
        private Label label2;
        private Label labelSpacer2;
        private Button buttonIgnoreNeosInstallMissing;
    }
}
