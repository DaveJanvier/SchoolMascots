namespace SchoolMascots
{
    partial class frmSchoolMascot
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.floridaStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alabamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auburnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascots = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(284, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floridaStateToolStripMenuItem,
            this.ohioToolStripMenuItem,
            this.alabamaToolStripMenuItem,
            this.auburnToolStripMenuItem});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // floridaStateToolStripMenuItem
            // 
            this.floridaStateToolStripMenuItem.Name = "floridaStateToolStripMenuItem";
            this.floridaStateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.floridaStateToolStripMenuItem.Text = "Florida State";
            // 
            // ohioToolStripMenuItem
            // 
            this.ohioToolStripMenuItem.Name = "ohioToolStripMenuItem";
            this.ohioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ohioToolStripMenuItem.Text = "Ohio State";
            // 
            // alabamaToolStripMenuItem
            // 
            this.alabamaToolStripMenuItem.Name = "alabamaToolStripMenuItem";
            this.alabamaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alabamaToolStripMenuItem.Text = "Alabama";
            // 
            // auburnToolStripMenuItem
            // 
            this.auburnToolStripMenuItem.Name = "auburnToolStripMenuItem";
            this.auburnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.auburnToolStripMenuItem.Text = "Auburn";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(86, 47);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(97, 31);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "School";
            // 
            // lblMascots
            // 
            this.lblMascots.AutoSize = true;
            this.lblMascots.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascots.Location = new System.Drawing.Point(86, 125);
            this.lblMascots.Name = "lblMascots";
            this.lblMascots.Size = new System.Drawing.Size(116, 31);
            this.lblMascots.TabIndex = 2;
            this.lblMascots.Text = "Mascots";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblMascots);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascots";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem floridaStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alabamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auburnToolStripMenuItem;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblMascots;
    }
}

