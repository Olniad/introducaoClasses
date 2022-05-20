using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducaoClasses_09
{
    public partial class FrmAlimento : Form
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }

        private void FrmAlimento_Load(object sender, EventArgs e)
        {

        }

        private void exibirFrmPrefeito_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog(); 
        }

        private void exibirFrmAlimento_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog();
        }

        private void exibirFrmLoja_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog();
        }
    }
}
