using System;
using System.Collections.Generic;
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
        int quantityID;

        public Product() {
        }

        public Product(int productID, string productName, string description, int costPrice, int price, int quantity, int quantityID) {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Description = description;
            this.CostPrice = costPrice;
            this.Price = price;
            this.Quantity = quantity;
            this.QuantityID = quantityID;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Description { get => description; set => description = value; }
        public int CostPrice { get => costPrice; set => costPrice = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int QuantityID { get => quantityID; set => quantityID = value; }
    }

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
