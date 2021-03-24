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
            tblDisplay.DataSource = ProductDAO.getProductByCategory(selectedNode.CategoryID);
            string s = "";
            foreach (int i in CategoryDAO.getCategoryList(selectedNode.CategoryID)) {
                s += i.ToString() + " ";
            }
            msg.Text = s;
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
        }
    }
}
