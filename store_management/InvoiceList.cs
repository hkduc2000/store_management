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
    public partial class InvoiceList : Form {
        public InvoiceList() {
            InitializeComponent();
        }

        private void loadInvoices() {
            tblDisplay.DataSource = null;
            if (chkXuat.Checked) {
                tblDisplay.DataSource = InvoiceDAO.getInvoices(dtpFrom.Value, dtpTo.Value, "(-1)");
            } else if (chkNhap.Checked) {
                tblDisplay.DataSource = InvoiceDAO.getInvoices(dtpFrom.Value, dtpTo.Value, "(1)");
            } else {
                tblDisplay.DataSource = InvoiceDAO.getInvoices(dtpFrom.Value, dtpTo.Value, "(-1,1)");
            }


        }

        private void InvoiceList_Load(object sender, EventArgs e) {
            loadInvoices();
           
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e) {
            loadInvoices();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e) {
            loadInvoices();
        }

        private void chkAvailable_CheckedChanged(object sender, EventArgs e) {
            loadInvoices();
        }

        private void chkOutOfStock_CheckedChanged(object sender, EventArgs e) {
            loadInvoices();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e) {
            loadInvoices();
        }
    }
}
