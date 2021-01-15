using Product.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var StokUrun = File.ReadLines(@"D:\StokUrun.txt");

            foreach (var urn in StokUrun)
            {
                listBox1.Items.Add(urn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductContext objContex = new ProductContext();
            Entity.Urun urun = new Entity.Urun();

            urun.irsaliyeNo = Int32.Parse((listBox1.Items[0]).ToString());
            urun.barkodNo = Int32.Parse((listBox1.Items[1]).ToString());
            urun.birimGirdiFiyati = Int32.Parse((listBox1.Items[2]).ToString());
            urun.depodakiMiktar = Int32.Parse((listBox1.Items[3]).ToString());
            urun.tarih = Int32.Parse((listBox1.Items[4]).ToString());
            urun.urunKodu = Int32.Parse((listBox1.Items[5]).ToString());
            //urun.Tedarikci.tedarikciID = Int32.Parse(tedarikciIsmi);

            objContex.Uruns.Add(urun);
            objContex.SaveChanges();

            TextWriter tw = new StreamWriter(@"D:\StokUrun.txt");
            tw.Write("");
            tw.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
