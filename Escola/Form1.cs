
using System.Data.Common;
using Escola.Dados;
namespace Escola

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dados.DBconnections.GetConnection().ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DBconnections dados = new DBconnections();
            dados.Cadastrar(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtTelefone.Text);
            MessageBox.Show("Cadastrar com sucesso");
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //excluir
            DBconnections dados = new DBconnections();
            dados.Excluir(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Excluido com sucesso");
            txtNome.Focus();


        }
    }
}
