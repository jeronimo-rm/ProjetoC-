using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void FormMulta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ListboxMulta.ClearSelected();
            LimprarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Criar uma multa
            string Valor = textboxValor.Text;
            string horas = textboxhoras.Text;
            try
            {
                Multa multa= new Multa(Valor,horas);
                textboxhoras.Text = multa.Horas;
                textboxValor.Text = multa.Valor.ToString();

            }
            catch
            {
                // caso haja algum erro
                MessageBox.Show("Erro ao criar Multa", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ListboxMulta.SelectedIndex != -1) // se tiver uma multa selecionada, editar os dados
            {
                Multa multaSelecionada = (Multa)ListboxMulta.SelectedItem;
                // altera dos dados da multa selecionada
                multaSelecionada.Valor = textboxValor.Text;
                multaSelecionada.Horas= textboxhoras.Text;
            }
            else // se não , cria um novo
            {
                Multa novaMulta= new Multa(textboxhoras.Text, textboxValor.Text);

                ListboxMulta.Items.Add(novaMulta); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria nova multa
                    db.Multas.Add(novaMulta);
                    db.SaveChanges();
                }
            }
        }


        private void LimprarDados()
        {
            textboxValor.Clear();
           textboxhoras.Clear();
        }


        private void Apagar_Click(object sender, EventArgs e)
        {
            int apagarMulta = ListboxMulta.SelectedIndex;
            if (apagarMulta== -1)
            {
                // se n tiver multa selecionada mensagem de erro
                MessageBox.Show("Selecione uma multa primeiro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ListboxMulta.Items[apagarMulta] is Multa multa)
            {
                //se tiver multa selecionada
              
                ListboxMulta.Items.Remove(multa);
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

        private void ListboxMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Escmulta = ListboxMulta.SelectedIndex;
            if (Escmulta!= -1)
            {
                using (var db = new ApplicationContext())
                {
                    Multa multaseleionada= (Multa)ListboxMulta.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    // mostra dados da multa                                                                                   
                    textboxValor.Text = multaseleionada.Valor;
                    textboxhoras.Text = multaseleionada.Horas;

                }
            }
        }
    }
}

