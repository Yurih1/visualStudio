
namespace ConvertDolar
{
    partial class frnConvert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDiaDolar = new System.Windows.Forms.TextBox();
            this.txtQuantDolar = new System.Windows.Forms.TextBox();
            this.btnConversao = new System.Windows.Forms.Button();
            this.lblDolarDia = new System.Windows.Forms.Label();
            this.lblQuantidadeDolar = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiaDolar
            // 
            this.txtDiaDolar.Location = new System.Drawing.Point(321, 88);
            this.txtDiaDolar.Name = "txtDiaDolar";
            this.txtDiaDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDiaDolar.TabIndex = 0;
            // 
            // txtQuantDolar
            // 
            this.txtQuantDolar.Location = new System.Drawing.Point(321, 140);
            this.txtQuantDolar.Name = "txtQuantDolar";
            this.txtQuantDolar.Size = new System.Drawing.Size(100, 23);
            this.txtQuantDolar.TabIndex = 1;
            // 
            // btnConversao
            // 
            this.btnConversao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConversao.Location = new System.Drawing.Point(187, 219);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(128, 44);
            this.btnConversao.TabIndex = 2;
            this.btnConversao.Text = "Conversão";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // lblDolarDia
            // 
            this.lblDolarDia.AutoSize = true;
            this.lblDolarDia.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDolarDia.Location = new System.Drawing.Point(68, 93);
            this.lblDolarDia.Name = "lblDolarDia";
            this.lblDolarDia.Size = new System.Drawing.Size(247, 18);
            this.lblDolarDia.TabIndex = 3;
            this.lblDolarDia.Text = "Informe o valor do dolar do dia:";
            // 
            // lblQuantidadeDolar
            // 
            this.lblQuantidadeDolar.AutoSize = true;
            this.lblQuantidadeDolar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeDolar.Location = new System.Drawing.Point(65, 145);
            this.lblQuantidadeDolar.Name = "lblQuantidadeDolar";
            this.lblQuantidadeDolar.Size = new System.Drawing.Size(250, 18);
            this.lblQuantidadeDolar.TabIndex = 4;
            this.lblQuantidadeDolar.Text = "informe o valor para conversão:";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(-527, 148);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(0, 15);
            this.lblResultado2.TabIndex = 6;
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Location = new System.Drawing.Point(181, 317);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(0, 15);
            this.lblResultado3.TabIndex = 7;
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.Location = new System.Drawing.Point(321, 219);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(128, 43);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frnConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblResultado3);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblQuantidadeDolar);
            this.Controls.Add(this.lblDolarDia);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.txtQuantDolar);
            this.Controls.Add(this.txtDiaDolar);
            this.Name = "frnConvert";
            this.Text = "Converter Dolar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaDolar;
        private System.Windows.Forms.TextBox txtQuantDolar;
        private System.Windows.Forms.Button btnConversao;
        private System.Windows.Forms.Label lblDolarDia;
        private System.Windows.Forms.Label lblQuantidadeDolar;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultado3;
        private System.Windows.Forms.Button btnApagar;
    }
}

