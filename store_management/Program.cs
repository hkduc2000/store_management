using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management {

    class CategoryTreeNode : TreeNode {
        int categoryID; 

        public CategoryTreeNode(string text, int categoryID) : base(text) {
            this.categoryID = categoryID;
        }

        public CategoryTreeNode(string text, CategoryTreeNode[] children, int categoryID) : base(text,children) {
            this.categoryID = categoryID;
        }

        public int CategoryID { get => categoryID; set => categoryID = value; }
    }

    class Product {
        int productID;
        string productName;
        string description;
        int costPrice;
        int price;
        int quantity;
        int categoryID;

        public Product() {
        }

        public Product(int productID, string productName, string description, int costPrice, int price, int quantity, int categoryID) {
            this.productID = productID;
            this.productName = productName;
            this.description = description;
            this.costPrice = costPrice;
            this.price = price;
            this.quantity = quantity;
            this.categoryID = categoryID;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Description { get => description; set => description = value; }
        public int CostPrice { get => costPrice; set => costPrice = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
    }

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static ProductList f;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAL.con = new SqlConnection(DAL.constr);
            DAL.con.Open();
            f = new ProductList();
            Application.Run(new Home());
            
        }
    }
}
