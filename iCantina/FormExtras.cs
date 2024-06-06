using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class FormExtras : Form
    {
        private FormPrincipal formPrincipal;
        public FormExtras()
        {
            InitializeComponent();
            atualizarDadosAoEntrar();
        }
        public FormExtras(FormPrincipal formPrincipal) :this()
        {
            this.formPrincipal = formPrincipal;
        }

        public TabPage getPage()
        {
            return tabControlExtras.TabPages[0];
        }

        private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var extras = db.Extras.OfType<Extra>();
                foreach (var extra in extras) //correr os extras para os adicionar à listBox 
                {
                    listBoxExtras.Items.Add(extra);
                }
            }
        }

        public bool ValidarDadosInseridos()
        {
            string descricaoExtra = textBoxDescricao.Text;
            if (descricaoExtra.Length == 0)
            {
                MessageBox.Show("Insira a descrição do Extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            decimal precoExtra = decimal.Parse(textBoxPreco.Text);
            if (precoExtra == 0)
            {
                MessageBox.Show("Insira o preço do Extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string EstadoExtra = comboBoxEstado.Text;
            if (EstadoExtra.Length == 0)
            {
                MessageBox.Show("Escolha o estado do Extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha um estado da lista!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int quantidadeExtra = int.Parse(textBoxQuantidade.Text);
            if (quantidadeExtra == 0)
            {
                MessageBox.Show("Insira a quantidade do Extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormExtras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBoxExtras.ClearSelected();

        }

        private void buttonGuardarExtra_Click(object sender, EventArgs e)
        {
            string descricaoExtra = textBoxDescricao.Text;
            decimal precoExtra = decimal.Parse(textBoxPreco.Text);
            string estadoExtra = comboBoxEstado.Text;
            int quantidadeExtra = int.Parse(textBoxQuantidade.Text);
            if (!ValidarDadosInseridos())
            {
                return;
            }
            try
            {
                Extra extra = new Extra(descricaoExtra, precoExtra, estadoExtra, quantidadeExtra);
            }
            catch(Exception)
            {
                // caso haja algum erro
                MessageBox.Show("Erro ao criar o prato!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(listBoxExtras.SelectedIndex != -1)
            {
                Extra extraSelecionado = (Extra)listBoxExtras.SelectedItem;

                extraSelecionado.DescricaoExtra = descricaoExtra;
                extraSelecionado.PrecoExtra = precoExtra;
                extraSelecionado.EstadoExtra = estadoExtra;
                extraSelecionado.QuantidadeExtra = quantidadeExtra;

                int editarExtra = listBoxExtras.SelectedIndex;
                listBoxExtras.Items[editarExtra] = extraSelecionado;

                using (var db = new ApplicationContext())
                {
                    //faz update do Extra
                    db.Extras.AddOrUpdate(extraSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver um Extra selecionado, cria um novo
            {
                Extra novoExtra = new Extra(textBoxDescricao.Text, decimal.Parse(textBoxPreco.Text), comboBoxEstado.Text, int.Parse(textBoxQuantidade.Text));

                //mostra na listBox o novo Extra
                listBoxExtras.Items.Add(novoExtra);
                using (var db = new ApplicationContext())
                {
                    //cria novo Extra
                    db.Extras.Add(novoExtra);
                    db.SaveChanges();
                }
            }
            limparDadosInseridos();
        }
        public void AtualizarListBoxExtras()
        {
            listBoxExtras.Items.Clear();
            using (var db = new ApplicationContext())
            {
                foreach (var extra in db.Extras) //correr os extras para os adicionar à listBox
                {
                    listBoxExtras.Items.Add(extra);
                }
            }
        }
        private void buttonApagarExtra_Click(object sender, EventArgs e)
        {
            int apagarExtra = listBoxExtras.SelectedIndex;
            if (apagarExtra == -1)
            {
                // se n tiver Prato selecionado mensagem de erro
                MessageBox.Show("Selecione um Extra!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxExtras.Items[apagarExtra] is Extra extra)
            {
                listBoxExtras.Items.Remove(extra);
                var db = new ApplicationContext();
                var apagarextra = db.Extras.Find(extra.Id);
                if (apagarextra != null)
                {
                    db.Extras.Remove(apagarextra);
                    db.SaveChanges();
                }
            }
        }

        private void listBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherExtra = listBoxExtras.SelectedIndex;
            if(escolherExtra != -1)
            {
                Extra extraSelecionado = (Extra)listBoxExtras.SelectedItem;
                textBoxDescricao.Text = extraSelecionado.DescricaoExtra;
                textBoxPreco.Text = extraSelecionado.PrecoExtra.ToString();
                comboBoxEstado.Text = extraSelecionado.EstadoExtra;
                textBoxQuantidade.Text = extraSelecionado.QuantidadeExtra.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxExtras.ClearSelected();
        }
        public void limparDadosInseridos()
        {
            textBoxDescricao.Clear();
            textBoxPreco.Clear();
            comboBoxEstado.SelectedIndex = -1;
            textBoxQuantidade.Clear();
        }
    }
}
