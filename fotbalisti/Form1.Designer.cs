namespace fotbalisti
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbDressNum = new System.Windows.Forms.TextBox();
            this.tbGoals = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(830, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fotbalisti Písek a Bukovec - Mladší žáci";
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbName.Location = new System.Drawing.Point(182, 242);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(285, 27);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "jméno fotbalisty";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbSurname
            // 
            this.tbSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSurname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSurname.ForeColor = System.Drawing.Color.DarkGray;
            this.tbSurname.Location = new System.Drawing.Point(182, 298);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(285, 27);
            this.tbSurname.TabIndex = 4;
            this.tbSurname.Text = "příjmení fotbalisty";
            this.tbSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDressNum
            // 
            this.tbDressNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDressNum.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDressNum.ForeColor = System.Drawing.Color.DarkGray;
            this.tbDressNum.Location = new System.Drawing.Point(182, 353);
            this.tbDressNum.Name = "tbDressNum";
            this.tbDressNum.Size = new System.Drawing.Size(285, 27);
            this.tbDressNum.TabIndex = 5;
            this.tbDressNum.Text = "číslo dresu";
            this.tbDressNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGoals
            // 
            this.tbGoals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGoals.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbGoals.ForeColor = System.Drawing.Color.DarkGray;
            this.tbGoals.Location = new System.Drawing.Point(182, 409);
            this.tbGoals.Name = "tbGoals";
            this.tbGoals.Size = new System.Drawing.Size(285, 27);
            this.tbGoals.TabIndex = 6;
            this.tbGoals.Text = "nastřílených gólů";
            this.tbGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "brankář",
            "stoper",
            "levá obrana",
            "pravá obrana",
            "střední záloha",
            "levá záloha",
            "pravá záloha",
            "útok"});
            this.cbPosition.Location = new System.Drawing.Point(182, 466);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(285, 27);
            this.cbPosition.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.tbGoals);
            this.Controls.Add(this.tbDressNum);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbDressNum;
        private System.Windows.Forms.TextBox tbGoals;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

