using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using wfacrud.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace wfacrud
{
    public partial class Form1 : Form
    {
        private readonly NorthwindContext _context = new NorthwindContext();
        Customer customer = new Customer();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgw1.DataSource = _context.Customers.ToList();
        }

        private void txtEkle_Click(object sender, EventArgs e)
        {
            try
            {
                customer.CustomerId = txtID.Text;
                customer.CompanyName = txtSirket.Text;
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                Message("Ayný ID ye sahip 2 müþteri ekleyemezsiniz, Ekleme Ýþlemi yapýlamadý", customer);
            }

            dgw1.DataSource = _context.Customers.ToList();

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
         
            try
            {
                #region Foreach ile find
                // string ID = dgw1.Rows[index].Cells[0].Value.ToString();
                //foreach (Customer custo in _context.Customers)
                //{
                //    if (custo.CustomerId == ID)
                //    {
                //        customer = custo;
                //    }
                //} 
                            //// = _context.Customers.Where(x => x.CustomerId == ID).First();
                #endregion
                Customer cust = GetSelectedCustomer();
                _context.Update(cust);
                _context.SaveChanges();
                dgw1.DataSource = _context.Customers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                Customer cust = GetSelectedCustomer();
                if (Message("Silinecek Emin Misiniz ? (Bu Ýþlem Geri Alýnamaz)", cust, "Silme Ýþlemi"))
                {
                    _context.Customers.Remove(cust);
                    _context.SaveChanges();
                    dgw1.DataSource = _context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgw1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        private Customer GetSelectedCustomer()//seçilen müþteriyi bulup return eder
        {
            var selected = dgw1.Rows[index];
            string ID = selected.Cells[0].Value.ToString();
            Customer cust = _context.Customers.Find(ID);
            return cust;
        }
        private bool Message(string msg, Customer cust, string islem = "Bilgi")
        {
            DialogResult dr = MessageBox.Show($"ID={cust.CustomerId} Customer={cust.CompanyName} \n {msg}", islem, MessageBoxButtons.OKCancel);

            return dr == DialogResult.OK ? true : false;
        }
    }
}
