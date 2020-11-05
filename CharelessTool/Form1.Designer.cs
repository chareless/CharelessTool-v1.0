namespace CharelessTool
{
    partial class CharelessTool
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharelessTool));
            this.diaryButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.versionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contactToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.surumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaryButton
            // 
            this.diaryButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.diaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diaryButton.ForeColor = System.Drawing.Color.Aqua;
            this.diaryButton.Location = new System.Drawing.Point(46, 80);
            this.diaryButton.Name = "diaryButton";
            this.diaryButton.Size = new System.Drawing.Size(144, 54);
            this.diaryButton.TabIndex = 0;
            this.diaryButton.Text = "Digital Diary";
            this.diaryButton.UseVisualStyleBackColor = false;
            this.diaryButton.Click += new System.EventHandler(this.diaryButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.ForeColor = System.Drawing.Color.Aqua;
            this.randomButton.Location = new System.Drawing.Point(226, 80);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(144, 54);
            this.randomButton.TabIndex = 1;
            this.randomButton.Text = "Random Tools";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripButton,
            this.updateToolStripButton,
            this.versionToolStripButton,
            this.contactToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(414, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.aboutToolStripButton.Text = "Hakkımda";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // updateToolStripButton
            // 
            this.updateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripButton.Image")));
            this.updateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateToolStripButton.Name = "updateToolStripButton";
            this.updateToolStripButton.Size = new System.Drawing.Size(133, 22);
            this.updateToolStripButton.Text = "Güncellemeleri Denetle";
            this.updateToolStripButton.Click += new System.EventHandler(this.updateToolStripButton_Click);
            // 
            // versionToolStripButton
            // 
            this.versionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("versionToolStripButton.Image")));
            this.versionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.versionToolStripButton.Name = "versionToolStripButton";
            this.versionToolStripButton.Size = new System.Drawing.Size(85, 22);
            this.versionToolStripButton.Text = "Sürüm Notları";
            this.versionToolStripButton.Click += new System.EventHandler(this.versionToolStripButton_Click);
            // 
            // contactToolStripButton
            // 
            this.contactToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contactToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("contactToolStripButton.Image")));
            this.contactToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contactToolStripButton.Name = "contactToolStripButton";
            this.contactToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.contactToolStripButton.Text = "Sorun Bildir";
            this.contactToolStripButton.Click += new System.EventHandler(this.contactToolStripButton_Click);
            // 
            // surumLabel
            // 
            this.surumLabel.AutoSize = true;
            this.surumLabel.Location = new System.Drawing.Point(367, 184);
            this.surumLabel.Name = "surumLabel";
            this.surumLabel.Size = new System.Drawing.Size(35, 13);
            this.surumLabel.TabIndex = 3;
            this.surumLabel.Text = "sürüm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "İnternet Bağlantısı : ";
            // 
            // netLabel
            // 
            this.netLabel.AutoSize = true;
            this.netLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.netLabel.Location = new System.Drawing.Point(130, 184);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(45, 16);
            this.netLabel.TabIndex = 5;
            this.netLabel.Text = "durum";
            // 
            // CharelessTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(414, 216);
            this.Controls.Add(this.netLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surumLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.diaryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharelessTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chareless Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button diaryButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripButton updateToolStripButton;
        private System.Windows.Forms.ToolStripButton versionToolStripButton;
        private System.Windows.Forms.ToolStripButton contactToolStripButton;
        private System.Windows.Forms.Label surumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label netLabel;
    }
}

