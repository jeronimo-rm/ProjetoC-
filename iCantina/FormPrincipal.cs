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
            formFuncionario = new FormFuncionario(this);
            formGestaoClientes = new FormGestaoClientes(this);
            formExtras = new FormExtras(this);
            formMenu = new FormMenu(this);
            formReservas = new FormReservas(this);
            formMulta = new FormMulta(this);
     
        }

        private void pratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPratos.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMenu.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionario.ShowDialog();
        }

        private void extrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formExtras.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReservas.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGestaoClientes.ShowDialog();
        }

        private void multaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMulta.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void timerFormPrincipal_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelHora.Text = DateTime.Now.ToString("G"); // F, U, ou G (senao apaga o G e ver as opcoes)
        }
    }
}
