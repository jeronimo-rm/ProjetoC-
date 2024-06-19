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
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            timerFormReservas.Tick += timerFormReservas_Tick;
            monthCalendar1.MinDate = DateTime.Today; // Impede a seleção de datas anteriores à data atual
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(1);
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

        private void CarregarPratosDisponiveis(int? idMenu = null)
        {

            using (var db = new ApplicationContext())
            {
                 List<Prato> pratos;

                if (idMenu.HasValue)
                {
                    pratos = db.Pratos.Where(estadoPrato => estadoPrato.EstadoPrato == "Ativado" && estadoPrato.Id == idMenu.Value).ToList();
                }
                else
                {
                    pratos = new List<Prato>();
                }
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

            // Verifica se há um extra selecionado e adiciona seu preço ao valor total
            if (comboBoxExtras.SelectedItem is Extra precoExtra)
            {
                valorTotal += precoExtra.PrecoExtra;
            }

            // Verifica se a labelMulta tem um valor numérico válido e adiciona ao valor total
            if (!string.IsNullOrEmpty(labelMulta.Text))
            {
                // Tenta converter o texto da labelMulta para decimal, considerando o formato de moeda
                if (decimal.TryParse(labelMulta.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal valorMulta))
                {
                    valorTotal += valorMulta;
                }
            }

            // Atualiza o texto da textBoxValor com o valor total formatado como moeda
            textBoxValor.Text = valorTotal.ToString("C");
        }

        private void comboBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem is Menu menu)
            {
                CarregarPratosDisponiveis(menu.Id);
            }
        }

        private void timerFormReservas_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusHora.Text = DateTime.Now.ToString("G");
            VerificarMulta();
        }

        private void VerificarMulta()
        {
            TimeSpan horaAtual = DateTime.Now.TimeOfDay;

            using (var db = new ApplicationContext())
            {
                // Busca por uma multa cuja hora é igual ou anterior à hora atual
                var multaAplicavel = db.Multas.OrderByDescending(multa => multa.NumHoras) // Garante que a multa mais recente seja considerada primeiro
                                       .FirstOrDefault(multa => horaAtual >= multa.NumHoras);

                if (multaAplicavel != null)
                {
                    // Se encontrou uma multa aplicável, atualiza a label com o valor dessa multa
                    AtualizarLabelMulta(multaAplicavel.Valor);
                }
                else
                {
                    // Se não encontrou nenhuma multa aplicável, pode optar por limpar a label ou deixar o valor anterior
                    labelMulta.Text = null;
                }
            }
            AtualizarValorTotal();
        }

        private void AtualizarLabelMulta(decimal valorMulta)
        {
            labelMulta.Text = valorMulta.ToString("C");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
        }
    }
}