namespace CharelessTool
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.indirButton = new System.Windows.Forms.Button();
            this.durumLabel = new System.Windows.Forms.Label();
            this.mevcutLabel = new System.Windows.Forms.Label();
            this.guncelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.developerLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indirButton
            // 
            this.indirButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.indirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.indirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indirButton.ForeColor = System.Drawing.Color.Aqua;
            this.indirButton.Location = new System.Drawing.Point(325, 161);
            this.indirButton.Margin = new System.Windows.Forms.Padding(2);
            this.indirButton.Name = "indirButton";
            this.indirButton.Size = new System.Drawing.Size(112, 40);
            this.indirButton.TabIndex = 20;
            this.indirButton.Text = "İndir";
            this.indirButton.UseVisualStyleBackColor = false;
            this.indirButton.Click += new System.EventHandler(this.indirButton_Click);
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLabel.Location = new System.Drawing.Point(35, 167);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(137, 24);
            this.durumLabel.TabIndex = 19;
            this.durumLabel.Text = "Sürüm durumu";
            // 
            // mevcutLabel
            // 
            this.mevcutLabel.AutoSize = true;
            this.mevcutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mevcutLabel.Location = new System.Drawing.Point(188, 46);
            this.mevcutLabel.Name = "mevcutLabel";
            this.mevcutLabel.Size = new System.Drawing.Size(71, 24);
            this.mevcutLabel.TabIndex = 18;
            this.mevcutLabel.Text = "Mevcut";
            // 
            // guncelLabel
            // 
            this.guncelLabel.AutoSize = true;
            this.guncelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelLabel.Location = new System.Drawing.Point(188, 98);
            this.guncelLabel.Name = "guncelLabel";
            this.guncelLabel.Size = new System.Drawing.Size(71, 24);
            this.guncelLabel.TabIndex = 17;
            this.guncelLabel.Text = "Güncel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Güncel Sürüm : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mevcut Sürüm : ";
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.developerLabel.Location = new System.Drawing.Point(28, 227);
            this.developerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(154, 17);
            this.developerLabel.TabIndex = 22;
            this.developerLabel.Text = "© 2020 Deniz Sarıbayır";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.licenseLabel.Location = new System.Drawing.Point(28, 253);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(134, 17);
            this.licenseLabel.TabIndex = 21;
            this.licenseLabel.Text = "Tüm hakları saklıdır.";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.indirButton);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.mevcutLabel);
            this.Controls.Add(this.guncelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellemeleri Denetle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indirButton;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.Label mevcutLabel;
        private System.Windows.Forms.Label guncelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label licenseLabel;
    }
}