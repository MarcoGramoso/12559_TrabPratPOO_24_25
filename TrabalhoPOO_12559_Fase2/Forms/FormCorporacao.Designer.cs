namespace TrabalhoPOO_12559_Fase2
{
    partial class FormCorporacao
    {
        private System.ComponentModel.IContainer components = null;

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
            label3 = new Label();
            listBoxCorpViaturas = new ListBox();
            labelBombeiros = new Label();
            listBoxCorpBombeiros = new ListBox();
            btnRemoverBombeiro = new Button();
            btnAdicionarBombeiro = new Button();
            btnRemViatCorp = new Button();
            btnAdicViatCorp = new Button();
            Sair = new Button();
            btnAddBomOcorr = new Button();
            AddViatOcor = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 199);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "Lista de Viaturas";
            // 
            // listBoxCorpViaturas
            // 
            listBoxCorpViaturas.FormattingEnabled = true;
            listBoxCorpViaturas.ItemHeight = 15;
            listBoxCorpViaturas.Location = new Point(8, 217);
            listBoxCorpViaturas.Margin = new Padding(4, 3, 4, 3);
            listBoxCorpViaturas.Name = "listBoxCorpViaturas";
            listBoxCorpViaturas.Size = new Size(822, 139);
            listBoxCorpViaturas.TabIndex = 6;
            // 
            // labelBombeiros
            // 
            labelBombeiros.AutoSize = true;
            labelBombeiros.Location = new Point(8, 6);
            labelBombeiros.Name = "labelBombeiros";
            labelBombeiros.Size = new Size(107, 15);
            labelBombeiros.TabIndex = 9;
            labelBombeiros.Text = "Lista de Bombeiros";
            // 
            // listBoxCorpBombeiros
            // 
            listBoxCorpBombeiros.FormattingEnabled = true;
            listBoxCorpBombeiros.ItemHeight = 15;
            listBoxCorpBombeiros.Location = new Point(8, 24);
            listBoxCorpBombeiros.Margin = new Padding(4, 3, 4, 3);
            listBoxCorpBombeiros.Name = "listBoxCorpBombeiros";
            listBoxCorpBombeiros.Size = new Size(822, 139);
            listBoxCorpBombeiros.TabIndex = 8;
            // 
            // btnRemoverBombeiro
            // 
            btnRemoverBombeiro.Location = new Point(251, 169);
            btnRemoverBombeiro.Margin = new Padding(4, 3, 4, 3);
            btnRemoverBombeiro.Name = "btnRemoverBombeiro";
            btnRemoverBombeiro.Size = new Size(140, 27);
            btnRemoverBombeiro.TabIndex = 13;
            btnRemoverBombeiro.Text = "Remover Bombeiro";
            btnRemoverBombeiro.UseVisualStyleBackColor = true;
            btnRemoverBombeiro.Click += btnRemoverBombeiro_Click;
            // 
            // btnAdicionarBombeiro
            // 
            btnAdicionarBombeiro.Location = new Point(8, 169);
            btnAdicionarBombeiro.Name = "btnAdicionarBombeiro";
            btnAdicionarBombeiro.Size = new Size(140, 27);
            btnAdicionarBombeiro.TabIndex = 12;
            btnAdicionarBombeiro.Text = "Adicionar Bombeiro";
            btnAdicionarBombeiro.UseVisualStyleBackColor = true;
            btnAdicionarBombeiro.Click += btnAdicionarBombeiro_Click;
            // 
            // btnRemViatCorp
            // 
            btnRemViatCorp.Location = new Point(251, 362);
            btnRemViatCorp.Margin = new Padding(4, 3, 4, 3);
            btnRemViatCorp.Name = "btnRemViatCorp";
            btnRemViatCorp.Size = new Size(140, 27);
            btnRemViatCorp.TabIndex = 15;
            btnRemViatCorp.Text = "Remover Viatura";
            btnRemViatCorp.UseVisualStyleBackColor = true;
            btnRemViatCorp.Click += btnRemViatCorp_Click;
            // 
            // btnAdicViatCorp
            // 
            btnAdicViatCorp.Location = new Point(8, 362);
            btnAdicViatCorp.Name = "btnAdicViatCorp";
            btnAdicViatCorp.Size = new Size(140, 27);
            btnAdicViatCorp.TabIndex = 14;
            btnAdicViatCorp.Text = "Adicionar Viatura";
            btnAdicViatCorp.UseVisualStyleBackColor = true;
            btnAdicViatCorp.Click += btnAdicionarViatura_Click;
            // 
            // Sair
            // 
            Sair.Location = new Point(755, 366);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 16;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            // 
            // btnAddBomOcorr
            // 
            btnAddBomOcorr.Location = new Point(470, 169);
            btnAddBomOcorr.Margin = new Padding(4, 3, 4, 3);
            btnAddBomOcorr.Name = "btnAddBomOcorr";
            btnAddBomOcorr.Size = new Size(140, 27);
            btnAddBomOcorr.TabIndex = 17;
            btnAddBomOcorr.Text = "Adicionar à Ocorrência";
            btnAddBomOcorr.UseVisualStyleBackColor = true;
            btnAddBomOcorr.Click += btnAddBomOcorr_Click;
            // 
            // AddViatOcor
            // 
            AddViatOcor.Location = new Point(470, 360);
            AddViatOcor.Margin = new Padding(4, 3, 4, 3);
            AddViatOcor.Name = "AddViatOcor";
            AddViatOcor.Size = new Size(140, 27);
            AddViatOcor.TabIndex = 18;
            AddViatOcor.Text = "Adicionar à Ocorrência";
            AddViatOcor.UseVisualStyleBackColor = true;
            AddViatOcor.Click += AddViatOcor_Click;
            // 
            // FormCorporacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 399);
            Controls.Add(AddViatOcor);
            Controls.Add(btnAddBomOcorr);
            Controls.Add(Sair);
            Controls.Add(btnRemViatCorp);
            Controls.Add(btnAdicViatCorp);
            Controls.Add(btnRemoverBombeiro);
            Controls.Add(btnAdicionarBombeiro);
            Controls.Add(labelBombeiros);
            Controls.Add(listBoxCorpBombeiros);
            Controls.Add(label3);
            Controls.Add(listBoxCorpViaturas);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCorporacao";
            Text = "Corporação de Bombeiros";
            Load += FormCorporacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label3;
        private ListBox listBoxCorpViaturas;
        private Label labelBombeiros;
        private ListBox listBoxCorpBombeiros;
        private Button btnRemoverBombeiro;
        private Button btnAdicionarBombeiro;
        private Button btnRemViatCorp;
        private Button btnAdicViatCorp;
        private Button Sair;
        private Button btnAddBomOcorr;
        private Button AddViatOcor;
    }
}
