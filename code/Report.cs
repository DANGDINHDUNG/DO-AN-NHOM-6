using Microsoft.Reporting.WinForms;
using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Report : Form
    {
        public string invoiceCodeReport;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource1.Name = "DataSet2";
            reportDataSource.Value = getInvoice1();
            reportDataSource1.Value = getInvoice2();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            this.reportViewer1.RefreshReport();
        }

        public DataTable getInvoice1()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Invoice where MAHD = '" + invoiceCodeReport + "'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public DataTable getInvoice2()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Information where MAHD = '" + invoiceCodeReport + "'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString()))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

    }
}
