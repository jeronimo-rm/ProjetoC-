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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Apagar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textboxhoras = new System.Windows.Forms.TextBox();
            this.textboxValor = new System.Windows.Forms.TextBox();
            this.ListboxMulta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(273, 40);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(75, 23);
            this.Apagar.TabIndex = 2;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Criar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textboxhoras
            // 
            this.textboxhoras.Location = new System.Drawing.Point(90, 40);
            this.textboxhoras.Name = "textboxhoras";
            this.textboxhoras.Size = new System.Drawing.Size(100, 20);
            this.textboxhoras.TabIndex = 4;
            // 
            // textboxValor
            // 
            this.textboxValor.Location = new System.Drawing.Point(90, 94);
            this.textboxValor.Name = "textboxValor";
            this.textboxValor.Size = new System.Drawing.Size(100, 20);
            this.textboxValor.TabIndex = 5;
            // 
            // ListboxMulta
            // 
            this.ListboxMulta.FormattingEnabled = true;
            this.ListboxMulta.Location = new System.Drawing.Point(241, 80);
            this.ListboxMulta.Name = "ListboxMulta";
            this.ListboxMulta.Size = new System.Drawing.Size(226, 212);
            this.ListboxMulta.TabIndex = 7;
            this.ListboxMulta.SelectedIndexChanged += new System.EventHandler(this.ListboxMulta_SelectedIndexChanged);
            // 
            // FormMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ListboxMulta);
            this.Controls.Add(this.textboxValor);
            this.Controls.Add(this.textboxhoras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMulta";
            this.Text = "FormMulta";
            this.Load += new System.EventHandler(this.FormMulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textboxhoras;
        private System.Windows.Forms.TextBox textboxValor;
        private System.Windows.Forms.ListBox ListboxMulta;
    }
}