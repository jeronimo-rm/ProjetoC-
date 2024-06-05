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

            string emailCliente;
            if (RadioProf.Checked)
            {
                emailCliente = textBoxEmail.Text;
                if (emailCliente.Length < 3)
                {
                    MessageBox.Show("O campo 'email' não pode ter menos de 3 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Validação do formato do email
                var emailRegex = new System.Text.RegularExpressions.Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                if (!emailRegex.IsMatch(emailCliente))
                {
                    MessageBox.Show("O campo 'email' não está num formato válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }


            int numEstudante;
            if (RadioEstudante.Checked)
            {
                if (!int.TryParse(textBoxNumEstudante.Text, out numEstudante))
                {
                    MessageBox.Show("O campo 'número de estudante' tem de ser um número positivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
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
            int nifCliente = int.Parse(textBoxNIFCliente.Text); //faz a conversão do texto para Int
            int saldoCliente = int.Parse(textBoxSaldoCliente.Text);
            string emailCliente = textBoxEmail.Text;
            int numEstudante = 0;
            if (RadioEstudante.Checked && !string.IsNullOrEmpty(textBoxNumEstudante.Text))
            {
                int.TryParse(textBoxNumEstudante.Text, out numEstudante);
            }

            try
            {
                if (listBoxClientes.SelectedIndex != -1) // se tiver um cliente selecionado, altera os dados
                {
                    Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                    // altera dos dados do cliente selecionado
                    clienteSelecionado.NomeUtilizador = nomeCliente;
                    clienteSelecionado.NIFUtilizador = nifCliente;
                    clienteSelecionado.Saldo = saldoCliente;

                    // Adiciona as informações do email ou do número do estudante
                    if (RadioProf.Checked && clienteSelecionado is Professor professor)
                    {
                        professor.Email = emailCliente;
                    }
                    else if (RadioEstudante.Checked && clienteSelecionado is Estudante estudante)
                    {
                        estudante.NumEstudante = numEstudante;
                    }

                    // Atualizar a exibição do cliente na ListBox
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
                    Cliente novoCliente;

                    if (RadioProf.Checked)
                    {
                        novoCliente = new Professor(nomeCliente, nifCliente, saldoCliente, emailCliente);
                    }
                    else
                    {
                        novoCliente = new Estudante(nomeCliente, nifCliente, saldoCliente, numEstudante);
                    }   

                    listBoxClientes.Items.Add(novoCliente); // mostra na listbox antes de atualizar a db
                    using (var db = new ApplicationContext())
                    {
                        db.Utilizadores.Add(novoCliente);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                //caso haja algum erro, mostra uma mensagem de erro
                MessageBox.Show($"Erro ao guardar o cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //limpa as textbox
            textBoxNomeCliente.Clear();
            textBoxNIFCliente.Clear();
            textBoxSaldoCliente.Clear();
            textBoxEmail.Clear();
            textBoxNumEstudante.Clear();
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

        }
        private void listBoxClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Aqui, você quer que o cliente seja selecionado apenas quando o usuário der um duplo clique.
            // Então, você pode deixar o código aqui.
            int clienteSelecionado = listBoxClientes.SelectedIndex;
            if (clienteSelecionado != -1)
            {
                Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
                textBoxNomeCliente.Text = cliente.NomeUtilizador;
                textBoxNIFCliente.Text = cliente.NIFUtilizador.ToString();
                textBoxSaldoCliente.Text = cliente.Saldo.ToString();
            }
            else
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            string valorPesquisa = textBox_pesquisa.Text;

            using (var db = new ApplicationContext())
            {
                List<Cliente> clientes;

                if (string.IsNullOrEmpty(valorPesquisa))
                {
                    // Se a pesquisa estiver vazia, obtenha todos os clientes
                    clientes = db.Utilizadores.OfType<Cliente>().ToList();
                }
                else
                {
                    // Se a pesquisa não estiver vazia, obtenha os clientes que correspondem à pesquisa
                    clientes = db.Utilizadores.OfType<Cliente>().Where(c => c.NIFUtilizador.ToString().Contains(valorPesquisa)).ToList();
                }

                if (clientes.Any()) // se houver algum cliente que corresponda à pesquisa
                {
                    listBoxClientes.Items.Clear();
                    foreach (var cliente in clientes)
                    {
                        listBoxClientes.Items.Add(cliente);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxClientes.ClearSelected();
        }

        private void RadioEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioEstudante.Checked)
            {
                labelEmail.Enabled = false;
                textBoxEmail.Enabled = false;
            }
            else
            {
                labelEmail.Enabled = true;
                textBoxEmail.Enabled = true;
            }
        }

        private void RadioProf_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioProf.Checked)
            {
                labelNumEstudante.Enabled = false;
                textBoxNumEstudante.Enabled = false;
            }
            else
            {
                labelNumEstudante.Enabled = true;
                textBoxNumEstudante.Enabled = true;
            }
        }
    }
}
