namespace CSharp_AutoMapper
{
    partial class Form1
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
            this.btnCriarMapeamento = new System.Windows.Forms.Button();
            this.lbDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCriarMapeamento
            // 
            this.btnCriarMapeamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarMapeamento.Location = new System.Drawing.Point(24, 226);
            this.btnCriarMapeamento.Name = "btnCriarMapeamento";
            this.btnCriarMapeamento.Size = new System.Drawing.Size(334, 39);
            this.btnCriarMapeamento.TabIndex = 0;
            this.btnCriarMapeamento.Text = "Criar Mapeamento com AutoMapper";
            this.btnCriarMapeamento.UseVisualStyleBackColor = true;
            this.btnCriarMapeamento.Click += new System.EventHandler(this.btnCriarMapeamento_Click);
            // 
            // lbDados
            // 
            this.lbDados.FormattingEnabled = true;
            this.lbDados.Location = new System.Drawing.Point(24, 34);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(334, 186);
            this.lbDados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 293);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.btnCriarMapeamento);
            this.Name = "Form1";
            this.Text = "Usando AutoMapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarMapeamento;
        private System.Windows.Forms.ListBox lbDados;
    }
}

