namespace SoftPhone
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblonhold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlertMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblonhold
            // 
            this.lblonhold.AutoSize = true;
            this.lblonhold.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonhold.Location = new System.Drawing.Point(90, 23);
            this.lblonhold.Name = "lblonhold";
            this.lblonhold.Size = new System.Drawing.Size(199, 38);
            this.lblonhold.TabIndex = 1;
            this.lblonhold.Text = "Call On Hold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALERT";
            // 
            // txtAlertMessage
            // 
            this.txtAlertMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlertMessage.Location = new System.Drawing.Point(11, 123);
            this.txtAlertMessage.Multiline = true;
            this.txtAlertMessage.Name = "txtAlertMessage";
            this.txtAlertMessage.ReadOnly = true;
            this.txtAlertMessage.Size = new System.Drawing.Size(268, 128);
            this.txtAlertMessage.TabIndex = 3;
            this.txtAlertMessage.Text = "Call on hold duration exceeded 40 seconds. Please swap the call to customer and e" +
    "xtend the call hold !";
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAlertMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblonhold);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Alert";
            this.Text = "Alert";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblonhold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlertMessage;
    }
}