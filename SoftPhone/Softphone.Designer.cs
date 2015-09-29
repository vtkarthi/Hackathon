namespace SoftPhone
{
    partial class Softphone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Softphone));
            this.btnHold = new System.Windows.Forms.Button();
            this.lbtnMinimize = new System.Windows.Forms.LinkLabel();
            this.lbtnClose = new System.Windows.Forms.LinkLabel();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHold
            // 
            this.btnHold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHold.BackgroundImage")));
            this.btnHold.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.Location = new System.Drawing.Point(414, 84);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(41, 30);
            this.btnHold.TabIndex = 0;
            this.btnHold.UseVisualStyleBackColor = true;
            // 
            // lbtnMinimize
            // 
            this.lbtnMinimize.AutoSize = true;
            this.lbtnMinimize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbtnMinimize.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnMinimize.ForeColor = System.Drawing.Color.Black;
            this.lbtnMinimize.Location = new System.Drawing.Point(531, 12);
            this.lbtnMinimize.Name = "lbtnMinimize";
            this.lbtnMinimize.Size = new System.Drawing.Size(19, 15);
            this.lbtnMinimize.TabIndex = 1;
            this.lbtnMinimize.TabStop = true;
            this.lbtnMinimize.Text = "__";
            this.lbtnMinimize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnMinimize_LinkClicked);
            // 
            // lbtnClose
            // 
            this.lbtnClose.AutoSize = true;
            this.lbtnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbtnClose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnClose.ForeColor = System.Drawing.Color.Black;
            this.lbtnClose.Location = new System.Drawing.Point(554, 12);
            this.lbtnClose.Name = "lbtnClose";
            this.lbtnClose.Size = new System.Drawing.Size(16, 15);
            this.lbtnClose.TabIndex = 2;
            this.lbtnClose.TabStop = true;
            this.lbtnClose.Text = "X";
            this.lbtnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnClose_LinkClicked);
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(80, 91);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(61, 13);
            this.lblCustomerNo.TabIndex = 3;
            this.lblCustomerNo.Text = "                  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logged in Agent: 3240553";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(462, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 29);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(378, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Softphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerNo);
            this.Controls.Add(this.lbtnClose);
            this.Controls.Add(this.lbtnMinimize);
            this.Controls.Add(this.btnHold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Softphone";
            this.Text = "Verizon Softphone";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.LinkLabel lbtnMinimize;
        private System.Windows.Forms.LinkLabel lbtnClose;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

