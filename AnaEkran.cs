using System;
using System.Windows.Forms;

namespace uzayoyunuodev.Desktop
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.ShowDialog();
            frm.Close();

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
