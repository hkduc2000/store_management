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
    public partial class ProductAdd : Form {
        public ProductAdd() {
            InitializeComponent();
        }

        

        private void ProductAdd_Load(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.Description = txtDescription.Text;
            MessageBox.Show(Program.f.getCategoryID().ToString());
            try {
                product.CostPrice = int.Parse(txtCostPrice.Text);
                product.Price = int.Parse(txtPrice.Text);
                product.Quantity = int.Parse(txtQuantity.Text);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
