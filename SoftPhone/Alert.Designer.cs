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
            this.lblAlert = new System.Windows.Forms.Label();
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
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(120, 55);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(149, 50);
            this.lblAlert.TabIndex = 2;
            this.lblAlert.Text = "ALERT";
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAlertMessage);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblonhold);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Alert";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblonhold;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.TextBox txtAlertMessage;
    }
}