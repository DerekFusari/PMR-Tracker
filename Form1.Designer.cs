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
            this.picEldstar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEldstar)).BeginInit();
            this.SuspendLayout();
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
            // frmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.picEldstar);
            this.Name = "frmTracker";
            this.Text = "PMR Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.picEldstar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEldstar;
    }
}

