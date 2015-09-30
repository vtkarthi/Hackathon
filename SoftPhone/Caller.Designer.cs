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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caller));
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this._totalElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Location = new System.Drawing.Point(49, 204);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(75, 23);
            this.btnMakeCall.TabIndex = 0;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(26, 37);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(124, 20);
            this.txtCustomerNo.TabIndex = 1;
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(25, 21);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(125, 13);
            this.lblCustomerNo.TabIndex = 2;
            this.lblCustomerNo.Text = "Customer Phone Number";
            // 
            // _totalElapsedTimeDisplay
            // 
            this._totalElapsedTimeDisplay.AutoSize = true;
            this._totalElapsedTimeDisplay.Location = new System.Drawing.Point(94, 170);
            this._totalElapsedTimeDisplay.Name = "_totalElapsedTimeDisplay";
            this._totalElapsedTimeDisplay.Size = new System.Drawing.Size(55, 13);
            this._totalElapsedTimeDisplay.TabIndex = 3;
            this._totalElapsedTimeDisplay.Text = "00:00:000";
            this._totalElapsedTimeDisplay.Visible = false;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Location = new System.Drawing.Point(26, 170);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(70, 13);
            this.lblCallDuration.TabIndex = 4;
            this.lblCallDuration.Text = "Call Duration:";
            this.lblCallDuration.Visible = false;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(49, 204);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(75, 23);
            this.btnEndCall.TabIndex = 5;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Visible = false;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Verizon Call Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Call Outgoing..";
            // 
            // Caller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(174, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}