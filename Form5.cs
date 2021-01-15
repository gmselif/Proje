using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product.Entity;

namespace Product
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (Model1 _entity = new Model1())
            {
                List<Tedarikci> _tedarikciList = new List<Tedarikci>();
                _tedarikciList = _entity.Tedarikcis.Select(x => new Tedarikci
                {
                    tedarikciID = x.tedarikciID,

                }).ToList();
                dataGridView1.DataSource = _tedarikciList;
            }
        }
    }
}
