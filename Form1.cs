using Product.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductContext objContext = new ProductContext();
            var ted = objContext.Saticis.Where(x => x.sName == textBox1.Text).SingleOrDefault();

            if (ted == null)
            {
                Entity.Satici stc = new Entity.Satici();
                stc.sName = textBox1.Text;
                stc.Password = textBox2.Text;
                objContext.Saticis.Add(stc);
                objContext.SaveChanges();

                MessageBox.Show("Sign Up Successfully\n Please Log In!..", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is already someone registered with the same name!..", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductContext objContext = new ProductContext();
            var nesne = objContext.Saticis.Where(x => x.sName == textBox1.Text).SingleOrDefault();

            if (nesne != null)
            {
                MessageBox.Show("Log In Successfully!..", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No account found with that name!..", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
