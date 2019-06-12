using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace AppGaragem
{
    public partial class Form1 : Form
    {

        private static List<Cliente> lstCliente = new List<Cliente>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            //Salvar:
            lstCliente.Add(cliente);

            //Imprimir:
            MessageBox.Show("Cliente gravado com sucesso! \n" +
                cliente.ToString(), "Informação");

            //Limpar:
            LimparCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string msg = "";

            foreach (var item in lstCliente)
            {
                msg = msg + item;
            }

            MessageBox.Show(msg, "Dados");
            GerarArquivo.GerarLog(lstCliente);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstCliente.Clear();
            LimparCampos();
            MessageBox.Show("Registros Excluidos com sucesso!","Informação");
        }

        private void LimparCampos()
        {
            //Limpar campos
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();

            //Inserir o Foco no campo ID
            txtId.Focus();
        }


    }
}
