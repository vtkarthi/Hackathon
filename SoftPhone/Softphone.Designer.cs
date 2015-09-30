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
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.lbtnMinimize = new System.Windows.Forms.LinkLabel();
            this.lbtnClose = new System.Windows.Forms.LinkLabel();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbIncomingCall = new System.Windows.Forms.PictureBox();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.btnHangOff = new System.Windows.Forms.Button();
            this._totalElapsedTimeDisplay = new System.Windows.Forms.Label();
            this._currentElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.lblOnCallDuration = new System.Windows.Forms.Label();
            this.lblonHoldDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomingCall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoldCall
            // 
            this.btnHoldCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoldCall.BackgroundImage")));
            this.btnHoldCall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoldCall.FlatAppearance.BorderSize = 0;
            this.btnHoldCall.Location = new System.Drawing.Point(414, 84);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Size = new System.Drawing.Size(41, 30);
            this.btnHoldCall.TabIndex = 0;
            this.btnHoldCall.UseVisualStyleBackColor = true;
            this.btnHoldCall.Visible = false;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
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
            this.lblCustomerNo.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerNo.Location = new System.Drawing.Point(80, 91);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNo.TabIndex = 3;
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
            // pbIncomingCall
            // 
            this.pbIncomingCall.Image = ((System.Drawing.Image)(resources.GetObject("pbIncomingCall.Image")));
            this.pbIncomingCall.Location = new System.Drawing.Point(47, 83);
            this.pbIncomingCall.Name = "pbIncomingCall";
            this.pbIncomingCall.Size = new System.Drawing.Size(25, 31);
            this.pbIncomingCall.TabIndex = 5;
            this.pbIncomingCall.TabStop = false;
            this.pbIncomingCall.Visible = false;
            // 
            // btnEndCall
            // 
            this.btnEndCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndCall.BackgroundImage")));
            this.btnEndCall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndCall.FlatAppearance.BorderSize = 0;
            this.btnEndCall.Location = new System.Drawing.Point(462, 84);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(41, 29);
            this.btnEndCall.TabIndex = 6;
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Visible = false;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // btnHangOff
            // 
            this.btnHangOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHangOff.BackgroundImage")));
            this.btnHangOff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHangOff.FlatAppearance.BorderSize = 0;
            this.btnHangOff.Location = new System.Drawing.Point(378, 84);
            this.btnHangOff.Name = "btnHangOff";
            this.btnHangOff.Size = new System.Drawing.Size(29, 30);
            this.btnHangOff.TabIndex = 7;
            this.btnHangOff.UseVisualStyleBackColor = true;
            this.btnHangOff.Visible = false;
            this.btnHangOff.Click += new System.EventHandler(this.btnHangOff_Click);
            // 
            // _totalElapsedTimeDisplay
            // 
            this._totalElapsedTimeDisplay.AutoSize = true;
            this._totalElapsedTimeDisplay.Location = new System.Drawing.Point(151, 60);
            this._totalElapsedTimeDisplay.Name = "_totalElapsedTimeDisplay";
            this._totalElapsedTimeDisplay.Size = new System.Drawing.Size(49, 13);
            this._totalElapsedTimeDisplay.TabIndex = 8;
            this._totalElapsedTimeDisplay.Text = "00:00:00";
            this._totalElapsedTimeDisplay.Visible = false;
            // 
            // _currentElapsedTimeDisplay
            // 
            this._currentElapsedTimeDisplay.AutoSize = true;
            this._currentElapsedTimeDisplay.Location = new System.Drawing.Point(410, 60);
            this._currentElapsedTimeDisplay.Name = "_currentElapsedTimeDisplay";
            this._currentElapsedTimeDisplay.Size = new System.Drawing.Size(49, 13);
            this._currentElapsedTimeDisplay.TabIndex = 9;
            this._currentElapsedTimeDisplay.Text = "00:00:00";
            this._currentElapsedTimeDisplay.Visible = false;
            // 
            // lblOnCallDuration
            // 
            this.lblOnCallDuration.AutoSize = true;
            this.lblOnCallDuration.Location = new System.Drawing.Point(64, 60);
            this.lblOnCallDuration.Name = "lblOnCallDuration";
            this.lblOnCallDuration.Size = new System.Drawing.Size(90, 13);
            this.lblOnCallDuration.TabIndex = 10;
            this.lblOnCallDuration.Text = "On Call Duration :";
            this.lblOnCallDuration.Visible = false;
            // 
            // lblonHoldDuration
            // 
            this.lblonHoldDuration.AutoSize = true;
            this.lblonHoldDuration.Location = new System.Drawing.Point(319, 60);
            this.lblonHoldDuration.Name = "lblonHoldDuration";
            this.lblonHoldDuration.Size = new System.Drawing.Size(95, 13);
            this.lblonHoldDuration.TabIndex = 11;
            this.lblonHoldDuration.Text = "On Hold Duration :";
            this.lblonHoldDuration.Visible = false;
            // 
            // Softphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 179);
            this.Controls.Add(this.lblonHoldDuration);
            this.Controls.Add(this.lblOnCallDuration);
            this.Controls.Add(this._currentElapsedTimeDisplay);
            this.Controls.Add(this._totalElapsedTimeDisplay);
            this.Controls.Add(this.btnHangOff);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.pbIncomingCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerNo);
            this.Controls.Add(this.lbtnClose);
            this.Controls.Add(this.lbtnMinimize);
            this.Controls.Add(this.btnHoldCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Softphone";
            this.Text = "Verizon Softphone";
            this.Load += new System.EventHandler(this.Softphone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomingCall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.LinkLabel lbtnMinimize;
        private System.Windows.Forms.LinkLabel lbtnClose;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbIncomingCall;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Button btnHangOff;
        private System.Windows.Forms.Label _totalElapsedTimeDisplay;
        private System.Windows.Forms.Label _currentElapsedTimeDisplay;
        private System.Windows.Forms.Label lblOnCallDuration;
        private System.Windows.Forms.Label lblonHoldDuration;
    }
}

