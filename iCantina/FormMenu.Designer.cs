namespace iCantina
{
    partial class FormMenu
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
            this.ComboBoxPrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListBoxMENU = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.comboBoExtras = new System.Windows.Forms.ComboBox();
            this.TextboxQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerdoMENU = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerHoraMENU = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ComboBoxPrato
            // 
            this.ComboBoxPrato.FormattingEnabled = true;
            this.ComboBoxPrato.Location = new System.Drawing.Point(177, 45);
            this.ComboBoxPrato.Name = "ComboBoxPrato";
            this.ComboBoxPrato.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxPrato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prato";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListBoxMENU
            // 
            this.ListBoxMENU.FormattingEnabled = true;
            this.ListBoxMENU.ItemHeight = 16;
            this.ListBoxMENU.Location = new System.Drawing.Point(503, 45);
            this.ListBoxMENU.Name = "ListBoxMENU";
            this.ListBoxMENU.Size = new System.Drawing.Size(346, 244);
            this.ListBoxMENU.TabIndex = 6;
            this.ListBoxMENU.SelectedIndexChanged += new System.EventHandler(this.ListBoxMENU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(177, 114);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(177, 157);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstado.TabIndex = 13;
            this.comboBoxEstado.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(177, 196);
            this.textBoxPreco.Multiline = true;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(121, 32);
            this.textBoxPreco.TabIndex = 15;
            // 
            // comboBoExtras
            // 
            this.comboBoExtras.FormattingEnabled = true;
            this.comboBoExtras.Location = new System.Drawing.Point(177, 75);
            this.comboBoExtras.Name = "comboBoExtras";
            this.comboBoExtras.Size = new System.Drawing.Size(121, 24);
            this.comboBoExtras.TabIndex = 16;
            // 
            // TextboxQuantidade
            // 
            this.TextboxQuantidade.Location = new System.Drawing.Point(177, 245);
            this.TextboxQuantidade.Multiline = true;
            this.TextboxQuantidade.Name = "TextboxQuantidade";
            this.TextboxQuantidade.Size = new System.Drawing.Size(121, 32);
            this.TextboxQuantidade.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantidade";
            // 
            // dateTimePickerdoMENU
            // 
            this.dateTimePickerdoMENU.Location = new System.Drawing.Point(177, 316);
            this.dateTimePickerdoMENU.Name = "dateTimePickerdoMENU";
            this.dateTimePickerdoMENU.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdoMENU.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hora";
            // 
            // dateTimePickerHoraMENU
            // 
            this.dateTimePickerHoraMENU.CustomFormat = "HH:mm";
            this.dateTimePickerHoraMENU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraMENU.Location = new System.Drawing.Point(177, 374);
            this.dateTimePickerHoraMENU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerHoraMENU.MaxDate = new System.DateTime(2023, 6, 4, 22, 0, 0, 0);
            this.dateTimePickerHoraMENU.MinDate = new System.DateTime(2023, 6, 4, 10, 0, 0, 0);
            this.dateTimePickerHoraMENU.Name = "dateTimePickerHoraMENU";
            this.dateTimePickerHoraMENU.ShowUpDown = true;
            this.dateTimePickerHoraMENU.Size = new System.Drawing.Size(144, 22);
            this.dateTimePickerHoraMENU.TabIndex = 21;
            this.dateTimePickerHoraMENU.Value = new System.DateTime(2023, 6, 4, 10, 0, 0, 0);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 569);
            this.Controls.Add(this.dateTimePickerHoraMENU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerdoMENU);
            this.Controls.Add(this.TextboxQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoExtras);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxMENU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxPrato);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListBoxMENU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.ComboBox comboBoExtras;
        private System.Windows.Forms.TextBox TextboxQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerdoMENU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraMENU;
    }
}