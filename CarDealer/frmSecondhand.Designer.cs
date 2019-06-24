namespace CarDealer
{
    partial class frmSecondhand
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
            this.txtRego = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(143, 328);
            this.txtRego.Margin = new System.Windows.Forms.Padding(4);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(212, 22);
            this.txtRego.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(40, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 64;
            this.label7.Text = "Rego";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(143, 294);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(212, 22);
            this.txtMileage.TabIndex = 50;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(41, 297);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 49;
            this.Label1.Text = "Mileage";
            // 
            // frmSecondhand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 466);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.Label1);
            this.Name = "frmSecondhand";
            this.Text = "frmSecondhand";
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.txtMileage, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtRego, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtRego;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtMileage;
        internal System.Windows.Forms.Label Label1;
    }
}