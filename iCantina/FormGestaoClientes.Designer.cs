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
            this.buttonMaisInfo = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.textBoxSaldoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.textBoxNIFCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Location = new System.Drawing.Point(11, 12);
            this.tabControlClientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(847, 272);
            this.tabControlClientes.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarFuncionario);
            this.tabPage1.Controls.Add(this.buttonMaisInfo);
            this.tabPage1.Controls.Add(this.textBox_pesquisa);
            this.tabPage1.Controls.Add(this.buttonPesquisarClientes);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Controls.Add(this.listBoxClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(839, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonApagarFuncionario
            // 
            this.buttonApagarFuncionario.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarFuncionario.Location = new System.Drawing.Point(759, 217);
            this.buttonApagarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarFuncionario.Name = "buttonApagarFuncionario";
            this.buttonApagarFuncionario.Size = new System.Drawing.Size(76, 27);
            this.buttonApagarFuncionario.TabIndex = 10;
            this.buttonApagarFuncionario.Text = "Apagar";
            this.buttonApagarFuncionario.UseVisualStyleBackColor = false;
            this.buttonApagarFuncionario.Click += new System.EventHandler(this.buttonApagarFuncionario_Click);
            // 
            // buttonMaisInfo
            // 
            this.buttonMaisInfo.Location = new System.Drawing.Point(649, 220);
            this.buttonMaisInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonMaisInfo.Name = "buttonMaisInfo";
            this.buttonMaisInfo.Size = new System.Drawing.Size(80, 20);
            this.buttonMaisInfo.TabIndex = 8;
            this.buttonMaisInfo.Text = "+ Info";
            this.buttonMaisInfo.UseVisualStyleBackColor = true;
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(260, 7);
            this.textBox_pesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_pesquisa.MaxLength = 9;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(170, 20);
            this.textBox_pesquisa.TabIndex = 5;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(434, 6);
            this.buttonPesquisarClientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(110, 20);
            this.buttonPesquisarClientes.TabIndex = 6;
            this.buttonPesquisarClientes.Text = "PESQUISAR";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.label2);
            this.groupBoxFuncionario.Controls.Add(this.textBoxSaldoCliente);
            this.groupBoxFuncionario.Controls.Add(this.label1);
            this.groupBoxFuncionario.Controls.Add(this.buttonGuardarCliente);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNIFCliente);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxFuncionario.Controls.Add(this.labelNomesClientes);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(2, 4);
            this.groupBoxFuncionario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxFuncionario.Size = new System.Drawing.Size(235, 211);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Clientes";
            // 
            // textBoxSaldoCliente
            // 
            this.textBoxSaldoCliente.Location = new System.Drawing.Point(62, 80);
            this.textBoxSaldoCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSaldoCliente.Name = "textBoxSaldoCliente";
            this.textBoxSaldoCliente.Size = new System.Drawing.Size(170, 20);
            this.textBoxSaldoCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saldo:";
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarCliente.Location = new System.Drawing.Point(155, 179);
            this.buttonGuardarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(76, 27);
            this.buttonGuardarCliente.TabIndex = 5;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = false;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // textBoxNIFCliente
            // 
            this.textBoxNIFCliente.Location = new System.Drawing.Point(62, 51);
            this.textBoxNIFCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNIFCliente.Name = "textBoxNIFCliente";
            this.textBoxNIFCliente.Size = new System.Drawing.Size(170, 20);
            this.textBoxNIFCliente.TabIndex = 2;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(62, 25);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(170, 20);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(7, 29);
            this.labelNomesClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(38, 13);
            this.labelNomesClientes.TabIndex = 0;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(260, 29);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(577, 186);
            this.listBoxClientes.TabIndex = 9;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            this.listBoxClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxClientes_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIF:";
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 309);
            this.Controls.Add(this.tabControlClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestaoClientes";
            this.Text = "FormGestaoClientes";
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
        private System.Windows.Forms.Button buttonMaisInfo;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.TextBox textBoxNIFCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelNomesClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.TextBox textBoxSaldoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}