namespace PMR_Tracker
{
    partial class frmTracker
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
            this.picFortressKey = new System.Windows.Forms.PictureBox();
            this.picEldstar = new System.Windows.Forms.PictureBox();
            this.lblFortressKeyCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFortressKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEldstar)).BeginInit();
            this.SuspendLayout();
            // 
            // picFortressKey
            // 
            this.picFortressKey.Image = global::PMR_Tracker.Properties.Resources.FortressKeyGray;
            this.picFortressKey.Location = new System.Drawing.Point(37, 104);
            this.picFortressKey.Name = "picFortressKey";
            this.picFortressKey.Size = new System.Drawing.Size(45, 45);
            this.picFortressKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFortressKey.TabIndex = 1;
            this.picFortressKey.TabStop = false;
            this.picFortressKey.Click += new System.EventHandler(this.picFortressKey_Click);
            this.picFortressKey.DoubleClick += new System.EventHandler(this.picFortressKey_DoubleClick);
            // 
            // picEldstar
            // 
            this.picEldstar.Image = global::PMR_Tracker.Properties.Resources.EldstarGray;
            this.picEldstar.Location = new System.Drawing.Point(30, 30);
            this.picEldstar.Name = "picEldstar";
            this.picEldstar.Size = new System.Drawing.Size(60, 60);
            this.picEldstar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEldstar.TabIndex = 0;
            this.picEldstar.TabStop = false;
            this.picEldstar.Click += new System.EventHandler(this.picEldstar_Click);
            this.picEldstar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picEldstar_MouseDoubleClick);
            // 
            // lblFortressKeyCount
            // 
            this.lblFortressKeyCount.AutoSize = true;
            this.lblFortressKeyCount.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFortressKeyCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFortressKeyCount.Location = new System.Drawing.Point(44, 146);
            this.lblFortressKeyCount.Name = "lblFortressKeyCount";
            this.lblFortressKeyCount.Size = new System.Drawing.Size(32, 20);
            this.lblFortressKeyCount.TabIndex = 2;
            this.lblFortressKeyCount.Text = "0/4";
            // 
            // frmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(389, 454);
            this.Controls.Add(this.lblFortressKeyCount);
            this.Controls.Add(this.picFortressKey);
            this.Controls.Add(this.picEldstar);
            this.Name = "frmTracker";
            this.Text = "PMR Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.picFortressKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEldstar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEldstar;
        private System.Windows.Forms.PictureBox picFortressKey;
        private System.Windows.Forms.Label lblFortressKeyCount;
    }
}

