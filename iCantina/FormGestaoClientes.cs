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
    public partial class FormGestaoClientes : Form
    {
        private FormPrincipal FormPrincipal;

        public FormGestaoClientes()
        {
            InitializeComponent();
            AtualizarDadosAoEntrar();
        }

        public TabPage getPage()
        {
            return tabControlClientes.TabPages[0];
        }

        public FormGestaoClientes(FormPrincipal formPrincipal) : this()
        {
            this.FormPrincipal = formPrincipal;
        }

        private void AtualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var clientes = db.Utilizadores.OfType<Cliente>();
                foreach (var cliente in clientes) //Correr os clientes para os adicionar à listBox
                {
                    listBoxClientes.Items.Add(cliente);
                }
            }
        }
        
        public bool ValidarDadosCliente()
        {
            // Recebe as variáveis das textbox e valida que não estão vazias
            // Retorna false caso não cumpra qualquer condição
            string nomeCliente = textBoxNomeCliente.Text;
            if (nomeCliente.Length < 3)
            {
                MessageBox.Show("O campo 'nome' não pode ter menos de 3 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int nifCliente;
            if (textBoxNIFCliente.Text.Length != 9 || !int.TryParse(textBoxNIFCliente.Text, out nifCliente))
            {
                MessageBox.Show("O campo 'NIF' tem de ter 9 digitos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int saldoCliente;
            if (!int.TryParse(textBoxSaldoCliente.Text, out saldoCliente))
            {
                MessageBox.Show("O campo 'saldo' tem de ser um número positivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }   
        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarDadosCliente())
            {
                return;
            }

            //guarda os valores inseridos nas variaveis
            string nomeCliente = textBoxNomeCliente.Text;
            int nifCliente = int.Parse(textBoxNIFCliente.Text); //fax a conversão do texto para Int
            int saldoCliente = int.Parse(textBoxSaldoCliente.Text);

            try
            {
                Cliente cliente = new Cliente(nomeCliente, nifCliente, saldoCliente);
                textBoxNomeCliente.Text = cliente.NomeUtilizador;
                textBoxNIFCliente.Text = cliente.NIFUtilizador.ToString();
                textBoxSaldoCliente.Text = cliente.Saldo.ToString();
            }
            catch
            {
                //caso haja algum erro, mostra uma mensagem de erro
                MessageBox.Show("Erro ao guardar o cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (listBoxClientes.SelectedIndex != -1) // se tiver um funcionario selecionado, altera os dados
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                // altera dos dados do funcionario selecionado
                clienteSelecionado.NomeUtilizador = textBoxNomeCliente.Text;
                clienteSelecionado.NIFUtilizador = int.Parse(textBoxNIFCliente.Text);
                clienteSelecionado.Saldo = int.Parse(textBoxSaldoCliente.Text);
                // Atualizar a exibição do funcionário na ListBox
                int editarCliente = listBoxClientes.SelectedIndex;
                listBoxClientes.Items[editarCliente] = clienteSelecionado;

                using (var db = new ApplicationContext())
                {
                    db.Utilizadores.AddOrUpdate(clienteSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Cliente novoCliente = new Cliente(textBoxNomeCliente.Text, int.Parse(textBoxNIFCliente.Text), int.Parse(textBoxSaldoCliente.Text));

                listBoxClientes.Items.Add(novoCliente); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {
                    db.Utilizadores.Add(novoCliente);
                    db.SaveChanges();
                }
            }
        }
        private void buttonApagarFuncionario_Click(object sender, EventArgs e)
        {
            int apagarCliente = listBoxClientes.SelectedIndex;
            if (apagarCliente == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um cliente para apagar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxClientes.Items[apagarCliente] is Cliente cliente)
            {
                //se tiver funcionario selecionado
                // apaga da listbox
                listBoxClientes.Items.RemoveAt(apagarCliente);
                //apaga da base de dado
                var db = new ApplicationContext();
                var apagarClienteDb = db.Utilizadores.Find(cliente.Id);
                if (apagarClienteDb != null)
                {
                    db.Utilizadores.Remove(apagarClienteDb);
                    db.SaveChanges();
                }
            }
        }
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clienteSelecionado = listBoxClientes.SelectedIndex;
            if(clienteSelecionado != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Cliente clienteSelect = (Cliente)listBoxClientes.SelectedItem;
                    textBoxNomeCliente.Text = clienteSelect.NomeUtilizador;
                    textBoxNIFCliente.Text = clienteSelect.NIFUtilizador.ToString();
                    textBoxSaldoCliente.Text = clienteSelect.Saldo.ToString();
                }
            }
        }
        private void listBoxClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int clienteSelecionado = listBoxClientes.SelectedIndex;
            if (clienteSelecionado != -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ver as informações do cliente selecionado
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            textBoxNomeCliente.Text = cliente.NomeUtilizador;
            textBoxNIFCliente.Text = cliente.NIFUtilizador.ToString();
            textBoxSaldoCliente.Text = cliente.Saldo.ToString();
        }
    }
}
