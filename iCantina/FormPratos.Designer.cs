namespace iCantina
{
    partial class FormPratos
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
            this.buttonApagarPrato = new System.Windows.Forms.Button();
            this.labelPrato = new System.Windows.Forms.Label();
            this.listBoxPratos = new System.Windows.Forms.ListBox();
            this.buttonGuardarPrato = new System.Windows.Forms.Button();
            this.textBoxDescricaoPrato = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoPrato = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipoPrato = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarPrato);
            this.tabPage1.Controls.Add(this.labelPrato);
            this.tabPage1.Controls.Add(this.listBoxPratos);
            this.tabPage1.Controls.Add(this.buttonGuardarPrato);
            this.tabPage1.Controls.Add(this.textBoxDescricaoPrato);
            this.tabPage1.Controls.Add(this.comboBoxEstadoPrato);
            this.tabPage1.Controls.Add(this.labelTipo);
            this.tabPage1.Controls.Add(this.comboBoxTipoPrato);
            this.tabPage1.Controls.Add(this.labelEstado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(911, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pratos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonApagarPrato
            // 
            this.buttonApagarPrato.BackColor = System.Drawing.Color.Brown;
            this.buttonApagarPrato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarPrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagarPrato.Location = new System.Drawing.Point(136, 324);
            this.buttonApagarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarPrato.Name = "buttonApagarPrato";
            this.buttonApagarPrato.Size = new System.Drawing.Size(88, 32);
            this.buttonApagarPrato.TabIndex = 5;
            this.buttonApagarPrato.Text = "Apagar";
            this.buttonApagarPrato.UseVisualStyleBackColor = false;
            this.buttonApagarPrato.Click += new System.EventHandler(this.buttonApagarPrato_Click);
            // 
            // labelPrato
            // 
            this.labelPrato.AutoSize = true;
            this.labelPrato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrato.Location = new System.Drawing.Point(9, 27);
            this.labelPrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrato.Name = "labelPrato";
            this.labelPrato.Size = new System.Drawing.Size(47, 12);
            this.labelPrato.TabIndex = 13;
            this.labelPrato.Text = "PRATO:";
            // 
            // listBoxPratos
            // 
            this.listBoxPratos.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPratos.FormattingEnabled = true;
            this.listBoxPratos.HorizontalScrollbar = true;
            this.listBoxPratos.ItemHeight = 16;
            this.listBoxPratos.Location = new System.Drawing.Point(238, 17);
            this.listBoxPratos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxPratos.Name = "listBoxPratos";
            this.listBoxPratos.Size = new System.Drawing.Size(662, 324);
            this.listBoxPratos.TabIndex = 6;
            this.listBoxPratos.SelectedIndexChanged += new System.EventHandler(this.listBoxPratos_SelectedIndexChanged);
            // 
            // buttonGuardarPrato
            // 
            this.buttonGuardarPrato.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarPrato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarPrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarPrato.Location = new System.Drawing.Point(11, 324);
            this.buttonGuardarPrato.Name = "buttonGuardarPrato";
            this.buttonGuardarPrato.Size = new System.Drawing.Size(88, 34);
            this.buttonGuardarPrato.TabIndex = 4;
            this.buttonGuardarPrato.Text = "Guardar";
            this.buttonGuardarPrato.UseVisualStyleBackColor = false;
            this.buttonGuardarPrato.Click += new System.EventHandler(this.buttonGuardarPrato_Click);
            // 
            // textBoxDescricaoPrato
            // 
            this.textBoxDescricaoPrato.Location = new System.Drawing.Point(84, 27);
            this.textBoxDescricaoPrato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDescricaoPrato.Multiline = true;
            this.textBoxDescricaoPrato.Name = "textBoxDescricaoPrato";
            this.textBoxDescricaoPrato.Size = new System.Drawing.Size(125, 83);
            this.textBoxDescricaoPrato.TabIndex = 0;
            // 
            // comboBoxEstadoPrato
            // 
            this.comboBoxEstadoPrato.FormattingEnabled = true;
            this.comboBoxEstadoPrato.Items.AddRange(new object[] {
            "Desativado",
            "Ativado"});
            this.comboBoxEstadoPrato.Location = new System.Drawing.Point(84, 164);
            this.comboBoxEstadoPrato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxEstadoPrato.Name = "comboBoxEstadoPrato";
            this.comboBoxEstadoPrato.Size = new System.Drawing.Size(77, 21);
            this.comboBoxEstadoPrato.TabIndex = 2;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(9, 126);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(34, 12);
            this.labelTipo.TabIndex = 14;
            this.labelTipo.Text = "TIPO:";
            // 
            // comboBoxTipoPrato
            // 
            this.comboBoxTipoPrato.FormattingEnabled = true;
            this.comboBoxTipoPrato.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.comboBoxTipoPrato.Location = new System.Drawing.Point(84, 123);
            this.comboBoxTipoPrato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTipoPrato.Name = "comboBoxTipoPrato";
            this.comboBoxTipoPrato.Size = new System.Drawing.Size(77, 21);
            this.comboBoxTipoPrato.TabIndex = 1;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(9, 171);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(54, 12);
            this.labelEstado.TabIndex = 15;
            this.labelEstado.Text = "ESTADO:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(28, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 400);
            this.tabControl1.TabIndex = 22;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // FormPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(956, 432);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPratos";
            this.Text = "FormPratos";
            this.Load += new System.EventHandler(this.FormPratos_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonApagarPrato;
        private System.Windows.Forms.Label labelPrato;
        private System.Windows.Forms.ListBox listBoxPratos;
        private System.Windows.Forms.Button buttonGuardarPrato;
        private System.Windows.Forms.TextBox textBoxDescricaoPrato;
        private System.Windows.Forms.ComboBox comboBoxEstadoPrato;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBoxTipoPrato;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}