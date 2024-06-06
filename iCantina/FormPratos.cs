using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class FormPratos : Form
    {
        private FormPrincipal formPrincipal;
        public FormPratos()
        {
            InitializeComponent();
            atualizarListboxPratosaoEntrar();
        }
        public FormPratos(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }

        // METODO PARA CHAMAR NO FORM PRINCIPAL A PAGE DA TAB
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        public bool validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            string descricaoPrato = textBoxDescricaoPrato.Text;
            if (descricaoPrato.Length == 0)
            {
                MessageBox.Show("Insira a descrição do Prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string tipoPrato = comboBoxTipoPrato.Text;
            if (tipoPrato.Length == 0)
            {
                MessageBox.Show("Escolha um tipo de Prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string estadoPrato = comboBoxEstadoPrato.Text;
            if (estadoPrato.Length == 0)
            {
                MessageBox.Show("Escolha o estado do Prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxTipoPrato.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha um tipo da lista!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxEstadoPrato.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha o estado do Prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FormPratos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBoxPratos.ClearSelected();
            limparDadosInseridos();
            comboBoxTipoPrato.Text = "Carne";
            comboBoxEstadoPrato.Text = "Desativado";
        }
        //METODO PARA GUARDAR O PRATO
        private void buttonGuardarPrato_Click(object sender, EventArgs e)
        {
            string descricaoPrato = textBoxDescricaoPrato.Text;
            string tipoPrato = comboBoxTipoPrato.Text;
            string estadoPrato = comboBoxEstadoPrato.Text;
            if (!validarDadosInseridos())
            {
                return;
            }
            try
            {   // manda para o construtor faz a instancia
                Prato prato = new Prato(descricaoPrato, tipoPrato, estadoPrato);
            }
            catch (Exception)
            {   // caso haja algum erro
                MessageBox.Show("Erro ao criar o prato!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (listBoxPratos.SelectedIndex != -1) // se tiver um Prato selecionado, altera os dados
            {
                Prato pratoSelecionado = (Prato)listBoxPratos.SelectedItem;
                // altera dos dados do prato selecionado
                pratoSelecionado.descricaoPrato = textBoxDescricaoPrato.Text;
                pratoSelecionado.tipoPrato = comboBoxTipoPrato.Text;
                pratoSelecionado.estadoPrato = comboBoxEstadoPrato.Text;

                // Atualizar a exibição dos pratos na ListBox
                int editarPrato = listBoxPratos.SelectedIndex;
                listBoxPratos.Items[editarPrato] = pratoSelecionado;

                using (var db = new ApplicationContext())
                {   //faz update do Prato
                    db.Pratos.AddOrUpdate(pratoSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Prato novoprato = new Prato(textBoxDescricaoPrato.Text, comboBoxTipoPrato.Text, comboBoxEstadoPrato.Text);

                listBoxPratos.Items.Add(novoprato); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria novo prato
                    db.Pratos.Add(novoprato);
                    db.SaveChanges();
                }
            }
        }
        //METODO PARA ATUALIZAR A LISTBOX
        public void atualizarListboxPratosaoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var pratos = db.Pratos;
                foreach (var prato in pratos) //correr os pratos para os adicionar à listBox 
                {
                    listBoxPratos.Items.Add(prato);
                }
            }
        }

        private void buttonApagarPrato_Click(object sender, EventArgs e)
        {
            int apagarPrato = listBoxPratos.SelectedIndex;
            if (apagarPrato == -1)
            {
                // se n tiver Prato selecionado mensagem de erro
                MessageBox.Show("Selecione um Prato!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxPratos.Items[apagarPrato] is Prato prato)
            {
                listBoxPratos.Items.Remove(prato);
                var db = new ApplicationContext();
                var apagarprato = db.Pratos.Find(prato.Id); // buscar o id do prato q queremos apagar
                if (apagarprato != null) // so faz isso se tiver um filme
                {
                    db.Pratos.Remove(apagarprato); // remove prato pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void listBoxPratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherPrato = listBoxPratos.SelectedIndex;
            if (escolherPrato != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Prato pratoEscolhido = (Prato)listBoxPratos.SelectedItem;
                    textBoxDescricaoPrato.Text = pratoEscolhido.descricaoPrato;
                    comboBoxTipoPrato.Text = pratoEscolhido.tipoPrato;
                    comboBoxEstadoPrato.Text = pratoEscolhido.estadoPrato;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxPratos.ClearSelected();
            limparDadosInseridos();
        }

        public void limparDadosInseridos()
        {
            textBoxDescricaoPrato.Clear();
        }
    }
}
