using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management {
    public partial class ProductList : Form {
        public ProductList() {
            InitializeComponent();
            
        }

        private void loadMenu() {
            trvMenu.Nodes.Clear();
            trvMenu.Nodes.AddRange(DAL.getCategoryByItsFather());
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadMenu();
        }

        public void loadProducts() {
            CategoryTreeNode selectedNode = (CategoryTreeNode)trvMenu.SelectedNode;
            if (selectedNode == null) return;
            if (chkAll.Checked) {
                tblDisplay.DataSource = ProductDAO.getProductByCategory(selectedNode.CategoryID, ">=0", txtSearch.Text);
            } else if (chkAvailable.Checked) {
                tblDisplay.DataSource = ProductDAO.getProductByCategory(selectedNode.CategoryID, ">0", txtSearch.Text);
            } else {
                tblDisplay.DataSource = ProductDAO.getProductByCategory(selectedNode.CategoryID, "=0", txtSearch.Text);
            }
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            loadProducts();
            btnAdd.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            new ProductAdd().Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            new ProductEdit().Show();
        }

        private void tblDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Các thông tin liên quan đến sản phẩm sẽ đều bị xóa khỏi database", "Bạn có chắc muốn xóa sản phầm này", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes) {
                try {
                    ProductDAO.deleteProduct((int)tblDisplay.SelectedRows[0].Cells[0].Value);
                    MessageBox.Show("Thành công");
                } catch (Exception) {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e) {
            loadProducts();
        }

        private void chkAvailable_CheckedChanged(object sender, EventArgs e) {
            loadProducts();
        }

        private void chkOutOfStock_CheckedChanged(object sender, EventArgs e) {
            loadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            loadProducts();
        }
    }
}
