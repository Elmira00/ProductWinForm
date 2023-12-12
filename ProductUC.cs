using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class ProductUC : UserControl
    {

        //Binding Start
        public string ProductName
        {
            get { return NameLbl.Text; }
            set { NameLbl.Text = value; }
        }
        public double Price
        {
            get { return Convert.ToInt32(priceLbl.Text); }
            set { priceLbl.Text = value.ToString(); }
        }

        public Image Image
        {
            get { return ImgBox.Image; }
            set { ImgBox.Image = value; }
        }
        //Binding End

        public ProductUC()
        {
            InitializeComponent();
        }
    }
}
