namespace TrabalhoPOO_12559_Fase2
{
    partial class FormBombeiro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.ListBox listBoxBombeiros;

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
            btnAdicionar = new Button();
            btnRemover = new Button();
            txtNome = new TextBox();
            dtpDataNasc = new DateTimePicker();
            listBoxBombeiros = new ListBox();
            label1 = new Label();
            label2 = new Label();
            Sair = new Button();
            btnAdicionarACorpBomb = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(556, 15);
            btnAdicionar.Margin = new Padding(4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(88, 26);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(556, 44);
            btnRemover.Margin = new Padding(4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(88, 26);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 13);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 3;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(138, 49);
            dtpDataNasc.Margin = new Padding(4);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(276, 23);
            dtpDataNasc.TabIndex = 4;
            // 
            // listBoxBombeiros
            // 
            listBoxBombeiros.FormattingEnabled = true;
            listBoxBombeiros.ItemHeight = 15;
            listBoxBombeiros.Location = new Point(14, 114);
            listBoxBombeiros.Margin = new Padding(4);
            listBoxBombeiros.Name = "listBoxBombeiros";
            listBoxBombeiros.Size = new Size(630, 154);
            listBoxBombeiros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "Data de Nascimento:";
            // 
            // Sair
            // 
            Sair.Location = new Point(569, 291);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 9;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // btnAdicionarACorpBomb
            // 
            btnAdicionarACorpBomb.Location = new Point(12, 291);
            btnAdicionarACorpBomb.Name = "btnAdicionarACorpBomb";
            btnAdicionarACorpBomb.Size = new Size(186, 27);
            btnAdicionarACorpBomb.TabIndex = 10;
            btnAdicionarACorpBomb.Text = "Adicionar a Corp. Bombeiros";
            btnAdicionarACorpBomb.UseVisualStyleBackColor = true;
            btnAdicionarACorpBomb.Click += btnAdicionarACorpBomb_Click;
            // 
            // FormBombeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 347);
            Controls.Add(btnAdicionarACorpBomb);
            Controls.Add(Sair);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBombeiros);
            Controls.Add(dtpDataNasc);
            Controls.Add(txtNome);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Margin = new Padding(4);
            Name = "FormBombeiro";
            Text = "Bombeiro";
            Load += FormBombeiro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Button Sair;
        private Button btnAdicionarACorpBomb;
    }
}

