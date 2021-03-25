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
    public partial class AddInvoice2 : Form {
        public AddInvoice2() {
            InitializeComponent();
            inf = new List<Product>();
        }

        private List<Product> inf;

        private void loadInf() {
            tblDisplay.DataSource = inf.Cast<Product>().ToArray();
        }

        private void clearInput() {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtCostPrice.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblQuantityInStock.Text = "";
        }

        private int calcPrice() {
            int sum = 0;
            foreach (Product p in inf) {
                sum += (p.Price * p.Quantity);
            }
            return sum;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e) {
            if (txtProductID.Text == "") return;
            try {
                Product p = ProductDAO.getProductByProductID(int.Parse(txtProductID.Text));
                if (p == null) return;
                txtProductName.Text = p.ProductName;
                txtCostPrice.Text = p.CostPrice.ToString();
                txtPrice.Text = p.Price.ToString();
                lblQuantityInStock.Text = p.Quantity.ToString();
            } catch (Exception) {
                MessageBox.Show("Dữ liệu không hợp lệ, chỉ được nhập kiểu số");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                Product p = ProductDAO.getProductByProductID(int.Parse(txtProductID.Text));
                p.Quantity = int.Parse(txtQuantity.Text);
                inf.Add(p);
                loadInf();
                lblTotalPrice.Text = calcPrice().ToString();
                clearInput();
            } catch (Exception) {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e) {
            Invoice invoice = new Invoice(txtBusinessPartner.Text, -1, inf);
            try {
                InvoiceDAO.addInvoice(invoice);
                MessageBox.Show("Thành công");
                this.Close();
            } catch (Exception) {
                MessageBox.Show("Không thành công");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
