using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management {

    class InvoiceDAO {

        public static DataTable getInvoices(DateTime from, DateTime to,string listType) {
            string sql = $"Select InvoiceID, CreatedDate, BusinessPartner from Invoice where (CreatedDate between " +
                $"'{from.ToString("yyyy-MM-dd")}' and '{to.ToString("yyyy-MM-dd")}')" +
                $" and InvoiceType IN {listType}";
            return DAL.ExecuteQuery(sql);
        }

        public static string test(DateTime from, DateTime to, string listType) {
            return  $"Select * from Invoice where CreatedDate between " +
               $"'{from.ToString("yyyy-MM-dd")}' and '{to.ToString("yyyy-MM-dd")}'" +
               $" and InvoiceType IN {listType}";
        }

        public static int getInvoiceCurIdentity() {
            String sql = "select IDENT_CURRENT('Invoice')";
            return DAL.ExecuteScalar(sql);
        }

        public static int addInvoice(Invoice invoice) {
            int cur = getInvoiceCurIdentity();
            string sql = "BEGIN TRAN\n" +
                $"insert into Invoice values ('{invoice.CreatedDate.ToString("yyyy-MM-dd")}', '{invoice.BusinessPartner}', {invoice.InvoiceType})\n";
            foreach(Product p in invoice.Inf) {
                sql += $"insert into ProductInInvoice values({cur+1}, {p.ProductID}, {p.Quantity}, {p.Price})\n";
                sql += $"update Product set Quantity=Quantity+{p.Quantity * invoice.InvoiceType} where ProductID={p.ProductID}\n";
            }
            sql += "Commit";
            return DAL.ExecuteNonQuery(sql);
        }
    }


    class ProductDAO {
        public static Product getProductByProductID(int ProductID) {
            Product product = new Product();
            String sql = $"select * from Product" +
                $" where ProductID={ProductID}";
            SqlCommand cmd = new SqlCommand(sql, DAL.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                product.ProductID = ProductID;
                product.ProductName = dr.GetString(1);
                product.Description = dr.GetString(2);
                product.CostPrice = dr.GetInt32(3);
                product.Price = dr.GetInt32(4);
                product.Quantity = dr.GetInt32(5);
                product.CategoryID = dr.GetInt32(6);
                return product;
            }
            return null;
        }

        public static Product getProductByName(string name) {
            string sql = $"select top 1 * from Product where ProductName like '%{name}%'";
            SqlCommand cmd = new SqlCommand(sql, DAL.con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) {
                Product product = new Product();
                product.ProductID = dr.GetInt32(0);
                product.ProductName = dr.GetString(1);
                product.Description = dr.GetString(2);
                product.CostPrice = dr.GetInt32(3);
                product.Price = dr.GetInt32(4);
                product.Quantity = dr.GetInt32(5);
                product.CategoryID = dr.GetInt32(6);
                return product;
            }
            return null;
        }

        public static DataTable getProductByCategory(int categoryid, string quantityCondition, string search) {
            DataTable dt = new DataTable();
            List<int> categories = CategoryDAO.getCategoryList(categoryid);
            categories.Add(categoryid);
            foreach (int id in categories) {
                dt.Merge(DAL.ExecuteQuery($"select * from Product" +
                $" where CategoryID={id} and Quantity{quantityCondition} and (ProductName like N'%{search}%' or ProductID like N'%{search}%')"));
            }
            return dt;
        }

        public static int addProduct(Product product) {
            String sql = $"insert into Product values(N'{product.ProductName}'," +
                $"N'{product.Description}', {product.CostPrice} , {product.Price}," +
                $"{product.Quantity}, {product.CategoryID})";
            return DAL.ExecuteNonQuery(sql);
        }

        public static int editProduct(Product product) {
            String sql = $"update Product set ProductName=N'{product.ProductName}'," +
                $"Description=N'{product.Description}', CostPrice={product.CostPrice} , Price={product.Price}," +
                $"Quantity={product.Quantity} where ProductID={product.ProductID}";
            return DAL.ExecuteNonQuery(sql);
        }

        public static int deleteProduct(int productid) {
            string sql = "BEGIN TRAN\n" +
                $"delete from ProductInInvoice where ProductID={productid}\n" + 
                $"delete from Product where ProductID={productid}\n" +
            "Commit";
            return DAL.ExecuteNonQuery(sql);
        }
    }

    class CategoryDAO {

        public static List<int> getCategoryList(int fatherid) {
            List<int> categories = new List<int>();
            DataTable dt = DAL.ExecuteQuery($"select CategoryID from Category where FatherID={fatherid}");
            foreach (DataRow row in dt.Rows) {
                int id = row.Field<int>("CategoryID");
                categories.Add(id);
                categories.AddRange(getCategoryList(id));
            }
            return categories;
        }

        public static int addCategory(string newcategory, int fatherid) {
            return DAL.ExecuteNonQuery($"Insert into Category" +
                $" values (N'{newcategory}', {fatherid})");
        }

        public static int addRootCategory(string newcategory) {
            return DAL.ExecuteNonQuery($"Insert into Category" +
                $" values (N'{newcategory}', null)");
        }

    }
    class DAL {
        public static string constr = "Data Source=localhost;Initial Catalog=storedb;Persist Security Info=True;User ID=sa;Password=20001998;MultipleActiveResultSets=True";
        public static SqlConnection con = null;

        public static CategoryTreeNode[] getCategoryByItsFather(int fatherid) {
            return getCategoryByItsFather("=" + fatherid.ToString());
        }

        public static CategoryTreeNode[] getCategoryByItsFather() {
            return getCategoryByItsFather("is Null");
        }

        public static CategoryTreeNode[] getCategoryByItsFather(String father) {
            SqlCommand sql = new SqlCommand($"select * from category where FatherID {father};", con);
            var rs = new List<CategoryTreeNode>();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read()) {
                rs.Add(new CategoryTreeNode(reader.GetString(1),
                    getCategoryByItsFather(reader.GetInt32(0)), reader.GetInt32(0)));
            }
            return rs.Cast<CategoryTreeNode>().ToArray();
        }

        public static DataTable ExecuteQuery(String sql) {
            var dataAdapter = new SqlDataAdapter(sql, con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int ExecuteNonQuery(String sql) {
            var cmd = new SqlCommand(sql, con);
            int rs = cmd.ExecuteNonQuery();
            return rs;
        }

        public static int ExecuteScalar(string sql) {
            var cmd = new SqlCommand(sql, con);
            var rs = Convert.ToInt32(cmd.ExecuteScalar());
            return rs;
        }

    }
}
