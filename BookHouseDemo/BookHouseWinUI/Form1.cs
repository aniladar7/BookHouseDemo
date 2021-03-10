using BookHouseWinUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHouseWinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildFrom(Form childForm)
        {
            bool durum = false;
            foreach (Form  form in this.MdiChildren)
            {
                if (form.Text==childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum==false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yazarİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFrom(new AuthorForm());
        }
    }
}
