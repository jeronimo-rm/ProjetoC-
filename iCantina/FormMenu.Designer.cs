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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.comboBoxExtras = new System.Windows.Forms.ComboBox();
            this.TextboxQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerdoMENU = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerHoraMENU = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPrecoEstudante = new System.Windows.Forms.Label();
            this.ListBoxMENU = new System.Windows.Forms.ListBox();
            this.labelPrecoProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxPrato
            // 
            this.ComboBoxPrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrato.FormattingEnabled = true;
            this.ComboBoxPrato.Location = new System.Drawing.Point(97, 28);
            this.ComboBoxPrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxPrato.Name = "ComboBoxPrato";
            this.ComboBoxPrato.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxPrato.TabIndex = 0;
            this.ComboBoxPrato.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prato:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(293, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(650, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo:";
            // 
            // ComboBoxTipo
            // 
            this.ComboBoxTipo.Enabled = false;
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Location = new System.Drawing.Point(97, 93);
            this.ComboBoxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxTipo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(96, 123);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPreco.Multiline = true;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(92, 24);
            this.textBoxPreco.TabIndex = 15;
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.Location = new System.Drawing.Point(97, 58);
            this.comboBoxExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(92, 21);
            this.comboBoxExtras.TabIndex = 16;
            // 
            // TextboxQuantidade
            // 
            this.TextboxQuantidade.Location = new System.Drawing.Point(97, 199);
            this.TextboxQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxQuantidade.Multiline = true;
            this.TextboxQuantidade.Name = "TextboxQuantidade";
            this.TextboxQuantidade.Size = new System.Drawing.Size(92, 27);
            this.TextboxQuantidade.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantidade:";
            // 
            // dateTimePickerdoMENU
            // 
            this.dateTimePickerdoMENU.Location = new System.Drawing.Point(97, 257);
            this.dateTimePickerdoMENU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerdoMENU.Name = "dateTimePickerdoMENU";
            this.dateTimePickerdoMENU.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerdoMENU.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hora:";
            // 
            // dateTimePickerHoraMENU
            // 
            this.dateTimePickerHoraMENU.CustomFormat = "HH:mm";
            this.dateTimePickerHoraMENU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraMENU.Location = new System.Drawing.Point(97, 304);
            this.dateTimePickerHoraMENU.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerHoraMENU.MaxDate = new System.DateTime(2023, 6, 4, 22, 0, 0, 0);
            this.dateTimePickerHoraMENU.MinDate = new System.DateTime(2023, 6, 4, 10, 0, 0, 0);
            this.dateTimePickerHoraMENU.Name = "dateTimePickerHoraMENU";
            this.dateTimePickerHoraMENU.ShowUpDown = true;
            this.dateTimePickerHoraMENU.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerHoraMENU.TabIndex = 21;
            this.dateTimePickerHoraMENU.Value = new System.DateTime(2023, 6, 4, 10, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "€";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Preço Estudante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Preço Professor:";
            // 
            // labelPrecoEstudante
            // 
            this.labelPrecoEstudante.AutoSize = true;
            this.labelPrecoEstudante.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoEstudante.Location = new System.Drawing.Point(128, 153);
            this.labelPrecoEstudante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoEstudante.Name = "labelPrecoEstudante";
            this.labelPrecoEstudante.Size = new System.Drawing.Size(0, 15);
            this.labelPrecoEstudante.TabIndex = 26;
            // 
            // ListBoxMENU
            // 
            this.ListBoxMENU.FormattingEnabled = true;
            this.ListBoxMENU.Location = new System.Drawing.Point(293, 17);
            this.ListBoxMENU.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxMENU.Name = "ListBoxMENU";
            this.ListBoxMENU.Size = new System.Drawing.Size(427, 264);
            this.ListBoxMENU.TabIndex = 6;
            this.ListBoxMENU.SelectedIndexChanged += new System.EventHandler(this.ListBoxMENU_SelectedIndexChanged);
            // 
            // labelPrecoProf
            // 
            this.labelPrecoProf.AutoSize = true;
            this.labelPrecoProf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoProf.Location = new System.Drawing.Point(128, 173);
            this.labelPrecoProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoProf.Name = "labelPrecoProf";
            this.labelPrecoProf.Size = new System.Drawing.Size(0, 15);
            this.labelPrecoProf.TabIndex = 27;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(728, 351);
            this.Controls.Add(this.labelPrecoProf);
            this.Controls.Add(this.labelPrecoEstudante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerHoraMENU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerdoMENU);
            this.Controls.Add(this.TextboxQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxExtras);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxMENU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxPrato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.ComboBox comboBoxExtras;
        private System.Windows.Forms.TextBox TextboxQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerdoMENU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraMENU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPrecoEstudante;
        private System.Windows.Forms.ListBox ListBoxMENU;
        private System.Windows.Forms.Label labelPrecoProf;
    }
}