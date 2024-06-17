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
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

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
            int tipoPrato =int.Parse( comboBoxTipo.Text);
            string estadoPrato = comboBoxEstado.Text;
            int quantidade  = int.Parse(TextboxQuantidade.Text);
            int extra = int.Parse(comboBoExtras.Text);         


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
                    double preco = double.Parse(Preco);
              //    string data = dateTimePickerdoMENU.Value.ToString("dd/MM/yyyy");
                    TimeSpan hora = TimeSpan.Parse(dateTimePickerHoraMENU.Value.ToString("HH:mm"));


                
                    Menu menu = new Menu(prato,extra, preco, quantidade,hora);
                    var db = new ApplicationContext();
                    ListBoxMENU.Items.Add(menu);
                            var sessoes = db.Menus.ToList();
                            db.Menus.Add(menu); // Adicionar menu na base de dados
                            db.SaveChanges(); // Salva as alterações base de dados
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
                    if(comboBoxTipo.Text == "Estudante")
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
                //se tiver sessao selecionada
                // apaga da listbox
                ListBoxMENU.Items.Remove(menu);
                //apaga da base de dados
                var db = new ApplicationContext();
                var menuapagar = db.Menus.Find(menu.Id); // buscar o id da sessao que queremos apagar
                if (menuapagar != null) // so faz isso se tiver uma sessao
                {
                    db.Menus.Remove(menuapagar); // remove sala pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }
    }
}
