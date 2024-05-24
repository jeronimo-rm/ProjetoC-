namespace iCantina
{
    partial class FormFuncionarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_entrar = new System.Windows.Forms.Button();
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.buttonApagarFuncionario = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.textBoxUsernameFuncionario = new System.Windows.Forms.TextBox();
            this.buttonGuardarFuncionario = new System.Windows.Forms.Button();
            this.textBoxNomeUtilizador = new System.Windows.Forms.TextBox();
            this.textBoxNIFUtilizador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxListaFuncionarios.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 411);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_entrar);
            this.tabPage1.Controls.Add(this.groupBoxListaFuncionarios);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Funcionarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_entrar
            // 
            this.button_entrar.Location = new System.Drawing.Point(1015, 420);
            this.button_entrar.Margin = new System.Windows.Forms.Padding(4);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(213, 36);
            this.button_entrar.TabIndex = 20;
            this.button_entrar.Text = "ENTRAR";
            this.button_entrar.UseVisualStyleBackColor = true;
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.label1);
            this.groupBoxListaFuncionarios.Controls.Add(this.listBoxFuncionarios);
            this.groupBoxListaFuncionarios.Controls.Add(this.buttonApagarFuncionario);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(355, 4);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(651, 372);
            this.groupBoxListaFuncionarios.TabIndex = 19;
            this.groupBoxListaFuncionarios.TabStop = false;
            this.groupBoxListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Clicar no Funcionário em questão e clicar no botão Apagar ";
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 16;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(4, 31);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(595, 292);
            this.listBoxFuncionarios.TabIndex = 0;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // buttonApagarFuncionario
            // 
            this.buttonApagarFuncionario.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarFuncionario.Location = new System.Drawing.Point(544, 326);
            this.buttonApagarFuncionario.Name = "buttonApagarFuncionario";
            this.buttonApagarFuncionario.Size = new System.Drawing.Size(101, 40);
            this.buttonApagarFuncionario.TabIndex = 5;
            this.buttonApagarFuncionario.Text = "Apagar";
            this.buttonApagarFuncionario.UseVisualStyleBackColor = false;
            this.buttonApagarFuncionario.Click += new System.EventHandler(this.buttonApagarFuncionario_Click);
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.textBoxUsernameFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.buttonGuardarFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeUtilizador);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNIFUtilizador);
            this.groupBoxFuncionario.Controls.Add(this.label8);
            this.groupBoxFuncionario.Controls.Add(this.label10);
            this.groupBoxFuncionario.Controls.Add(this.label11);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(345, 372);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Funcionarios";
            this.groupBoxFuncionario.Enter += new System.EventHandler(this.groupBoxFuncionario_Enter);
            // 
            // textBoxUsernameFuncionario
            // 
            this.textBoxUsernameFuncionario.Location = new System.Drawing.Point(6, 37);
            this.textBoxUsernameFuncionario.Name = "textBoxUsernameFuncionario";
            this.textBoxUsernameFuncionario.Size = new System.Drawing.Size(225, 22);
            this.textBoxUsernameFuncionario.TabIndex = 3;
            // 
            // buttonGuardarFuncionario
            // 
            this.buttonGuardarFuncionario.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarFuncionario.Location = new System.Drawing.Point(238, 326);
            this.buttonGuardarFuncionario.Name = "buttonGuardarFuncionario";
            this.buttonGuardarFuncionario.Size = new System.Drawing.Size(101, 40);
            this.buttonGuardarFuncionario.TabIndex = 4;
            this.buttonGuardarFuncionario.Text = "Guardar";
            this.buttonGuardarFuncionario.UseVisualStyleBackColor = false;
            this.buttonGuardarFuncionario.Click += new System.EventHandler(this.buttonGuardarFuncionario_Click);
            // 
            // textBoxNomeUtilizador
            // 
            this.textBoxNomeUtilizador.Location = new System.Drawing.Point(6, 179);
            this.textBoxNomeUtilizador.Name = "textBoxNomeUtilizador";
            this.textBoxNomeUtilizador.Size = new System.Drawing.Size(225, 22);
            this.textBoxNomeUtilizador.TabIndex = 1;
            // 
            // textBoxNIFUtilizador
            // 
            this.textBoxNIFUtilizador.Location = new System.Drawing.Point(6, 109);
            this.textBoxNIFUtilizador.Name = "textBoxNIFUtilizador";
            this.textBoxNIFUtilizador.Size = new System.Drawing.Size(225, 22);
            this.textBoxNIFUtilizador.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nome Completo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Número Identificação Fiscal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Username:";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1048, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionario";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            this.groupBoxListaFuncionarios.PerformLayout();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.Button buttonApagarFuncionario;
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxUsernameFuncionario;
        private System.Windows.Forms.Button buttonGuardarFuncionario;
        private System.Windows.Forms.TextBox textBoxNomeUtilizador;
        private System.Windows.Forms.TextBox textBoxNIFUtilizador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}