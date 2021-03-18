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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            con = new SqlConnection(constr);
            con.Open();
        }

        string constr = "Data Source=localhost;Initial Catalog=storedb;Persist Security Info=True;User ID=sa;Password=20001998;MultipleActiveResultSets=True";
        SqlConnection con = null;

        private CategoryTreeNode[] getCategoryByItsFather(int fatherid) {
            return getCategoryByItsFather("=" + fatherid.ToString());
        }

        private CategoryTreeNode[] getCategoryByItsFather() {
            return getCategoryByItsFather("is Null");
        }

        private CategoryTreeNode[] getCategoryByItsFather(String father) {
            
            SqlCommand sql = new SqlCommand($"select * from category where FatherID {father};", con);
            var rs = new List<CategoryTreeNode>();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read()) {
                rs.Add(new CategoryTreeNode(reader.GetString(1), 
                    getCategoryByItsFather(reader.GetInt32(0)), reader.GetInt32(0)));
            }
            return rs.Cast<CategoryTreeNode>().ToArray();
        }

        private void loadMenu() {
            trvMenu.Nodes.AddRange(getCategoryByItsFather());
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadMenu();
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            CategoryTreeNode s = (CategoryTreeNode) trvMenu.SelectedNode;
            MessageBox.Show(s.CategoryID.ToString());
        }
    }
}
