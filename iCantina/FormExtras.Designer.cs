namespace iCantina
{
    partial class FormExtras
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonApagarExtra = new System.Windows.Forms.Button();
            this.buttonGuardarExtra = new System.Windows.Forms.Button();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPreco = new System.Windows.Forms.Label();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.tabControlExtras = new System.Windows.Forms.TabControl();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControlExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelQuantidade);
            this.tabPage1.Controls.Add(this.textBoxQuantidade);
            this.tabPage1.Controls.Add(this.buttonApagarExtra);
            this.tabPage1.Controls.Add(this.buttonGuardarExtra);
            this.tabPage1.Controls.Add(this.textBoxPreco);
            this.tabPage1.Controls.Add(this.textBoxDescricao);
            this.tabPage1.Controls.Add(this.comboBoxEstado);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LabelPreco);
            this.tabPage1.Controls.Add(this.LabelDescricao);
            this.tabPage1.Controls.Add(this.listBoxExtras);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extras";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonApagarExtra
            // 
            this.buttonApagarExtra.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarExtra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarExtra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarExtra.Location = new System.Drawing.Point(137, 221);
            this.buttonApagarExtra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarExtra.Name = "buttonApagarExtra";
            this.buttonApagarExtra.Size = new System.Drawing.Size(72, 32);
            this.buttonApagarExtra.TabIndex = 8;
            this.buttonApagarExtra.Text = "Apagar";
            this.buttonApagarExtra.UseVisualStyleBackColor = false;
            this.buttonApagarExtra.Click += new System.EventHandler(this.buttonApagarExtra_Click);
            // 
            // buttonGuardarExtra
            // 
            this.buttonGuardarExtra.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarExtra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarExtra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarExtra.Location = new System.Drawing.Point(13, 221);
            this.buttonGuardarExtra.Name = "buttonGuardarExtra";
            this.buttonGuardarExtra.Size = new System.Drawing.Size(72, 34);
            this.buttonGuardarExtra.TabIndex = 7;
            this.buttonGuardarExtra.Text = "Guardar";
            this.buttonGuardarExtra.UseVisualStyleBackColor = false;
            this.buttonGuardarExtra.Click += new System.EventHandler(this.buttonGuardarExtra_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(109, 53);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreco.TabIndex = 6;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(109, 21);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 5;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(109, 112);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "ESTADO :";
            // 
            // LabelPreco
            // 
            this.LabelPreco.AutoSize = true;
            this.LabelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreco.Location = new System.Drawing.Point(10, 57);
            this.LabelPreco.Name = "LabelPreco";
            this.LabelPreco.Size = new System.Drawing.Size(50, 12);
            this.LabelPreco.TabIndex = 2;
            this.LabelPreco.Text = "PREÇO :";
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescricao.Location = new System.Drawing.Point(11, 25);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(78, 12);
            this.LabelDescricao.TabIndex = 1;
            this.LabelDescricao.Text = "DESCRIÇÃO :";
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.Location = new System.Drawing.Point(215, 6);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(377, 199);
            this.listBoxExtras.TabIndex = 0;
            this.listBoxExtras.SelectedIndexChanged += new System.EventHandler(this.listBoxExtras_SelectedIndexChanged);
            // 
            // tabControlExtras
            // 
            this.tabControlExtras.Controls.Add(this.tabPage1);
            this.tabControlExtras.Location = new System.Drawing.Point(12, 12);
            this.tabControlExtras.Name = "tabControlExtras";
            this.tabControlExtras.SelectedIndex = 0;
            this.tabControlExtras.Size = new System.Drawing.Size(606, 308);
            this.tabControlExtras.TabIndex = 0;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(109, 82);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(10, 86);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(85, 12);
            this.labelQuantidade.TabIndex = 10;
            this.labelQuantidade.Text = "QUANTIDADE :";
            // 
            // FormExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 328);
            this.Controls.Add(this.tabControlExtras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormExtras";
            this.Text = "FormExtras";
            this.Load += new System.EventHandler(this.FormExtras_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlExtras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlExtras;
        private System.Windows.Forms.Label LabelPreco;
        private System.Windows.Forms.Label LabelDescricao;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button buttonGuardarExtra;
        private System.Windows.Forms.Button buttonApagarExtra;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textBoxQuantidade;
    }
}