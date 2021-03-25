namespace store_management {
    partial class InvoiceList {
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
            this.tblDisplay = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNhap = new System.Windows.Forms.RadioButton();
            this.chkXuat = new System.Windows.Forms.RadioButton();
            this.chkAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDisplay
            // 
            this.tblDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDisplay.Location = new System.Drawing.Point(12, 167);
            this.tblDisplay.Name = "tblDisplay";
            this.tblDisplay.Size = new System.Drawing.Size(717, 264);
            this.tblDisplay.TabIndex = 0;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(80, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(259, 26);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(428, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(275, 26);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(47, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(27, 20);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNhap);
            this.groupBox1.Controls.Add(this.chkXuat);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Location = new System.Drawing.Point(51, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // chkNhap
            // 
            this.chkNhap.AutoSize = true;
            this.chkNhap.Location = new System.Drawing.Point(36, 86);
            this.chkNhap.Name = "chkNhap";
            this.chkNhap.Size = new System.Drawing.Size(152, 24);
            this.chkNhap.TabIndex = 10;
            this.chkNhap.Text = "Chỉ hóa đơn nhập";
            this.chkNhap.UseVisualStyleBackColor = true;
            this.chkNhap.CheckedChanged += new System.EventHandler(this.chkOutOfStock_CheckedChanged);
            // 
            // chkXuat
            // 
            this.chkXuat.AutoSize = true;
            this.chkXuat.Location = new System.Drawing.Point(36, 56);
            this.chkXuat.Name = "chkXuat";
            this.chkXuat.Size = new System.Drawing.Size(146, 24);
            this.chkXuat.TabIndex = 9;
            this.chkXuat.Text = "Chỉ hóa đơn xuất";
            this.chkXuat.UseVisualStyleBackColor = true;
            this.chkXuat.CheckedChanged += new System.EventHandler(this.chkAvailable_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.Location = new System.Drawing.Point(36, 26);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(71, 24);
            this.chkAll.TabIndex = 8;
            this.chkAll.TabStop = true;
            this.chkAll.Text = "Tất cả";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tblDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn xuất/nhập kho";
            this.Load += new System.EventHandler(this.InvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblDisplay;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkNhap;
        private System.Windows.Forms.RadioButton chkXuat;
        private System.Windows.Forms.RadioButton chkAll;
    }
}