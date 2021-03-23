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

        public int getCategoryID() {
            CategoryTreeNode selectedNode = (CategoryTreeNode)trvMenu.SelectedNode;
            return selectedNode.CategoryID;
        }

        private void loadMenu() {
            trvMenu.Nodes.Clear();
            trvMenu.Nodes.AddRange(DAL.getCategoryByItsFather());
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadMenu();
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            CategoryTreeNode selectedNode = (CategoryTreeNode) trvMenu.SelectedNode;
            tblDisplay.DataSource = ProductDAO.getProductByCategory(selectedNode.CategoryID);
            string s = "";
            foreach (int i in CategoryDAO.getCategoryList(selectedNode.CategoryID)) {
                s += i.ToString() + " ";
            }
            msg.Text = s;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            new ProductAdd().Show();
        }
    }
}
