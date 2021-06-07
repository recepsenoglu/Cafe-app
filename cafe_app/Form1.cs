using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_app
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        // Garson seçme formunu açar
        private void btnGarson_Click(object sender, EventArgs e)
        {
            formGarsonSec formGarsonSec = new formGarsonSec();
            formGarsonSec.Show();
            Hide();
        }

        // Şef formunu açar
        private void btnSef_Click(object sender, EventArgs e)
        {
            formSef formSef = new formSef();
            formSef.Show();
            Hide();
        }

        // Masa seçme formunu ödeme alma amacıyla açar
        private void btnKasa_Click(object sender, EventArgs e)
        {
            formMasaSec formMasaSec = new formMasaSec();
            formMasaSec.amac = "odeme_al";
            formMasaSec.Show();
            Hide();
        }
    }
}
