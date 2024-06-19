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
            //atualizarDadosAoEntrar();
            textBoxPreco.TextChanged += textBoxPreco_TextChanged;
            comboBoxExtras.SelectedIndexChanged += comboBoxExtras_SelectedIndexChanged;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CarregarPratosDisponiveis();
            CarregarExtrasDisponiveis();
        }

        public bool validarDadosInseridos()
        {
            // Validação da seleção de um prato
            if (ComboBoxPrato.SelectedIndex == -1)
            {
                MessageBox.Show("Tem que selecionar um prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Validação do preço inserido
            // Substitua 'textBoxPreco' pelo nome real do seu campo de texto de preço, se for diferente
            if (string.IsNullOrWhiteSpace(textBoxPreco.Text))
            {
                MessageBox.Show("Tem que inserir um preço para este menu!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ListBoxMENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherMenu = ListBoxMENU.SelectedIndex;
            if (escolherMenu != -1)
            {
                Menu menuSelecionado = (Menu)ListBoxMENU.SelectedItem;
                ComboBoxPrato.Text = menuSelecionado.Prato.DescricaoPrato;
                comboBoxExtras.Text = menuSelecionado.Extra.DescricaoExtra;
                ComboBoxTipo.Text = menuSelecionado.Prato.TipoPrato;
                TextboxQuantidade.Text = menuSelecionado.Quantidade.ToString();
                dateTimePickerdoMENU.Text = menuSelecionado.Horario.ToString();
                dateTimePickerHoraMENU.Text = menuSelecionado.Horario.ToString();
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
            if (decimal.TryParse(textBoxPreco.Text, out decimal precoBase))
            {
                decimal precoExtra = 0;

                if (comboBoxExtras.SelectedItem is Extra extraSelecionado)
                {
                    precoExtra = extraSelecionado.PrecoExtra; // Certifique-se de que PrecoExtra está correto
                }

                decimal precoTotal = precoBase + precoExtra;
                labelPrecoEstudante.Text = precoTotal.ToString("C");
                decimal precoProf = precoTotal - 0.70m;
                labelPrecoProf.Text = precoProf >= 0 ? precoProf.ToString("C") : "Valor inválido";
            }
            else
            {
                labelPrecoEstudante.Text = "Valor inválido";
                labelPrecoProf.Text = "Valor inválido";
            }
        }

        private void comboBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarPrecos();
        }

        private void buttonCriarMenu_Click(object sender, EventArgs e)
        {
            // Validação dos dados inseridos
            if (!validarDadosInseridos())
            {
                return;
            }

            // Coleta de informações dos controles
            Prato pratoSelecionado = (Prato)ComboBoxPrato.SelectedItem;
            Extra extraSelecionado = (Extra)comboBoxExtras.SelectedItem;
            if (!decimal.TryParse(labelPrecoEstudante.Text.Trim('€'), out decimal precoEstudante))
            {
                MessageBox.Show("Preço de estudante inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(labelPrecoProf.Text.Trim('€'), out decimal precoProfessor))
            {
                MessageBox.Show("Preço de professor inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(TextboxQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro positivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeSpan horario = dateTimePickerdoMENU.Value.TimeOfDay;

            // Criação do objeto Menu
            Menu novoMenu = new Menu(pratoSelecionado, extraSelecionado, precoEstudante, precoProfessor, quantidade, horario);

            // Adiciona o novo menu à ListBoxMENU para visualização
            ListBoxMENU.Items.Add(novoMenu);

            // Salva o novo menu na base de dados
            using (var db = new ApplicationContext())
            {
                db.Menus.Add(novoMenu);
                db.SaveChanges();
            }

            MessageBox.Show("Menu criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var menus = db.Menus.OfType<Menu>();
                foreach (var menu in menus) //correr os extras para os adicionar à listBox 
                {
                    ListBoxMENU.Items.Add(menu);
                }
            }
        }*/
    }
}
    