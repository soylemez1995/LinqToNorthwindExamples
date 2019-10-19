using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTo_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void btnExample_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees
                .Select(x => new
                {
                    İsim = x.FirstName,
                    Soyisim = x.LastName
                }).ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 50).ToList();
            
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                FirmaAdi = x.CompanyName,
                Adres = x.Address,
                Telefon = x.Phone

            }).ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).ToList();
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            List<string> countrylist = db.Orders.Select(a => a.ShipCountry).Distinct().ToList();
            foreach (var item in countrylist)
            {
                listBox1.Items.Add(item);

            }
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductID == 5);
            MessageBox.Show(product.ProductName);
        }

        private void btnOrderByDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.OrderByDescending(x => x.EmployeeID).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.Contains("a")).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= db.Products.Where(p => p.CategoryID == 3).OrderBy(p => p.ProductName).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            bool sonuc = db.Products.Any(p => p.ProductName.Contains("ha"));
            MessageBox.Show(sonuc.ToString());
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(x => x.ShipName.StartsWith("a")).ToList();
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.Where(x => x.CompanyName.EndsWith("a")).ToList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int adet = db.Products.Count();
            MessageBox.Show(adet.ToString());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Product product = db.Products.Find(3);
            MessageBox.Show(product.ProductName);

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            decimal? toplamfiyat = db.Products.Sum(p => p.UnitPrice);
            MessageBox.Show(toplamfiyat.ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            decimal? pahaliurun = db.Products.Max(x => x.UnitPrice);
            MessageBox.Show(pahaliurun.ToString());
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.OrderByDescending(x => x.EmployeeID).Skip(4).Take(4).ToList();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.OrderByDescending(x => x.EmployeeID).Take(2).ToList();
        }

        
    }

    
}
