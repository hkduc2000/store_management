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
    public partial class CategoryManage : Form {
        public CategoryManage() {
            InitializeComponent();
        }
        private void loadMenu() {
            trvMenu.Nodes.Clear();
            trvMenu.Nodes.AddRange(DAL.getCategoryByItsFather());
        }
        private void CategoryManage_Load(object sender, EventArgs e) {
            loadMenu();            
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CategoryTreeNode s = (CategoryTreeNode)trvMenu.SelectedNode;
            if (chkAddRoot.Checked) {
                CategoryDAO.addRootCategory(txtNewCategory.Text);
            }
            CategoryDAO.addCategory(txtNewCategory.Text,s.CategoryID);
            MessageBox.Show("Thêm thành công");
            loadMenu();
        }

        private void chkAddRoot_CheckedChanged(object sender, EventArgs e) {
            if (chkAddRoot.Checked) {
                trvMenu.Enabled = false;
            } else {
                trvMenu.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            txtNewName.Text = trvMenu.SelectedNode.Text;
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!txtNewName.Enabled) {
                txtNewName.Enabled = true;
                grpAdd.Enabled = false;
                btnDelete.Enabled = false;
            } else {
                CategoryTreeNode s = (CategoryTreeNode)trvMenu.SelectedNode;
                DAL.ExecuteNonQuery($"UPDATE Category " +
                    $"SET CategoryName=N'{txtNewName.Text}' " +
                    $"WHERE CategoryID={s.CategoryID}");
                txtNewName.Text = "";
                txtNewName.Enabled = false;
                grpAdd.Enabled = true;
                btnDelete.Enabled = true;
                loadMenu();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            CategoryTreeNode s = (CategoryTreeNode)trvMenu.SelectedNode;
            DAL.ExecuteNonQuery($"DELETE FROM Category " +
                $"WHERE CategoryID={s.CategoryID}");
            loadMenu();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
