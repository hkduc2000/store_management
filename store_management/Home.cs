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
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Program.productListForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e) {
            Program.categoryManageForm.Show();
        }

        private void Home_Load(object sender, EventArgs e) {
            
        }

        private void btnStock_Click(object sender, EventArgs e) {
            new InvoiceList().Show();
        }

        private void btnInvoice1_Click(object sender, EventArgs e) {
            new AddInvoice1().Show();
        }

        private void btnInvoice2_Click(object sender, EventArgs e) {
            new AddInvoice2().Show();
        }
    }
}
