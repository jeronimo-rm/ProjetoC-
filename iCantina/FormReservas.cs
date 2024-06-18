using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class FormReservas : Form
    {
        private FormPrincipal FormPrincipal;

        public TabPage getPage()
        {
            return tabControlReservas.TabPages[0];
        }

        public FormReservas(FormPrincipal formPrincipal) : this()
        {
            this.FormPrincipal = formPrincipal;
        }
        public FormReservas()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            string valorPesquisa = textBoxNIF.Text;

            using (var db = new ApplicationContext())
            {
                List<Cliente> clientes = new List<Cliente>();

                // Removeu a verificação que buscava todos os clientes se a pesquisa estivesse vazia
                if (!string.IsNullOrEmpty(valorPesquisa))
                {
                    // Se a pesquisa não estiver vazia, obtenha os clientes que correspondem à pesquisa
                    clientes = db.Utilizadores.OfType<Cliente>().Where(c => c.NIFUtilizador.ToString().Contains(valorPesquisa)).ToList();
                }

                if (clientes.Any()) // se houver algum cliente que corresponda à pesquisa
                {
                    textBoxCliente.Text = ""; // Limpa o texto antes de adicionar novos itens
                    foreach (var cliente in clientes)
                    {
                        textBoxCliente.Text += cliente.NomeUtilizador;
                        labelSaldo.Text = cliente.Saldo.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void FormReservas_Load(object sender, EventArgs e)
        {
            CarregarExtrasDisponiveis();
            CarregarPratosDisponiveis();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CarregarExtrasDisponiveis()
        {
            List<Extra> extras;
            
            using (var db = new ApplicationContext())
            {
                // Supondo que a tabela Extras tenha uma coluna 'Ativo' que indica se o extra está ativo
                extras = db.Extras.Where(estadoExtra => estadoExtra.EstadoExtra == "Ativo").ToList();
                
                comboBoxExtras.DisplayMember = "descricaoExtra"; 
                comboBoxExtras.ValueMember = "Id"; 
                comboBoxExtras.DataSource = extras;
            }
        }

        private void CarregarPratosDisponiveis()
        {
            List<Prato> pratos;

            using (var db = new ApplicationContext())
            {
                pratos = db.Pratos.Where(estadoPrato => estadoPrato.EstadoPrato == "Ativo").ToList();

                comboBoxPrato.DisplayMember = "descricaoPrato";
                comboBoxPrato.ValueMember = "Id";
                comboBoxPrato.DataSource = pratos;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarValorTotal()
        {
            decimal valorTotal = 0;

            if (comboBoxExtras.SelectedItem is Extra precoExtra)
            {
                valorTotal += precoExtra.PrecoExtra;
            }

            textBoxValor.Text = valorTotal.ToString("C");
        }

        private void comboBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }
    }
}