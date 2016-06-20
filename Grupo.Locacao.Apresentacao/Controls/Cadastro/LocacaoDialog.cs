using Grupo.Locacao.Dominio.Contratos;
using Grupo.Locacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo.Locacao.Apresentacao.Controls.Cadastro
{
    public partial class LocacaoDialog : Form
    {
        private ILocacaoRepositorio  _Ilocacao;
        private LocacaoCarro _locacao;
        public LocacaoDialog()
        {
            InitializeComponent();
        }
        public LocacaoCarro locacaoCarro
        {
            get
            {
                return _locacao;
            }
            set
            {
                _locacao = value;

                txtNome.Text =  _locacao.Clientes.Nome.ToString();
                txtCpf.Text = _locacao.Clientes.Cpf;
                txtTelefone.Text = _locacao.Clientes.Telefone;
                cmbData.Value = _locacao.DataLocacao;
                txtModelo.Text = _locacao.Carros.Nome;
                txtMarca.Text = _locacao.Carros.Marca;
                txtPlaca.Text = _locacao.Carros.Placa;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocacaoDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locacaoCarroDBDataSet.LocacaoCarroes' table. You can move, or remove it, as needed.
            this.locacaoCarroesTableAdapter.Fill(this.locacaoCarroDBDataSet.LocacaoCarroes);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _locacao.Clientes.Nome = txtNome.Text;
                _locacao.Clientes.Cpf = txtCpf.Text;
                _locacao.Clientes.Telefone = txtTelefone.Text;
                _locacao.DataLocacao = cmbData.Value;
                _locacao.Carros.Nome = txtModelo.Text;
                _locacao.Carros.Marca = txtMarca.Text;
                _locacao.Carros.Placa = txtPlaca.Text;

            }
            catch (Exception exc)
            {
                //Principal.Instance.ShowErrorInFooter(exc.Message);

                //DialogResult = DialogResult.None;
            }
        }
    }
}
