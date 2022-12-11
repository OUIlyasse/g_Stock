namespace sys_Stock.Generic
{
    partial class frmL
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
            this.btnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.btnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gbRecherche = new DevExpress.XtraEditors.GroupControl();
            this.txtRecherche = new DevExpress.XtraEditors.TextEdit();
            this.cmbxMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbRecherche)).BeginInit();
            this.gbRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecherche.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Appearance.Options.UseBackColor = true;
            this.btnAjouter.Appearance.Options.UseFont = true;
            this.btnAjouter.AppearanceDisabled.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnAjouter.AppearanceDisabled.Options.UseFont = true;
            this.btnAjouter.AppearanceHovered.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnAjouter.AppearanceHovered.Options.UseFont = true;
            this.btnAjouter.AppearancePressed.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnAjouter.AppearancePressed.Options.UseFont = true;
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.ImageOptions.Image = global::sys_Stock.Properties.Resources.Add_64;
            this.btnAjouter.Location = new System.Drawing.Point(751, 33);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(72, 70);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Tag = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupprimer.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Appearance.Options.UseBackColor = true;
            this.btnSupprimer.Appearance.Options.UseFont = true;
            this.btnSupprimer.AppearanceDisabled.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnSupprimer.AppearanceDisabled.Options.UseFont = true;
            this.btnSupprimer.AppearanceHovered.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnSupprimer.AppearanceHovered.Options.UseFont = true;
            this.btnSupprimer.AppearancePressed.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnSupprimer.AppearancePressed.Options.UseFont = true;
            this.btnSupprimer.AutoSize = true;
            this.btnSupprimer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.ImageOptions.Image = global::sys_Stock.Properties.Resources.Delete_64;
            this.btnSupprimer.Location = new System.Drawing.Point(858, 33);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(72, 70);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Tag = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // gbRecherche
            // 
            this.gbRecherche.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gbRecherche.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.gbRecherche.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.gbRecherche.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.Appearance.Options.UseBackColor = true;
            this.gbRecherche.Appearance.Options.UseBorderColor = true;
            this.gbRecherche.Appearance.Options.UseFont = true;
            this.gbRecherche.AppearanceCaption.BackColor = System.Drawing.SystemColors.Control;
            this.gbRecherche.AppearanceCaption.BackColor2 = System.Drawing.SystemColors.Control;
            this.gbRecherche.AppearanceCaption.BorderColor = System.Drawing.SystemColors.Control;
            this.gbRecherche.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.AppearanceCaption.Options.UseBackColor = true;
            this.gbRecherche.AppearanceCaption.Options.UseBorderColor = true;
            this.gbRecherche.AppearanceCaption.Options.UseFont = true;
            this.gbRecherche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRecherche.CaptionImageOptions.Image = global::sys_Stock.Properties.Resources.icons8_search_32px;
            this.gbRecherche.Controls.Add(this.cmbxMode);
            this.gbRecherche.Controls.Add(this.txtRecherche);
            this.gbRecherche.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.gbRecherche.Location = new System.Drawing.Point(12, 12);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(617, 103);
            this.gbRecherche.TabIndex = 6;
            this.gbRecherche.Text = "Recherche";
            // 
            // txtRecherche
            // 
            this.txtRecherche.EditValue = "";
            this.txtRecherche.Location = new System.Drawing.Point(19, 54);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRecherche.Properties.Appearance.Options.UseFont = true;
            this.txtRecherche.Properties.Appearance.Options.UseForeColor = true;
            this.txtRecherche.Size = new System.Drawing.Size(360, 28);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.EditValueChanged += new System.EventHandler(this.txtRecherche_EditValueChanged);
            // 
            // cmbxMode
            // 
            this.cmbxMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxMode.FormattingEnabled = true;
            this.cmbxMode.Location = new System.Drawing.Point(423, 54);
            this.cmbxMode.Name = "cmbxMode";
            this.cmbxMode.Size = new System.Drawing.Size(180, 29);
            this.cmbxMode.TabIndex = 8;
            // 
            // frmL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 543);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gbRecherche)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRecherche.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAjouter;
        private DevExpress.XtraEditors.SimpleButton btnSupprimer;
        private DevExpress.XtraEditors.GroupControl gbRecherche;
        private DevExpress.XtraEditors.TextEdit txtRecherche;
        private System.Windows.Forms.ComboBox cmbxMode;
    }
}