﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormFuncionarios : Form
    {
        private FormPrincipal formPrincipal;

        public FormFuncionarios()
        {
            InitializeComponent();
            atualizarDadosAoEntrar();
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        public FormFuncionarios(FormPrincipal formPrincipal) : this() // recebemos no construtor deste form o form principal e podemos utilizar os metodos do principal
        {
            this.formPrincipal = formPrincipal;
        }

        private void atualizarDadosAoEntrar()
        {
            using (var db = new ApplicationContext())
            {
                var funcionarios = db.Utilizadores.OfType<Funcionario>();
                foreach (var funcionario in funcionarios) //correr os funcionarios para os adicionar à listBox 
                {
                    listBoxFuncionarios.Items.Add(funcionario);
                }
            }
        }


        public bool validarDadosFuncionario()
        {
            // RECEBE AS VARIAVEIS DAS TEXTBOX E VALIDA QUE NÃO ESTAO VAZIAS
            // retorna false caso nao cumpra qualquer condicao
            // retorna true caso cumpra a todas
            string usernameFuncionario = textBoxUsernameFuncionario.Text;
            if (usernameFuncionario.Length == 0)
            {
                MessageBox.Show("O campo 'username' não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            double nifFuncionario;
            if (!double.TryParse(textBoxNIFFuncionario.Text, out nifFuncionario))
            {
                MessageBox.Show("O valor do 'nif' deve ser numérico!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string nomeFuncionario = textBoxNomeFuncionario.Text;
            if (nomeFuncionario.Length == 0)
            {
                MessageBox.Show("O campo 'nome' não pode ser vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardarFuncionario_Click(object sender, EventArgs e)
        {
            // vai ver se cumpre a todas as condicoes , caso nao cumpra qualquer condiçao vai saltar fora
            if (!validarDadosFuncionario())
            {// caso cumpra vai continuar
                return;
            }

            //guarda os valores inseridos nas variaveis
            string usernameFuncionario = textBoxUsernameFuncionario.Text;
            string nifUtilizador =  textBoxNIFFuncionario.Text;// faz a conversao de texto para double
            string nomeUtilizador = textBoxNomeFuncionario.Text;
            
            try
            {   // manda para o construtor faz a instancia
                Funcionario funcionario = new Funcionario(usernameFuncionario, nifUtilizador, nomeUtilizador.ToString());
                textBoxNomeFuncionario.Text = funcionario.NomeUtilizador;
                textBoxUsernameFuncionario.Text = funcionario.UsernameFuncionario;
                textBoxNIFFuncionario.Text = funcionario.NIFUtilizador.ToString();
            }
            catch (Exception)
            {   // caso haja algum erro
                MessageBox.Show("Erro ao criar funcionário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (listBoxFuncionarios.SelectedIndex != -1) // se tiver um funcionario selecionado, altera os dados
            {
                Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem;
                // altera dos dados do funcionario selecionado
                funcionarioSelecionado.UsernameFuncionario = textBoxUsernameFuncionario.Text;
                funcionarioSelecionado.NIFUtilizador = textBoxNIFFuncionario.Text;
                funcionarioSelecionado.NomeUtilizador = textBoxNomeFuncionario.Text;
                // Atualizar a exibição do funcionário na ListBox
                int editarfuncionario = listBoxFuncionarios.SelectedIndex;
                listBoxFuncionarios.Items[editarfuncionario] = funcionarioSelecionado;

                using (var db = new ApplicationContext())
                {   //faz update do funcionario
                    db.Utilizadores.AddOrUpdate(funcionarioSelecionado);
                    db.SaveChanges();
                }
            }
            else // se não tiver, cria um novo
            {
                Funcionario novofuncionario = new Funcionario(textBoxUsernameFuncionario.Text, textBoxNIFFuncionario.Text, textBoxNomeFuncionario.Text);

                listBoxFuncionarios.Items.Add(novofuncionario); // mostra na listbox antes de atualizar a db
                using (var db = new ApplicationContext())
                {   // cria novo funcionario
                    db.Utilizadores.Add(novofuncionario);
                    db.SaveChanges();
                }
            }
        }

        private void buttonApagarFuncionario_Click(object sender, EventArgs e)
        {
            int apagarFunc = listBoxFuncionarios.SelectedIndex;
            if (apagarFunc == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxFuncionarios.Items[apagarFunc] is Funcionario funcionario)
            {
                //se tiver funcionario selecionado
                // apaga da listbox
                listBoxFuncionarios.Items.Remove(funcionario);
                //apaga da base de dados
                var db = new ApplicationContext();
                var apagarfuncionario = db.Utilizadores.Find(funcionario.Id); // buscar o id do funcionario q queremos apagar
                if (apagarfuncionario != null) // so faz isso se tiver um funcionario
                {
                    db.Utilizadores.Remove(apagarfuncionario); // remove funcionario pelo id
                    db.SaveChanges(); // guarda as alterações na base de dados
                }
            }
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolherFunc = listBoxFuncionarios.SelectedIndex;
            if (escolherFunc != -1)
            {
                using (var db = new ApplicationContext())
                {
                    Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem; // descobrir o que será indicado nas textbox ao selecionar na listBox
                    // mostrar na textBox os dados do funcionario selecionado                                                                                   
                    textBoxUsernameFuncionario.Text = funcionarioSelecionado.UsernameFuncionario;
                    textBoxNIFFuncionario.Text = funcionarioSelecionado.NIFUtilizador;
                    textBoxNomeFuncionario.Text = funcionarioSelecionado.NomeUtilizador;
                    
                }
            }
        }
        private void listBoxFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            //verificar que foi selecionado algo
            //caso tenha sido fazer o set no footer do menuprincipal
            int escolherFunc = listBoxFuncionarios.SelectedIndex;
            if (escolherFunc == -1)
            {
                // se n tiver funcionario selecionado mensagem de erro
                MessageBox.Show("Selecione um Funcionário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // buscar o nome do funcionario selecionado
            if (listBoxFuncionarios.Items[escolherFunc] is Funcionario funcionario)
            {
                var db = new ApplicationContext();
                var usernamefuncionario = db.Utilizadores.Find(funcionario.Id); // buscar o id do funcionario q queremos mandar para o formprincipal
                if (usernamefuncionario != null) // so faz isso se tiver um funcionario
                {
                    this.formPrincipal.setUsernameFuncionario(usernamefuncionario.Id);
                    this.Close();
                }
            }
        }
        public void limparDadosInseridos()
        {
            textBoxUsernameFuncionario.Clear();
            textBoxNIFFuncionario.Clear();
            textBoxNomeFuncionario.Clear();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            listBoxFuncionarios.ClearSelected();
            limparDadosInseridos();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBoxFuncionarios.ClearSelected();
            limparDadosInseridos();
        }
    }
}