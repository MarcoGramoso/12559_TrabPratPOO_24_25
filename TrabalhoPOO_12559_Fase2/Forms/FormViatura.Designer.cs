namespace TrabalhoPOO_12559_Fase2
{
    partial class FormViatura
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionarViatura;
        private System.Windows.Forms.Button btnRemoverViatura;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox comboBoxTipoEquipamento;
        private System.Windows.Forms.ListBox listBoxViaturas;

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
            btnAdicionarViatura = new Button();
            btnRemoverViatura = new Button();
            txtMatricula = new TextBox();
            comboBoxTipoEquipamento = new ComboBox();
            listBoxViaturas = new ListBox();
            labelMatricula = new Label();
            labelTipoViat = new Label();
            Sair = new Button();
            btnAdicionarAoINEM = new Button();
            btnAdicViatBomb = new Button();
            SuspendLayout();
            // 
            // btnAdicionarViatura
            // 
            btnAdicionarViatura.Location = new Point(553, 15);
            btnAdicionarViatura.Name = "btnAdicionarViatura";
            btnAdicionarViatura.Size = new Size(120, 23);
            btnAdicionarViatura.TabIndex = 0;
            btnAdicionarViatura.Text = "Adicionar Viatura";
            btnAdicionarViatura.UseVisualStyleBackColor = true;
            btnAdicionarViatura.Click += btnAdicionarViatura_Click;
            // 
            // btnRemoverViatura
            // 
            btnRemoverViatura.Location = new Point(553, 44);
            btnRemoverViatura.Name = "btnRemoverViatura";
            btnRemoverViatura.Size = new Size(120, 23);
            btnRemoverViatura.TabIndex = 1;
            btnRemoverViatura.Text = "Remover Viatura";
            btnRemoverViatura.UseVisualStyleBackColor = true;
            btnRemoverViatura.Click += btnRemoverViatura_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(104, 12);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(328, 23);
            txtMatricula.TabIndex = 3;
            // 
            // comboBoxTipoEquipamento
            // 
            comboBoxTipoEquipamento.FormattingEnabled = true;
            comboBoxTipoEquipamento.Location = new Point(104, 41);
            comboBoxTipoEquipamento.Name = "comboBoxTipoEquipamento";
            comboBoxTipoEquipamento.Size = new Size(328, 23);
            comboBoxTipoEquipamento.TabIndex = 4;
            // 
            // listBoxViaturas
            // 
            listBoxViaturas.FormattingEnabled = true;
            listBoxViaturas.ItemHeight = 15;
            listBoxViaturas.Location = new Point(12, 82);
            listBoxViaturas.Name = "listBoxViaturas";
            listBoxViaturas.Size = new Size(661, 199);
            listBoxViaturas.TabIndex = 5;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(12, 15);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(57, 15);
            labelMatricula.TabIndex = 6;
            labelMatricula.Text = "Matricula";
            // 
            // labelTipoViat
            // 
            labelTipoViat.AutoSize = true;
            labelTipoViat.Location = new Point(12, 44);
            labelTipoViat.Name = "labelTipoViat";
            labelTipoViat.Size = new Size(86, 15);
            labelTipoViat.TabIndex = 7;
            labelTipoViat.Text = "Tipo de Viatura";
            // 
            // Sair
            // 
            Sair.Location = new Point(598, 304);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 9;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // btnAdicionarAoINEM
            // 
            btnAdicionarAoINEM.Location = new Point(12, 302);
            btnAdicionarAoINEM.Name = "btnAdicionarAoINEM";
            btnAdicionarAoINEM.Size = new Size(140, 27);
            btnAdicionarAoINEM.TabIndex = 10;
            btnAdicionarAoINEM.Text = "Adicionar ao INEM";
            btnAdicionarAoINEM.UseVisualStyleBackColor = true;
            btnAdicionarAoINEM.Click += btnAdicionarAoINEM_Click;
            // 
            // btnAdicViatBomb
            // 
            btnAdicViatBomb.Location = new Point(283, 302);
            btnAdicViatBomb.Name = "btnAdicViatBomb";
            btnAdicViatBomb.Size = new Size(173, 27);
            btnAdicViatBomb.TabIndex = 11;
            btnAdicViatBomb.Text = "Adicionar a Corp. Bombeiros";
            btnAdicViatBomb.UseVisualStyleBackColor = true;
            // 
            // FormViatura
            // 
            ClientSize = new Size(687, 344);
            Controls.Add(btnAdicViatBomb);
            Controls.Add(btnAdicionarAoINEM);
            Controls.Add(Sair);
            Controls.Add(labelTipoViat);
            Controls.Add(labelMatricula);
            Controls.Add(listBoxViaturas);
            Controls.Add(comboBoxTipoEquipamento);
            Controls.Add(txtMatricula);
            Controls.Add(btnRemoverViatura);
            Controls.Add(btnAdicionarViatura);
            Name = "FormViatura";
            Text = "Gerenciar Viaturas";
            Load += FormViatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelMatricula;
        private Label labelTipoViat;
        private Button Sair;
        private Button btnAdicionarAoINEM;
        private Button btnAdicViatBomb;
    }
}
