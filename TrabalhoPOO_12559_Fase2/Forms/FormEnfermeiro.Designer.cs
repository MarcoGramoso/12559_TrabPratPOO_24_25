namespace TrabalhoPOO_12559_Fase2
{
    partial class FormEnfermeiro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionarEnfermeiro;
        private System.Windows.Forms.Button btnRemoverEnfermeiro;
        private System.Windows.Forms.TextBox txtNomeEnfermeiro;
        private System.Windows.Forms.DateTimePicker dtpDataNascEnfermeiro;
        private System.Windows.Forms.ListBox listBoxEnfermeiros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAdicionarEnfermeiro = new Button();
            btnRemoverEnfermeiro = new Button();
            txtNomeEnfermeiro = new TextBox();
            dtpDataNascEnfermeiro = new DateTimePicker();
            listBoxEnfermeiros = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnAdicionarAoINEM = new Button();
            Sair = new Button();
            SuspendLayout();
            // 
            // btnAdicionarEnfermeiro
            // 
            btnAdicionarEnfermeiro.Location = new Point(566, 8);
            btnAdicionarEnfermeiro.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarEnfermeiro.Name = "btnAdicionarEnfermeiro";
            btnAdicionarEnfermeiro.Size = new Size(140, 27);
            btnAdicionarEnfermeiro.TabIndex = 0;
            btnAdicionarEnfermeiro.Text = "Adicionar Enfermeiro";
            btnAdicionarEnfermeiro.UseVisualStyleBackColor = true;
            btnAdicionarEnfermeiro.Click += btnAdicionarEnfermeiro_Click;
            // 
            // btnRemoverEnfermeiro
            // 
            btnRemoverEnfermeiro.Location = new Point(566, 43);
            btnRemoverEnfermeiro.Margin = new Padding(4, 3, 4, 3);
            btnRemoverEnfermeiro.Name = "btnRemoverEnfermeiro";
            btnRemoverEnfermeiro.Size = new Size(140, 27);
            btnRemoverEnfermeiro.TabIndex = 1;
            btnRemoverEnfermeiro.Text = "Remover Enfermeiro";
            btnRemoverEnfermeiro.UseVisualStyleBackColor = true;
            btnRemoverEnfermeiro.Click += btnRemoverEnfermeiro_Click;
            // 
            // txtNomeEnfermeiro
            // 
            txtNomeEnfermeiro.Location = new Point(127, 12);
            txtNomeEnfermeiro.Margin = new Padding(4, 3, 4, 3);
            txtNomeEnfermeiro.Name = "txtNomeEnfermeiro";
            txtNomeEnfermeiro.Size = new Size(276, 23);
            txtNomeEnfermeiro.TabIndex = 3;
            // 
            // dtpDataNascEnfermeiro
            // 
            dtpDataNascEnfermeiro.Location = new Point(127, 47);
            dtpDataNascEnfermeiro.Margin = new Padding(4, 3, 4, 3);
            dtpDataNascEnfermeiro.Name = "dtpDataNascEnfermeiro";
            dtpDataNascEnfermeiro.Size = new Size(276, 23);
            dtpDataNascEnfermeiro.TabIndex = 4;
            // 
            // listBoxEnfermeiros
            // 
            listBoxEnfermeiros.FormattingEnabled = true;
            listBoxEnfermeiros.ItemHeight = 15;
            listBoxEnfermeiros.Location = new Point(14, 86);
            listBoxEnfermeiros.Margin = new Padding(4, 3, 4, 3);
            listBoxEnfermeiros.Name = "listBoxEnfermeiros";
            listBoxEnfermeiros.Size = new Size(692, 169);
            listBoxEnfermeiros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 6;
            label1.Text = "Data de Nascimento\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // btnAdicionarAoINEM
            // 
            btnAdicionarAoINEM.Location = new Point(14, 284);
            btnAdicionarAoINEM.Name = "btnAdicionarAoINEM";
            btnAdicionarAoINEM.Size = new Size(140, 27);
            btnAdicionarAoINEM.TabIndex = 8;
            btnAdicionarAoINEM.Text = "Adicionar ao INEM";
            btnAdicionarAoINEM.UseVisualStyleBackColor = true;
            btnAdicionarAoINEM.Click += btnAdicionarAoINEM_Click;
            // 
            // Sair
            // 
            Sair.Location = new Point(631, 286);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 9;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // FormEnfermeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 444);
            Controls.Add(Sair);
            Controls.Add(btnAdicionarAoINEM);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxEnfermeiros);
            Controls.Add(dtpDataNascEnfermeiro);
            Controls.Add(txtNomeEnfermeiro);
            Controls.Add(btnRemoverEnfermeiro);
            Controls.Add(btnAdicionarEnfermeiro);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEnfermeiro";
            Text = "Gerir Enfermeiros";
            Load += FormEnfermeiro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnAdicionarAoINEM;
        private Button Sair;
    }
}