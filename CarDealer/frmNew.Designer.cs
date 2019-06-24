namespace CarDealer
{
    partial class frmNew
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
            this.txtFinnance = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFinnance
            // 
            this.txtFinnance.Location = new System.Drawing.Point(143, 298);
            this.txtFinnance.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinnance.Name = "txtFinnance";
            this.txtFinnance.Size = new System.Drawing.Size(212, 22);
            this.txtFinnance.TabIndex = 81;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(143, 339);
            this.txtWarranty.Margin = new System.Windows.Forms.Padding(4);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(212, 22);
            this.txtWarranty.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Finnance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Warranty";
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinnance);
            this.Controls.Add(this.txtWarranty);
            this.Name = "frmNew";
            this.Text = "frmNew";
            this.Controls.SetChildIndex(this.txtWarranty, 0);
            this.Controls.SetChildIndex(this.txtFinnance, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtFinnance;
        internal System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}