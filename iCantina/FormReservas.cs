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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há um item selecionado na listBoxWaiting
                if (listBoxWaiting.SelectedIndex != -1)
                {
                    // Adiciona o item selecionado da listBoxWaiting para listBoxDone
                    listBoxDone.Items.Add(listBoxWaiting.SelectedItem);

                    // Remove o item selecionado da listBoxWaiting
                    int i = listBoxWaiting.SelectedIndex;
                    listBoxWaiting.Items.RemoveAt(i);
                }
                else
                {
                    // Nenhum item selecionado, mostra uma mensagem de aviso
                    MessageBox.Show("Por favor, seleciona um item para mover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Captura qualquer exceção inesperada e mostra uma mensagem de erro
                MessageBox.Show("Ocorreu um erro ao mover o item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool validarDadosInseridos()
        {
            // Validação da seleção de um menu
            if (comboBoxMenu.SelectedIndex == -1)
            {
                MessageBox.Show("Tem que selecionar um menu!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Validação da seleção de um extra
            if (comboBoxExtras.SelectedIndex == -1)
            {
                MessageBox.Show("Tem que selecionar um extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Validação da seleção de um prato
            if (comboBoxPrato.SelectedIndex == -1)
            {
                MessageBox.Show("Tem que selecionar um prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            return true;
        }
        private void buttonGuardarReserva_Click(object sender, EventArgs e)
        {
            // Validação dos dados inseridos
            if (!validarDadosInseridos())
            {
                return;
            }

            // Coleta de informações dos controles
            string nomeCliente = textBoxCliente.Text;
            Prato pratoSelecionado = (Prato)comboBoxPrato.SelectedItem;
            Extra extraSelecionado = (Extra)comboBoxExtras.SelectedItem;
            
            if (!decimal.TryParse(textBoxValor.Text.Trim('€'), out decimal valorSelecionado))
            {
                MessageBox.Show("Valor inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            TimeSpan horario = dateTimePicker1.Value.TimeOfDay;

            // Criação do objeto Reserva
            Reserva novaReserva = new Reserva(nomeCliente, pratoSelecionado, extraSelecionado, valorSelecionado,  horario);
            
            // Adiciona o novo menu à ListBoxMENU para visualização
            listBoxReservas.Items.Add(novaReserva);

            // Salva o novo menu na base de dados
            using (var db = new ApplicationContext())
            {
                db.Reservas.Add(novaReserva);
                db.SaveChanges();
            }

            MessageBox.Show("Reserva criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int escolherReserva = listBoxReservas.SelectedIndex;
                if (escolherReserva != -1)
                {
                    Reserva reservaSelecionado = (Reserva)listBoxReservas.SelectedItem;
                    comboBoxMenu.Text = reservaSelecionado.Prato.DescricaoPrato;
                    comboBoxExtras.Text = reservaSelecionado.Extra.DescricaoExtra;
                    textBoxCliente.Text = reservaSelecionado.Cliente.NomeUtilizador;
                    dateTimePicker1.Text = reservaSelecionado.Menu.Horario.ToString();
                    toolStripStatusHora.Text = reservaSelecionado.ToString();
                }
            }
            catch (Exception ex)
            {
                // Captura qualquer exceção inesperada e mostra uma mensagem de erro
                MessageBox.Show("Reserva foi criado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonApagarReserva_Click(object sender, EventArgs e)
        {

            int apagarReserva = listBoxReservas.SelectedIndex;
            if (apagarReserva == -1)
            {
                // se n tiver reserva selecionada mensagem de erro
                MessageBox.Show("Selecione um Reserva!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxReservas.Items[apagarReserva] is Reserva reserva)
            {
                //se tiver reserva selecionada
                // apaga da listbox
                listBoxReservas.Items.Remove(reserva);
                //apaga da base de dados
                var db = new ApplicationContext();
                var reservaapagar = db.Reservas.Find(reserva.Id);
                if (reservaapagar != null) // so faz isso se tiver uma reserva
                {
                    db.Reservas.Remove(reservaapagar); // remove reserva pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {

        }


        private void exportarBilhete(Reserva reserva)
        {
            try
            {
                string texto_a_escrever = "";

                // Parte 1 - Informações da reserva
                texto_a_escrever += $"ID da Reserva: {reserva.Id}";
                texto_a_escrever += Environment.NewLine;

                texto_a_escrever += $"Cliente: {reserva.Cliente.NomeUtilizador}";
                texto_a_escrever += Environment.NewLine;

                texto_a_escrever += $"Menu: {reserva.Menu.ToString()}";
                texto_a_escrever += Environment.NewLine;

                texto_a_escrever += "Preço Estudante: " + reserva.Menu.PrecoEstudante.ToString("C");
                texto_a_escrever += Environment.NewLine;

                texto_a_escrever += "Preço Professor: " + reserva.Menu.PrecoProfessor.ToString("C");
                texto_a_escrever += Environment.NewLine;

                texto_a_escrever += $"Data e Hora: {reserva.Horario.ToString("dd/MM/yyyy HH:mm")}";
                texto_a_escrever += Environment.NewLine;

                // Separador
                texto_a_escrever += "---------------------------";
                texto_a_escrever += Environment.NewLine;

                
                // Nome do documento
                string nome_documento = reserva.Id + "_" + reserva.Cliente.NomeUtilizador;

                // Configure save file dialog box
                SaveFileDialog dlg = new SaveFileDialog
                {
                    FileName = nome_documento, // Default file name
                    Filter = "PDF Files (*.pdf)|*.pdf", // Default file extensions
                    FilterIndex = 1 // Default filter index
                };

                // Show save file dialog box e process save file dialog box results
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save document
                    string filename = dlg.FileName;
                    ExportToPdf(filename, texto_a_escrever);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o bilhete: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPdf(string filename, string texto)
        {
            try
            {
                // Crie um documento PDF
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();

                // Adicione conteúdo ao PDF
                doc.Add(new Paragraph(texto));

                // Feche o documento
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}