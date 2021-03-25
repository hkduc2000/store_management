namespace store_management {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnInvoice1 = new System.Windows.Forms.Button();
            this.btnInvoice2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(301, 259);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(144, 33);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Quản lí sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(301, 298);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(144, 35);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Quản lí loại hàng";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(306, 152);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(144, 33);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Quản lí kho hàng";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnInvoice1
            // 
            this.btnInvoice1.Location = new System.Drawing.Point(213, 191);
            this.btnInvoice1.Name = "btnInvoice1";
            this.btnInvoice1.Size = new System.Drawing.Size(142, 33);
            this.btnInvoice1.TabIndex = 2;
            this.btnInvoice1.Text = "Hóa đơn nhập";
            this.btnInvoice1.UseVisualStyleBackColor = true;
            this.btnInvoice1.Click += new System.EventHandler(this.btnInvoice1_Click);
            // 
            // btnInvoice2
            // 
            this.btnInvoice2.Location = new System.Drawing.Point(393, 191);
            this.btnInvoice2.Name = "btnInvoice2";
            this.btnInvoice2.Size = new System.Drawing.Size(142, 33);
            this.btnInvoice2.TabIndex = 3;
            this.btnInvoice2.Text = "Hóa đơn xuất";
            this.btnInvoice2.UseVisualStyleBackColor = true;
            this.btnInvoice2.Click += new System.EventHandler(this.btnInvoice2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 443);
            this.Controls.Add(this.btnInvoice2);
            this.Controls.Add(this.btnInvoice1);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí kho hàng";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnInvoice1;
        private System.Windows.Forms.Button btnInvoice2;
    }
}