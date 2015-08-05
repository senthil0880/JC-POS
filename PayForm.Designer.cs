namespace NewPOS
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.buttonRoundUp = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(30, 32);
            this.lblAmountToPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(84, 17);
            this.lblAmountToPay.TabIndex = 0;
            this.lblAmountToPay.Text = "Total To Pay";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(176, 29);
            this.txtAmountToPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(132, 23);
            this.txtAmountToPay.TabIndex = 1;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(176, 75);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(132, 23);
            this.txtPaymentAmount.TabIndex = 3;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(12, 78);
            this.lblPaymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(102, 17);
            this.lblPaymentAmount.TabIndex = 2;
            this.lblPaymentAmount.Text = "Given Amount";
            // 
            // buttonRoundUp
            // 
            this.buttonRoundUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRoundUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRoundUp.BackgroundImage")));
            this.buttonRoundUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoundUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRoundUp.Location = new System.Drawing.Point(15, 137);
            this.buttonRoundUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRoundUp.Name = "buttonRoundUp";
            this.buttonRoundUp.Size = new System.Drawing.Size(118, 143);
            this.buttonRoundUp.TabIndex = 4;
            this.buttonRoundUp.Text = "OK";
            this.buttonRoundUp.UseVisualStyleBackColor = false;
            this.buttonRoundUp.Click += new System.EventHandler(this.buttonRoundUp_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(220, 137);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(119, 143);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Pay Actual";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonRoundUp);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblAmountToPay);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PayForm";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Button buttonRoundUp;
        private System.Windows.Forms.Button buttonOK;
    }
}