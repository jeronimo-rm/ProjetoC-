namespace iCantina
{
    partial class FormGestaoClientes
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
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonApagarFuncionario = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNumEstudante = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNumEstudante = new System.Windows.Forms.Label();
            this.RadioProf = new System.Windows.Forms.RadioButton();
            this.RadioEstudante = new System.Windows.Forms.RadioButton();
            this.labelNifClientes = new System.Windows.Forms.Label();
            this.textBoxSaldoCliente = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.textBoxNIFCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Location = new System.Drawing.Point(15, 15);
            this.tabControlClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(1129, 335);
            this.tabControlClientes.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarFuncionario);
            this.tabPage1.Controls.Add(this.textBox_pesquisa);
            this.tabPage1.Controls.Add(this.buttonPesquisarClientes);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Controls.Add(this.listBoxClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1121, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonApagarFuncionario
            // 
            this.buttonApagarFuncionario.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarFuncionario.Location = new System.Drawing.Point(1012, 267);
            this.buttonApagarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagarFuncionario.Name = "buttonApagarFuncionario";
            this.buttonApagarFuncionario.Size = new System.Drawing.Size(101, 33);
            this.buttonApagarFuncionario.TabIndex = 10;
            this.buttonApagarFuncionario.Text = "Apagar";
            this.buttonApagarFuncionario.UseVisualStyleBackColor = false;
            this.buttonApagarFuncionario.Click += new System.EventHandler(this.buttonApagarFuncionario_Click);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(347, 9);
            this.textBox_pesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_pesquisa.MaxLength = 9;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(225, 22);
            this.textBox_pesquisa.TabIndex = 5;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(579, 7);
            this.buttonPesquisarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(147, 25);
            this.buttonPesquisarClientes.TabIndex = 6;
            this.buttonPesquisarClientes.Text = "PESQUISAR";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.textBoxEmail);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNumEstudante);
            this.groupBoxFuncionario.Controls.Add(this.labelEmail);
            this.groupBoxFuncionario.Controls.Add(this.labelNumEstudante);
            this.groupBoxFuncionario.Controls.Add(this.RadioProf);
            this.groupBoxFuncionario.Controls.Add(this.RadioEstudante);
            this.groupBoxFuncionario.Controls.Add(this.labelNifClientes);
            this.groupBoxFuncionario.Controls.Add(this.textBoxSaldoCliente);
            this.groupBoxFuncionario.Controls.Add(this.labelSaldo);
            this.groupBoxFuncionario.Controls.Add(this.buttonGuardarCliente);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNIFCliente);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxFuncionario.Controls.Add(this.labelNomesClientes);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(3, 5);
            this.groupBoxFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxFuncionario.Size = new System.Drawing.Size(313, 290);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Clientes";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(83, 213);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 22);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxNumEstudante
            // 
            this.textBoxNumEstudante.Location = new System.Drawing.Point(129, 181);
            this.textBoxNumEstudante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumEstudante.Name = "textBoxNumEstudante";
            this.textBoxNumEstudante.Size = new System.Drawing.Size(179, 22);
            this.textBoxNumEstudante.TabIndex = 14;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 215);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email:";
            // 
            // labelNumEstudante
            // 
            this.labelNumEstudante.AutoSize = true;
            this.labelNumEstudante.Location = new System.Drawing.Point(9, 186);
            this.labelNumEstudante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumEstudante.Name = "labelNumEstudante";
            this.labelNumEstudante.Size = new System.Drawing.Size(98, 16);
            this.labelNumEstudante.TabIndex = 12;
            this.labelNumEstudante.Text = "NumEstudante:";
            // 
            // RadioProf
            // 
            this.RadioProf.AutoSize = true;
            this.RadioProf.Location = new System.Drawing.Point(196, 142);
            this.RadioProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioProf.Name = "RadioProf";
            this.RadioProf.Size = new System.Drawing.Size(86, 20);
            this.RadioProf.TabIndex = 11;
            this.RadioProf.TabStop = true;
            this.RadioProf.Text = "Professor";
            this.RadioProf.UseVisualStyleBackColor = true;
            this.RadioProf.CheckedChanged += new System.EventHandler(this.RadioProf_CheckedChanged);
            // 
            // RadioEstudante
            // 
            this.RadioEstudante.AutoSize = true;
            this.RadioEstudante.Location = new System.Drawing.Point(13, 140);
            this.RadioEstudante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioEstudante.Name = "RadioEstudante";
            this.RadioEstudante.Size = new System.Drawing.Size(88, 20);
            this.RadioEstudante.TabIndex = 10;
            this.RadioEstudante.TabStop = true;
            this.RadioEstudante.Text = "Estudante";
            this.RadioEstudante.UseVisualStyleBackColor = true;
            this.RadioEstudante.CheckedChanged += new System.EventHandler(this.RadioEstudante_CheckedChanged);
            // 
            // labelNifClientes
            // 
            this.labelNifClientes.AutoSize = true;
            this.labelNifClientes.Location = new System.Drawing.Point(11, 66);
            this.labelNifClientes.Name = "labelNifClientes";
            this.labelNifClientes.Size = new System.Drawing.Size(31, 16);
            this.labelNifClientes.TabIndex = 9;
            this.labelNifClientes.Text = "NIF:";
            // 
            // textBoxSaldoCliente
            // 
            this.textBoxSaldoCliente.Location = new System.Drawing.Point(83, 98);
            this.textBoxSaldoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSaldoCliente.Name = "textBoxSaldoCliente";
            this.textBoxSaldoCliente.Size = new System.Drawing.Size(225, 22);
            this.textBoxSaldoCliente.TabIndex = 7;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(11, 102);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(46, 16);
            this.labelSaldo.TabIndex = 6;
            this.labelSaldo.Text = "Saldo:";
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarCliente.Location = new System.Drawing.Point(207, 250);
            this.buttonGuardarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(101, 33);
            this.buttonGuardarCliente.TabIndex = 5;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = false;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // textBoxNIFCliente
            // 
            this.textBoxNIFCliente.Location = new System.Drawing.Point(83, 63);
            this.textBoxNIFCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNIFCliente.Name = "textBoxNIFCliente";
            this.textBoxNIFCliente.Size = new System.Drawing.Size(225, 22);
            this.textBoxNIFCliente.TabIndex = 2;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(83, 31);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(225, 22);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(9, 36);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(47, 16);
            this.labelNomesClientes.TabIndex = 0;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(347, 36);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(768, 228);
            this.listBoxClientes.TabIndex = 9;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            this.listBoxClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxClientes_MouseDoubleClick);
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1173, 380);
            this.Controls.Add(this.tabControlClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGestaoClientes";
            this.Text = "FormGestaoClientes";
            this.Load += new System.EventHandler(this.FormGestaoClientes_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonApagarFuncionario;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.TextBox textBoxNIFCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelNomesClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.TextBox textBoxSaldoCliente;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelNifClientes;
        private System.Windows.Forms.RadioButton RadioProf;
        private System.Windows.Forms.RadioButton RadioEstudante;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumEstudante;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNumEstudante;
    }
}