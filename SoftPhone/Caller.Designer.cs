namespace SoftPhone
{
    partial class Caller
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
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this._totalElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Location = new System.Drawing.Point(96, 115);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(75, 23);
            this.btnMakeCall.TabIndex = 0;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(55, 78);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(180, 20);
            this.txtCustomerNo.TabIndex = 1;
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(52, 53);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(125, 13);
            this.lblCustomerNo.TabIndex = 2;
            this.lblCustomerNo.Text = "Customer Phone Number";
            // 
            // _totalElapsedTimeDisplay
            // 
            this._totalElapsedTimeDisplay.AutoSize = true;
            this._totalElapsedTimeDisplay.Location = new System.Drawing.Point(80, 147);
            this._totalElapsedTimeDisplay.Name = "_totalElapsedTimeDisplay";
            this._totalElapsedTimeDisplay.Size = new System.Drawing.Size(55, 13);
            this._totalElapsedTimeDisplay.TabIndex = 3;
            this._totalElapsedTimeDisplay.Text = "00:00:000";
            this._totalElapsedTimeDisplay.Visible = false;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Location = new System.Drawing.Point(12, 147);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(70, 13);
            this.lblCallDuration.TabIndex = 4;
            this.lblCallDuration.Text = "Call Duration:";
            this.lblCallDuration.Visible = false;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(96, 115);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(75, 23);
            this.btnEndCall.TabIndex = 5;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Visible = false;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // Caller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 169);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblCallDuration);
            this.Controls.Add(this._totalElapsedTimeDisplay);
            this.Controls.Add(this.lblCustomerNo);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.btnMakeCall);
            this.Name = "Caller";
            this.Text = "Customer Phone";
            this.Load += new System.EventHandler(this.Caller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label _totalElapsedTimeDisplay;
        private System.Windows.Forms.Label lblCallDuration;
        private System.Windows.Forms.Button btnEndCall;
    }
}