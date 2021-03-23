using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management {

    class ProductDAO {
        public static DataTable getProductByCategory(int categoryid) {
            DataTable dt = new DataTable();
            List<int> categories = CategoryDAO.getCategoryList(categoryid);
            categories.Add(categoryid);
            foreach (int id in categories) {
                dt.Merge(DAL.ExecuteQuery($"select * from Product" +
                $" where CategoryID={id}"));
            }
            return dt;
        }

        public static int addProduct(Product product) {
            String sql = $"insert into Product values('{product.ProductName}'," +
                $"'{product.Description}', {product.CostPrice} , {product.Price}," +
                $"{product.Quantity}, {product.CategoryID})";
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
    }
}
