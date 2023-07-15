using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBy_Excersize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var branded_items = (
    from x in DataItem.GetDemoData()
    group x by new
    {
        Brand = x.Brand,
    } into g_brand
    select new
    {
        Brand = g_brand.Key.Brand,
        BaseArticleNumbers = (
        from y in g_brand
        where y.Brand == g_brand.Key.Brand
        group y by new
        {
            Brand = y.Brand,
            BaseArtNo = y.BaseArtNo,
        } into g_baseartno
        select new
        {
            brand = g_baseartno.Key.Brand,
            BaseArtNo = g_baseartno.Key.BaseArtNo,
            Colors = (
            from z in g_baseartno
            where z.Brand == g_baseartno.Key.Brand && z.BaseArtNo == g_baseartno.Key.BaseArtNo
            group z by new
            {
                Brand = z.Brand,
                BaseArtNo = z.BaseArtNo,
                Color = z.Color,
            } into g_color
            select g_color
            ).ToArray(),
        }
        ).ToArray(),
    }
    ).ToArray();

                StringBuilder sb = new StringBuilder();

                foreach (var the_brand in branded_items)
                {
                    sb.AppendLine($"{the_brand.Brand}");

                    foreach (var baseartno in the_brand.BaseArticleNumbers)
                    {
                        sb.AppendLine($"Basartikelnummer: {baseartno.BaseArtNo}");

                        foreach (var color in baseartno.Colors)
                        {
                            sb.AppendLine($"{color.Key.Color}");

                            foreach (var item in color)
                            {
                                sb.AppendLine($"{item.Brand}, {item.BaseArtNo}, {item.Color}, {item.Size}");

                            } // foreach item

                        } // foreach color

                    } // foreach baseartno
                    
                } // foreach brand

                OutputTB.Text = sb.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
