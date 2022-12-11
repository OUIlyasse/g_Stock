namespace sys_Stock.Generic
{
    partial class frmG
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
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControl.Controls.Add(this.btnSupprimer);
            this.gbControl.Controls.Add(this.btnModifier);
            this.gbControl.Controls.Add(this.btnAjouter);
            this.gbControl.Location = new System.Drawing.Point(835, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(95, 519);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            // 
            // btnSupprimer
            // 
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
            this.btnSupprimer.Location = new System.Drawing.Point(11, 376);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(72, 70);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Tag = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnModifier.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Appearance.Options.UseBackColor = true;
            this.btnModifier.Appearance.Options.UseFont = true;
            this.btnModifier.AppearanceDisabled.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnModifier.AppearanceDisabled.Options.UseFont = true;
            this.btnModifier.AppearanceHovered.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnModifier.AppearanceHovered.Options.UseFont = true;
            this.btnModifier.AppearancePressed.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnModifier.AppearancePressed.Options.UseFont = true;
            this.btnModifier.AutoSize = true;
            this.btnModifier.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.ImageOptions.Image = global::sys_Stock.Properties.Resources.Edit_64;
            this.btnModifier.Location = new System.Drawing.Point(11, 224);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(72, 70);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Tag = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
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
            this.btnAjouter.Location = new System.Drawing.Point(11, 72);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(72, 70);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Tag = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 543);
            this.Controls.Add(this.gbControl);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControl;
        private DevExpress.XtraEditors.SimpleButton btnAjouter;
        private DevExpress.XtraEditors.SimpleButton btnSupprimer;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
    }
}