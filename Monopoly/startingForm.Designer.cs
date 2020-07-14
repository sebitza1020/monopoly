namespace Monopoly
{
    partial class startingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startingForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.pbTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(294, 525);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbTable
            // 
            this.pbTable.Image = ((System.Drawing.Image)(resources.GetObject("pbTable.Image")));
            this.pbTable.Location = new System.Drawing.Point(138, 114);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(396, 380);
            this.pbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTable.TabIndex = 1;
            this.pbTable.TabStop = false;
            // 
            // startingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 606);
            this.Controls.Add(this.pbTable);
            this.Controls.Add(this.btnStart);
            this.Name = "startingForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbTable;
    }
}

