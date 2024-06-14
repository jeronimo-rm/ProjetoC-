namespace iCantina
{
    partial class FormMulta
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
            this.ListBoxMulta = new System.Windows.Forms.ListBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.dateTimePickerMulta = new System.Windows.Forms.DateTimePicker();
            this.labelHoraSessoes = new System.Windows.Forms.Label();
            this.labelPrecoSessoes = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ListBoxMulta);
            this.tabPage1.Controls.Add(this.buttonApagar);
            this.tabPage1.Controls.Add(this.buttonCriar);
            this.tabPage1.Controls.Add(this.dateTimePickerMulta);
            this.tabPage1.Controls.Add(this.labelHoraSessoes);
            this.tabPage1.Controls.Add(this.labelPrecoSessoes);
            this.tabPage1.Controls.Add(this.textBoxValor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Multa";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ListBoxMulta
            // 
            this.ListBoxMulta.FormattingEnabled = true;
            this.ListBoxMulta.ItemHeight = 16;
            this.ListBoxMulta.Location = new System.Drawing.Point(311, 34);
            this.ListBoxMulta.Name = "ListBoxMulta";
            this.ListBoxMulta.Size = new System.Drawing.Size(507, 356);
            this.ListBoxMulta.TabIndex = 22;
            this.ListBoxMulta.SelectedIndexChanged += new System.EventHandler(this.ListBoxMulta_SelectedIndexChanged);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Brown;
            this.buttonApagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApagar.Location = new System.Drawing.Point(157, 345);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(106, 45);
            this.buttonApagar.TabIndex = 21;
            this.buttonApagar.Text = "APAGAR";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCriar
            // 
            this.buttonCriar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCriar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCriar.Location = new System.Drawing.Point(26, 345);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(106, 45);
            this.buttonCriar.TabIndex = 20;
            this.buttonCriar.Text = "CRIAR";
            this.buttonCriar.UseVisualStyleBackColor = false;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // dateTimePickerMulta
            // 
            this.dateTimePickerMulta.CustomFormat = "HH:mm";
            this.dateTimePickerMulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMulta.Location = new System.Drawing.Point(20, 54);
            this.dateTimePickerMulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerMulta.MaxDate = new System.DateTime(2024, 6, 14, 22, 0, 0, 0);
            this.dateTimePickerMulta.MinDate = new System.DateTime(2023, 6, 14, 10, 0, 0, 0);
            this.dateTimePickerMulta.Name = "dateTimePickerMulta";
            this.dateTimePickerMulta.ShowUpDown = true;
            this.dateTimePickerMulta.Size = new System.Drawing.Size(144, 22);
            this.dateTimePickerMulta.TabIndex = 17;
            this.dateTimePickerMulta.Value = new System.DateTime(2023, 6, 14, 10, 0, 0, 0);
            // 
            // labelHoraSessoes
            // 
            this.labelHoraSessoes.AutoSize = true;
            this.labelHoraSessoes.Location = new System.Drawing.Point(17, 34);
            this.labelHoraSessoes.Name = "labelHoraSessoes";
            this.labelHoraSessoes.Size = new System.Drawing.Size(40, 16);
            this.labelHoraSessoes.TabIndex = 16;
            this.labelHoraSessoes.Text = "Hora:";
            // 
            // labelPrecoSessoes
            // 
            this.labelPrecoSessoes.AutoSize = true;
            this.labelPrecoSessoes.Location = new System.Drawing.Point(17, 141);
            this.labelPrecoSessoes.Name = "labelPrecoSessoes";
            this.labelPrecoSessoes.Size = new System.Drawing.Size(42, 16);
            this.labelPrecoSessoes.TabIndex = 19;
            this.labelPrecoSessoes.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(20, 161);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(144, 22);
            this.textBoxValor.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 434);
            this.tabControl1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "€";
            // 
            // FormMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(890, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMulta";
            this.Text = "FormMulta";
            this.Load += new System.EventHandler(this.FormMulta_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox ListBoxMulta;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.DateTimePicker dateTimePickerMulta;
        private System.Windows.Forms.Label labelHoraSessoes;
        private System.Windows.Forms.Label labelPrecoSessoes;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
    }
}