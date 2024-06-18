using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // foi para por data e hora
using System.Drawing.Text;

namespace iCantina
{
    public partial class FormPrincipal : Form
    {
        Form formPratos; // nao fazer instancia mas sim mandar para o o construtor
        Form formMenu;
        Form formFuncionario;
        Form formExtras;
        Form formGestaoClientes;
        Form formMulta;
        Form formReservas;

        public FormPrincipal()
        {
            InitializeComponent();
            // FORM CENTRADO COM ECRA
            this.CenterToScreen();
            formPratos = new FormPratos();
            formFuncionario = new FormFuncionarios(this);
            formGestaoClientes = new FormGestaoClientes(this);
            formExtras = new FormExtras(this);
            formMenu = new FormMenu(this);
            formReservas = new FormReservas(this);
            formMulta = new FormMulta(this);

            formFuncionario.ShowDialog();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)
        }


        // MÉTODO PARA ATUALIZAR A LABEL COM O NOME DO FUNCIONARIO LOGADO
        public void setUsernameFuncionario(int Id)
        {
            var db = new ApplicationContext();
            var funcionario = db.Utilizadores.Find(Id) as Funcionario; // procura o funcionario pelo id recebido
            toolStripStatusLabelNomeFuncionarioLogado.Text = funcionario.UsernameFuncionario; // para aparecer o nome na label
        }
        private void toolStripStatusLabelNomeFuncionarioLogado_Click(object sender, EventArgs e)
        {
            formFuncionario.ShowDialog();
        }

        private void buttonPratos_Click(object sender, EventArgs e)
        {
            formPratos.ShowDialog();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            formMenu.ShowDialog();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            formFuncionario.ShowDialog();
        }

        private void buttonExtras_Click(object sender, EventArgs e)
        {
            formExtras.ShowDialog();
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            formReservas.ShowDialog();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            formGestaoClientes.ShowDialog();
        }

        private void buttonMulta_Click(object sender, EventArgs e)
        {
            formMulta.ShowDialog();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            /*desativar todos os dias anteriores ao atual 
            monthCalendar.MinDate = DateTime.Now;
            monthCalendar.Show();*/

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
