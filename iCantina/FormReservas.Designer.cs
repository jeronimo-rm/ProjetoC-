﻿namespace iCantina
{
    partial class FormReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlReservas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxListaReservas = new System.Windows.Forms.GroupBox();
            this.btnFatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.buttonApagarReserva = new System.Windows.Forms.Button();
            this.buttonGuardarReserva = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMulta = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.LabelValor = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxExtras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPrato = new System.Windows.Forms.ComboBox();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxDone = new System.Windows.Forms.ListBox();
            this.listBoxWaiting = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFormReservas = new System.Windows.Forms.Timer(this.components);
            this.tabControlReservas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxListaReservas.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservas
            // 
            this.tabControlReservas.Controls.Add(this.tabPage1);
            this.tabControlReservas.Controls.Add(this.tabPage2);
            this.tabControlReservas.Location = new System.Drawing.Point(11, 11);
            this.tabControlReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlReservas.Name = "tabControlReservas";
            this.tabControlReservas.SelectedIndex = 0;
            this.tabControlReservas.Size = new System.Drawing.Size(856, 534);
            this.tabControlReservas.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxListaReservas);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(848, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxListaReservas
            // 
            this.groupBoxListaReservas.Controls.Add(this.btnFatura);
            this.groupBoxListaReservas.Controls.Add(this.label1);
            this.groupBoxListaReservas.Controls.Add(this.listBoxReservas);
            this.groupBoxListaReservas.Controls.Add(this.buttonApagarReserva);
            this.groupBoxListaReservas.Controls.Add(this.buttonGuardarReserva);
            this.groupBoxListaReservas.Location = new System.Drawing.Point(364, 3);
            this.groupBoxListaReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListaReservas.Name = "groupBoxListaReservas";
            this.groupBoxListaReservas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListaReservas.Size = new System.Drawing.Size(465, 385);
            this.groupBoxListaReservas.TabIndex = 19;
            this.groupBoxListaReservas.TabStop = false;
            this.groupBoxListaReservas.Text = "Lista de Reservas";
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.Teal;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFatura.Location = new System.Drawing.Point(98, 314);
            this.btnFatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(76, 32);
            this.btnFatura.TabIndex = 7;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(4, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Clicar na Reserva em questão e clicar no botão Apagar ";
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(3, 25);
            this.listBoxReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(447, 238);
            this.listBoxReservas.TabIndex = 0;
            // 
            // buttonApagarReserva
            // 
            this.buttonApagarReserva.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarReserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarReserva.Location = new System.Drawing.Point(191, 314);
            this.buttonApagarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApagarReserva.Name = "buttonApagarReserva";
            this.buttonApagarReserva.Size = new System.Drawing.Size(76, 32);
            this.buttonApagarReserva.TabIndex = 5;
            this.buttonApagarReserva.Text = "Apagar";
            this.buttonApagarReserva.UseVisualStyleBackColor = false;
            // 
            // buttonGuardarReserva
            // 
            this.buttonGuardarReserva.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarReserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarReserva.Location = new System.Drawing.Point(7, 314);
            this.buttonGuardarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardarReserva.Name = "buttonGuardarReserva";
            this.buttonGuardarReserva.Size = new System.Drawing.Size(76, 32);
            this.buttonGuardarReserva.TabIndex = 4;
            this.buttonGuardarReserva.Text = "Guardar";
            this.buttonGuardarReserva.UseVisualStyleBackColor = false;
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.buttonPesquisarClientes);
            this.groupBoxFuncionario.Controls.Add(this.textBoxCliente);
            this.groupBoxFuncionario.Controls.Add(this.label5);
            this.groupBoxFuncionario.Controls.Add(this.label6);
            this.groupBoxFuncionario.Controls.Add(this.labelMulta);
            this.groupBoxFuncionario.Controls.Add(this.labelSaldo);
            this.groupBoxFuncionario.Controls.Add(this.label3);
            this.groupBoxFuncionario.Controls.Add(this.textBoxValor);
            this.groupBoxFuncionario.Controls.Add(this.LabelValor);
            this.groupBoxFuncionario.Controls.Add(this.dateTimePicker1);
            this.groupBoxFuncionario.Controls.Add(this.monthCalendar1);
            this.groupBoxFuncionario.Controls.Add(this.comboBoxExtras);
            this.groupBoxFuncionario.Controls.Add(this.label2);
            this.groupBoxFuncionario.Controls.Add(this.comboBoxPrato);
            this.groupBoxFuncionario.Controls.Add(this.comboBoxMenu);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNIF);
            this.groupBoxFuncionario.Controls.Add(this.label8);
            this.groupBoxFuncionario.Controls.Add(this.label10);
            this.groupBoxFuncionario.Controls.Add(this.label11);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFuncionario.Size = new System.Drawing.Size(330, 501);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Reservas";
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(227, 32);
            this.buttonPesquisarClientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(83, 20);
            this.buttonPesquisarClientes.TabIndex = 19;
            this.buttonPesquisarClientes.Text = "PESQUISAR";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Location = new System.Drawing.Point(49, 81);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(170, 20);
            this.textBoxCliente.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Multa:";
            // 
            // labelMulta
            // 
            this.labelMulta.AutoSize = true;
            this.labelMulta.Location = new System.Drawing.Point(241, 145);
            this.labelMulta.Name = "labelMulta";
            this.labelMulta.Size = new System.Drawing.Size(0, 13);
            this.labelMulta.TabIndex = 15;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(273, 84);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 13);
            this.labelSaldo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saldo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(195, 466);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(130, 20);
            this.textBoxValor.TabIndex = 12;
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValor.Location = new System.Drawing.Point(141, 467);
            this.LabelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(44, 15);
            this.LabelValor.TabIndex = 11;
            this.LabelValor.Text = "Valor:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 19, 9, 15, 30, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 292);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.Location = new System.Drawing.Point(8, 231);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtras.TabIndex = 8;
            this.comboBoxExtras.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtras_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Extras:";
            // 
            // comboBoxPrato
            // 
            this.comboBoxPrato.FormattingEnabled = true;
            this.comboBoxPrato.Location = new System.Drawing.Point(7, 182);
            this.comboBoxPrato.Name = "comboBoxPrato";
            this.comboBoxPrato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrato.TabIndex = 6;
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(8, 135);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMenu.TabIndex = 5;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(88, 32);
            this.textBoxNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(131, 20);
            this.textBoxNIF.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Prato:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Menu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "NIF do Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxDone);
            this.tabPage2.Controls.Add(this.listBoxWaiting);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(848, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verificação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(362, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "==>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "==>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "==>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "RESERVAS CONFIRMADAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "RESERVAS PENDENTES";
            // 
            // listBoxDone
            // 
            this.listBoxDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDone.FormattingEnabled = true;
            this.listBoxDone.ItemHeight = 17;
            this.listBoxDone.Location = new System.Drawing.Point(448, 46);
            this.listBoxDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxDone.Name = "listBoxDone";
            this.listBoxDone.Size = new System.Drawing.Size(398, 378);
            this.listBoxDone.TabIndex = 1;
            // 
            // listBoxWaiting
            // 
            this.listBoxWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWaiting.FormattingEnabled = true;
            this.listBoxWaiting.ItemHeight = 17;
            this.listBoxWaiting.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc"});
            this.listBoxWaiting.Location = new System.Drawing.Point(4, 46);
            this.listBoxWaiting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxWaiting.Name = "listBoxWaiting";
            this.listBoxWaiting.Size = new System.Drawing.Size(407, 378);
            this.listBoxWaiting.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusHora
            // 
            this.toolStripStatusHora.Name = "toolStripStatusHora";
            this.toolStripStatusHora.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusHora.Text = "toolStripStatusHora";
            // 
            // timerFormReservas
            // 
            this.timerFormReservas.Enabled = true;
            this.timerFormReservas.Tick += new System.EventHandler(this.timerFormReservas_Tick);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 584);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlReservas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.tabControlReservas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxListaReservas.ResumeLayout(false);
            this.groupBoxListaReservas.PerformLayout();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxListaReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Button buttonApagarReserva;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Button buttonGuardarReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPrato;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.ComboBox comboBoxExtras;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelValor;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxDone;
        private System.Windows.Forms.ListBox listBoxWaiting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHora;
        private System.Windows.Forms.Timer timerFormReservas;
    }
}