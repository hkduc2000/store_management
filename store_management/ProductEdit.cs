using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management {
    public partial class ProductEdit : Form {
        public ProductEdit() {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.Description = txtDescription.Text;
            product.CategoryID = ((CategoryTreeNode)Program.productListForm.TrvMenu.SelectedNode).CategoryID;
            try {
                product.CostPrice = int.Parse(txtCostPrice.Text);
                product.Price = int.Parse(txtPrice.Text);
                product.Quantity = int.Parse(txtQuantity.Text);
                ProductDAO.editProduct(product);
                Program.productListForm.loadProducts();
            } catch (FormatException) {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            } catch (Exception e1) {
                MessageBox.Show("Không thành công");
                MessageBox.Show(e1.Message);
                return;
            }
            MessageBox.Show("Thành công");
            this.Close();
        }

        private void ProductEdit_Load(object sender, EventArgs e) {
            var row = Program.productListForm.TblDisplay.SelectedRows[0].Cells;
            lblProductID.Text = row[0].Value.ToString();
            txtProductName.Text = row[1].Value.ToString();
            txtDescription.Text = row[2].Value.ToString();
            txtCostPrice.Text = row[3].Value.ToString();
            txtPrice.Text = row[4].Value.ToString();
            txtQuantity.Text = row[5].Value.ToString();
            lblCategory.Text = Program.productListForm.TrvMenu.SelectedNode.FullPath;
        }
    }
}
