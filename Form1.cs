using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12.Properties;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {

        List<Product> products = new List<Product>();
        HomeUc homeUc = new HomeUc();
      
        public Form1()
        {
            InitializeComponent();
            LoadHomeControl();
            LoadProducts();
        }
        private void LoadHomeControl()
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(homeUc);

        }
        private void LoadProductControl()
        {
            containerPanel.Controls.Clear();
            int x = 0;
            int y = 20;
            foreach (var p in products)
            {
                var productUC = new ProductUC();
                productUC.Location = new Point(x, y);
                y += 100;
                productUC.DoubleClick += Product_DoubleClick;
                productUC.ProductName = p.Name;
                productUC.Price = p.Price;
                productUC.Image = p.Image;
                containerPanel.Controls.Add(productUC);
            }
        }

        private void Product_DoubleClick(object sender, EventArgs e)
        {
            //hansini secib sonra o birsini secirikse evvelki secilen oz rengine qayidir
            foreach (var item in containerPanel.Controls)
            {
                if (item is ProductUC c)
                {
                    c.BackColor = Color.SpringGreen;
                }
            }
            var uc = sender as ProductUC;
            uc.BackColor = Color.Aquamarine;
        }

        private void LoadProducts()
        {
            products.Add(
                new Product { Name = "Asus Rog Strix", Price = 1723.60, Image = Resources.asus });
               products.Add(
                new Product { Name = "Iphone 13 pro max", Price = 2200, Image = Resources.iphone });
               products.Add(
                new Product { Name = "Zenbook Pro Slim", Price = 3200, Image = Resources.zenbook });
               products.Add(
                new Product { Name = "Samsung S22", Price = 1115, Image = Resources.samsung });
               

                
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            LoadProductControl();
        }

        private void guna2Panel5_Click(object sender, EventArgs e)
        {
            LoadProductControl();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LoadProductControl();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            LoadHomeControl();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            LoadHomeControl();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            LoadHomeControl();
        }
    }
}
