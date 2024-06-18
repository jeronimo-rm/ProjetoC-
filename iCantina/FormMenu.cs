using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class FormMenu : Form
    {
        public FormMenu(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            textBoxPreco.TextChanged += textBoxPreco_TextChanged;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CarregarPratosDisponiveis();
            CarregarExtrasDisponiveis();
        }

        public bool validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            int pratoselecionado = ListBoxMENU.SelectedIndex;
            if (pratoselecionado== -1)
            {
                MessageBox.Show("Tem que selecionar um prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int Tiposelecionado = ListBoxMENU.SelectedIndex;
            if (Tiposelecionado == -1)
            {
                MessageBox.Show("Tem que selecionar u m tipo, Estudante/Professor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string precoInserido = ListBoxMENU.Text;
            if (precoInserido == null)
            {
                MessageBox.Show("Tem que inserir um preço para este menu!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int prato = int.Parse(ComboBoxPrato.Text);
            int tipoPrato =int.Parse( ComboBoxTipo.Text);
            int quantidade  = int.Parse(TextboxQuantidade.Text);
            int extra = int.Parse(comboBoxExtras.Text);         


            validarDadosInseridos();

            // se for vazio mensagem de erro 
                string Preco = textBoxPreco.Text.ToString();
                if (Preco == "")
                {
                    MessageBox.Show("Digite o Preço do Menu!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    decimal preco = decimal.Parse(Preco);
              //    string data = dateTimePickerdoMENU.Value.ToString("dd/MM/yyyy");
                    TimeSpan hora = TimeSpan.Parse(dateTimePickerHoraMENU.Value.ToString("HH:mm"));

                decimal precoEstudante = preco;
                decimal precoProfessor = preco;


                Menu menu = new Menu(prato, extra, precoEstudante, precoProfessor, quantidade, hora);
                var db = new ApplicationContext();
                ListBoxMENU.Items.Add(menu);
                db.Menus.Add(menu); // Adicionar menu na base de dados
                db.SaveChanges(); // Salva as alterações na base de dados
            }
                catch (FormatException)
                {
                    MessageBox.Show("Erro", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void ListBoxMENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menulista= ListBoxMENU.SelectedIndex;
            if (menulista!= -1)
            {
                using (var db = new ApplicationContext())
                {
                    Menu menuselecionado= (Menu)ListBoxMENU.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                                                                               // mostra dados da multa                                                                                   
                    ComboBoxPrato.Text = menuselecionado.IdPrato.ToString();
                    if(ComboBoxTipo.Text == "Estudante")
                    {
                        textBoxPreco.Text = menuselecionado.PrecoEstudante.ToString();
                    }
                    else
                    {
                        textBoxPreco.Text = menuselecionado.PrecoProfessor.ToString();
                    }
                    dateTimePickerdoMENU.Value.Add(menuselecionado.Horario);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int apagarMenu = ListBoxMENU.SelectedIndex;
            if (apagarMenu== -1)
            {
                // se n tiver menu selecionada mensagem de erro
                MessageBox.Show("Selecione um Menu!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ListBoxMENU.Items[apagarMenu] is Menu menu)
            {
                //se tiver menu selecionada
                // apaga da listbox
                ListBoxMENU.Items.Remove(menu);
                //apaga da base de dados
                var db = new ApplicationContext();
                var menuapagar = db.Menus.Find(menu.Id); 
                if (menuapagar != null) // so faz isso se tiver um menu
                {
                    db.Menus.Remove(menuapagar); // remove menu pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
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
            //mostrar todos os pratos ativos na comboBoxPrato
            List<Prato> prato;
            
                using (var db = new ApplicationContext())
                {
                    prato = db.Pratos.Where(estadoPrato => estadoPrato.EstadoPrato == "Ativado").ToList();

                    ComboBoxPrato.DisplayMember = "descricaoPrato";
                    ComboBoxPrato.ValueMember = "Id";
                    ComboBoxPrato.DataSource = prato;
                }
        }

        private void ComboBoxPrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBoxPrato.SelectedIndex != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Prato prato = (Prato)ComboBoxPrato.SelectedItem;
                    ComboBoxTipo.Text = prato.TipoPrato;
                }
            }
        }
        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecos();
        }
        private void AtualizarPrecos()
        {
            // Tenta converter o texto da textBoxPreco para um valor decimal
            if (decimal.TryParse(textBoxPreco.Text, out decimal precoBase))
            {
                // Inicializa o preço do extra como 0
                decimal precoExtra = 0;

                // Verifica se um extra está selecionado e tenta obter seu preço
                if (comboBoxExtras.SelectedItem is Extra extraSelecionado)
                {
                    precoExtra = extraSelecionado.PrecoExtra;
                }

                // Calcula o preço total adicionando o preço do extra ao preço base
                decimal precoTotal = precoBase + precoExtra;

                // Atualiza a labelPrecoEstudante com o preço total
                labelPrecoEstudante.Text = precoTotal.ToString("C");

                // Calcula o preço para professores, subtraindo 0,70 do preço total
                decimal precoProf = precoTotal - 0.70m;

                // Verifica se o preço para professores não é negativo antes de atualizar a labelPrecoProf
                labelPrecoProf.Text = precoProf >= 0 ? precoProf.ToString("C") : "Valor inválido";
            }
            else
            {
                // Se o valor inserido não for um número válido, atualiza as labels para indicar o erro
                labelPrecoEstudante.Text = "Valor inválido";
                labelPrecoProf.Text = "Valor inválido";
            }
        }
    }
}
    