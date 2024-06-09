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
    public partial class FormMulta : Form
    {
        public FormMulta(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            //dateTimePickerMulta.MinDate = DateTime.Now; // seleciona data de hoje pra frente
            atualizarListboxMultasaoEntrar();
        }

        private void FormMulta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ListBoxMulta.ClearSelected();
            LimprarDados();
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        public bool validarDadosInseridos()
        {   // RECEBE VALORES DAS TEXTSBOX E VALIDA
            string valorMulta = textBoxValor.Text;
            if (valorMulta == null)
            {
                MessageBox.Show("Tem que inserir um valor para a multa!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ListBoxMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escmulta = ListBoxMulta.SelectedIndex;
            if (escmulta != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Multa multaselecionada = (Multa)ListBoxMulta.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                                                                               // mostra dados da multa                                                                                   
                    textBoxValor.Text = multaselecionada.Valor.ToString();
                    dateTimePickerMulta.Text = multaselecionada.NumHoras.ToString();


                }
            }
        }
        private void LimprarDados()
        {
            textBoxValor.Text = 0.ToString();
            dateTimePickerMulta.Value = dateTimePickerMulta.Value.Date.AddHours(10).AddMinutes(0);
        }
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            //Criar uma multa
            TimeSpan numHoras = TimeSpan.Parse(dateTimePickerMulta.Text);
            double Valor = double.Parse(textBoxValor.Text);

            if (!validarDadosInseridos())
            {
                return;
            }
            try
            {
                // manda para o construtor faz a instancia
                Multa multa = new Multa(Valor, numHoras);
            }
            catch
            {
                // caso haja algum erro
                MessageBox.Show("Erro ao criar Multa", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ListBoxMulta.SelectedIndex != -1) // se tiver uma multa selecionada, editar os dados
            {
                Multa multaSelecionada = (Multa)ListBoxMulta.SelectedItem;
                // altera dos dados da multa selecionada
                multaSelecionada.Valor = double.Parse(textBoxValor.Text);
                multaSelecionada.NumHoras = TimeSpan.Parse(dateTimePickerMulta.Text);

                // Atualizar a exibição das Multas na ListBox
                int editarMulta = ListBoxMulta.SelectedIndex;
                ListBoxMulta.Items[editarMulta] = multaSelecionada;

                using (var db = new ApplicationContext())
                {   //faz update da Multa
                    db.Multas.AddOrUpdate(multaSelecionada);
                    db.SaveChanges();
                }
            }
            else // se não , cria um novo
            {
                Multa novaMulta = new Multa(double.Parse(textBoxValor.Text), TimeSpan.Parse(dateTimePickerMulta.Text));

                ListBoxMulta.Items.Add(novaMulta); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria nova multa
                    db.Multas.Add(novaMulta);
                    db.SaveChanges();
                }
            }

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int apagarMulta = ListBoxMulta.SelectedIndex;
            if (apagarMulta == -1)
            {
                // se n tiver multa selecionada mensagem de erro
                MessageBox.Show("Selecione uma multa primeiro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ListBoxMulta.Items[apagarMulta] is Multa multa)
            {
                //se tiver multa selecionada

                ListBoxMulta.Items.Remove(multa);
                //apaga da base de dados
                var db = new ApplicationContext();
                var apagarmulta = db.Multas.Find(multa.ID); // buscar o id da multa selecionada
                if (apagarmulta != null)
                {
                    db.Multas.Remove(apagarmulta); // remove multa pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        public void atualizarListboxMultasaoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var multas = db.Multas;
                foreach (var multa in multas) //correr os pratos para os adicionar à listBox 
                {
                    ListBoxMulta.Items.Add(multa);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ListBoxMulta.ClearSelected();
            LimprarDados();
        }
    }
}
