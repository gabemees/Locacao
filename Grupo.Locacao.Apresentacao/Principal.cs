using Grupo.Locacao.Apresentacao.Controls.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo.Locacao.Apresentacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locacaoCarroDBDataSet.LocacaoCarroes' table. You can move, or remove it, as needed.
            this.locacaoCarroesTableAdapter.Fill(this.locacaoCarroDBDataSet.LocacaoCarroes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocacaoDialog locacaoDialog = new LocacaoDialog();
            locacaoDialog.Show();
        }
    }
}
