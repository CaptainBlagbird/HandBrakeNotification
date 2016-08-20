namespace HandBrakeNotification
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_Title_text = new System.Windows.Forms.Label();
            this.lbl_file_text = new System.Windows.Forms.Label();
            this.btn_folder = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.ctx_rightclick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itm_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_rightclick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title_text
            // 
            this.lbl_Title_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title_text.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title_text.Name = "lbl_Title_text";
            this.lbl_Title_text.Size = new System.Drawing.Size(410, 13);
            this.lbl_Title_text.TabIndex = 0;
            this.lbl_Title_text.Text = "Finished encoding:";
            this.lbl_Title_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_file_text
            // 
            this.lbl_file_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_file_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file_text.Location = new System.Drawing.Point(12, 22);
            this.lbl_file_text.Name = "lbl_file_text";
            this.lbl_file_text.Size = new System.Drawing.Size(410, 30);
            this.lbl_file_text.TabIndex = 1;
            this.lbl_file_text.Text = "file";
            this.lbl_file_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_folder
            // 
            this.btn_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_folder.Location = new System.Drawing.Point(347, 55);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_folder.TabIndex = 2;
            this.btn_folder.Text = "Open folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_file
            // 
            this.btn_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_file.Location = new System.Drawing.Point(12, 55);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "Open file";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // ctx_rightclick
            // 
            this.ctx_rightclick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itm_about});
            this.ctx_rightclick.Name = "ctx_rightclick";
            this.ctx_rightclick.Size = new System.Drawing.Size(153, 48);
            // 
            // itm_about
            // 
            this.itm_about.Name = "itm_about";
            this.itm_about.Size = new System.Drawing.Size(152, 22);
            this.itm_about.Text = "About";
            this.itm_about.Click += new System.EventHandler(this.itm_about_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 89);
            this.ContextMenuStrip = this.ctx_rightclick;
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.lbl_file_text);
            this.Controls.Add(this.lbl_Title_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 128);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 128);
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HandBrake Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ctx_rightclick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title_text;
        private System.Windows.Forms.Label lbl_file_text;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.ToolStripMenuItem itm_about;
        private System.Windows.Forms.ContextMenuStrip ctx_rightclick;
    }
}

