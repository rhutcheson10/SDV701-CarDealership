namespace CarDealer
{
    partial class frmVehicleBrand
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstVehicleBrands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Brands";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(40, 241);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(186, 35);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View/Manage Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(97, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstVehicleBrands
            // 
            this.lstVehicleBrands.ItemHeight = 16;
            this.lstVehicleBrands.Location = new System.Drawing.Point(40, 72);
            this.lstVehicleBrands.Name = "lstVehicleBrands";
            this.lstVehicleBrands.Size = new System.Drawing.Size(213, 148);
            this.lstVehicleBrands.TabIndex = 4;
            this.lstVehicleBrands.DoubleClick += new System.EventHandler(this.lstVehicleBrands_DoubleClick);
            // 
            // frmVehicleBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 367);
            this.Controls.Add(this.lstVehicleBrands);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.label1);
            this.Name = "frmVehicleBrand";
            this.Text = "Car Dealer";
            this.Load += new System.EventHandler(this.frmVehicleBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstVehicleBrands;
    }
}

