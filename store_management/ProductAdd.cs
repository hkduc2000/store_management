﻿using System;
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
            lblCategory.Text = Program.productListForm.TrvMenu.SelectedNode.FullPath;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void clearInput() {
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
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
                ProductDAO.addProduct(product);
                Program.productListForm.loadProducts();
            } catch (FormatException) {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            } catch (Exception) {
                MessageBox.Show("Không thành công");
                return;
            }
            MessageBox.Show("Thành công");
            clearInput();
        }
    }
}
