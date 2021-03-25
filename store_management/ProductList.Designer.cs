using System.Windows.Forms;

namespace store_management {
    partial class ProductList {
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
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.tblDisplay = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAvailable = new System.Windows.Forms.RadioButton();
            this.chkOutOfStock = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvMenu
            // 
            this.trvMenu.HideSelection = false;
            this.trvMenu.Location = new System.Drawing.Point(18, 18);
            this.trvMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(338, 144);
            this.trvMenu.TabIndex = 0;
            this.trvMenu.TabStop = false;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect);
            // 
            // tblDisplay
            // 
            this.tblDisplay.AllowUserToAddRows = false;
            this.tblDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDisplay.Location = new System.Drawing.Point(13, 172);
            this.tblDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblDisplay.MultiSelect = false;
            this.tblDisplay.Name = "tblDisplay";
            this.tblDisplay.ReadOnly = true;
            this.tblDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDisplay.Size = new System.Drawing.Size(715, 214);
            this.tblDisplay.TabIndex = 1;
            this.tblDisplay.TabStop = false;
            this.tblDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(320, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(407, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(494, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(647, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(526, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 26);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm mặt hàng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOutOfStock);
            this.groupBox1.Controls.Add(this.chkAvailable);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Location = new System.Drawing.Point(382, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(36, 56);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(120, 24);
            this.chkAvailable.TabIndex = 9;
            this.chkAvailable.Text = "Chỉ còn hàng";
            this.chkAvailable.UseVisualStyleBackColor = true;
            this.chkAvailable.CheckedChanged += new System.EventHandler(this.chkAvailable_CheckedChanged);
            // 
            // chkOutOfStock
            // 
            this.chkOutOfStock.AutoSize = true;
            this.chkOutOfStock.Location = new System.Drawing.Point(36, 86);
            this.chkOutOfStock.Name = "chkOutOfStock";
            this.chkOutOfStock.Size = new System.Drawing.Size(117, 24);
            this.chkOutOfStock.TabIndex = 10;
            this.chkOutOfStock.Text = "Chỉ hết hàng";
            this.chkOutOfStock.UseVisualStyleBackColor = true;
            this.chkOutOfStock.CheckedChanged += new System.EventHandler(this.chkOutOfStock_CheckedChanged);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblDisplay);
            this.Controls.Add(this.trvMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí mặt hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.DataGridView tblDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private TextBox txtSearch;
        private Label label1;
        private RadioButton chkAll;
        private GroupBox groupBox1;
        private RadioButton chkOutOfStock;
        private RadioButton chkAvailable;

        public TreeView TrvMenu { get => trvMenu; set => trvMenu = value; }
        public DataGridView TblDisplay { get => tblDisplay; set => tblDisplay = value; }
    }
}

