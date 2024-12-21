namespace TrabalhoPOO_12559_Fase2
{
    partial class FormINEM
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxINEMMedicos;

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
            listBoxINEMMedicos = new ListBox();
            listBoxINEMEnfermeiros = new ListBox();
            listBoxINEMViaturas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdicionarMedico = new Button();
            btnRemoverMedico = new Button();
            btnRemEnfermeiro = new Button();
            btnAddEnfermeiro = new Button();
            btnRemViatura = new Button();
            btnAddViatura = new Button();
            Sair = new Button();
            AddMedOcor = new Button();
            AddEnfOcor = new Button();
            AddViatOcor = new Button();
            SuspendLayout();
            // 
            // listBoxINEMMedicos
            // 
            listBoxINEMMedicos.FormattingEnabled = true;
            listBoxINEMMedicos.ItemHeight = 15;
            listBoxINEMMedicos.Location = new Point(13, 26);
            listBoxINEMMedicos.Margin = new Padding(4, 3, 4, 3);
            listBoxINEMMedicos.Name = "listBoxINEMMedicos";
            listBoxINEMMedicos.Size = new Size(383, 109);
            listBoxINEMMedicos.TabIndex = 0;
            // 
            // listBoxINEMEnfermeiros
            // 
            listBoxINEMEnfermeiros.FormattingEnabled = true;
            listBoxINEMEnfermeiros.ItemHeight = 15;
            listBoxINEMEnfermeiros.Location = new Point(447, 26);
            listBoxINEMEnfermeiros.Margin = new Padding(4, 3, 4, 3);
            listBoxINEMEnfermeiros.Name = "listBoxINEMEnfermeiros";
            listBoxINEMEnfermeiros.Size = new Size(383, 109);
            listBoxINEMEnfermeiros.TabIndex = 1;
            // 
            // listBoxINEMViaturas
            // 
            listBoxINEMViaturas.FormattingEnabled = true;
            listBoxINEMViaturas.ItemHeight = 15;
            listBoxINEMViaturas.Location = new Point(13, 192);
            listBoxINEMViaturas.Margin = new Padding(4, 3, 4, 3);
            listBoxINEMViaturas.Name = "listBoxINEMViaturas";
            listBoxINEMViaturas.Size = new Size(383, 139);
            listBoxINEMViaturas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de Médicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 8);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Lista de Enfermeiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 174);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Lista de Viaturas";
            // 
            // btnAdicionarMedico
            // 
            btnAdicionarMedico.Location = new Point(13, 141);
            btnAdicionarMedico.Name = "btnAdicionarMedico";
            btnAdicionarMedico.Size = new Size(111, 27);
            btnAdicionarMedico.TabIndex = 6;
            btnAdicionarMedico.Text = "Adicionar Médico";
            btnAdicionarMedico.UseVisualStyleBackColor = true;
            btnAdicionarMedico.Click += btnAdicionarMedico_Click;
            // 
            // btnRemoverMedico
            // 
            btnRemoverMedico.Location = new Point(131, 141);
            btnRemoverMedico.Margin = new Padding(4, 3, 4, 3);
            btnRemoverMedico.Name = "btnRemoverMedico";
            btnRemoverMedico.Size = new Size(111, 27);
            btnRemoverMedico.TabIndex = 10;
            btnRemoverMedico.Text = "Remover Médico";
            btnRemoverMedico.UseVisualStyleBackColor = true;
            btnRemoverMedico.Click += btnRemoverMedico_Click;
            // 
            // btnRemEnfermeiro
            // 
            btnRemEnfermeiro.Location = new Point(582, 141);
            btnRemEnfermeiro.Margin = new Padding(4, 3, 4, 3);
            btnRemEnfermeiro.Name = "btnRemEnfermeiro";
            btnRemEnfermeiro.Size = new Size(123, 27);
            btnRemEnfermeiro.TabIndex = 12;
            btnRemEnfermeiro.Text = "Remover Enfermeiro";
            btnRemEnfermeiro.UseVisualStyleBackColor = true;
            btnRemEnfermeiro.Click += btnRemEnfermeiro_Click;
            // 
            // btnAddEnfermeiro
            // 
            btnAddEnfermeiro.Location = new Point(447, 141);
            btnAddEnfermeiro.Name = "btnAddEnfermeiro";
            btnAddEnfermeiro.Size = new Size(128, 27);
            btnAddEnfermeiro.TabIndex = 11;
            btnAddEnfermeiro.Text = "Adicionar Enfermeiro";
            btnAddEnfermeiro.UseVisualStyleBackColor = true;
            btnAddEnfermeiro.Click += btnAddEnfermeiro_Click;
            // 
            // btnRemViatura
            // 
            btnRemViatura.Location = new Point(131, 337);
            btnRemViatura.Margin = new Padding(4, 3, 4, 3);
            btnRemViatura.Name = "btnRemViatura";
            btnRemViatura.Size = new Size(111, 27);
            btnRemViatura.TabIndex = 14;
            btnRemViatura.Text = "Remover Viatura";
            btnRemViatura.UseVisualStyleBackColor = true;
            // 
            // btnAddViatura
            // 
            btnAddViatura.Location = new Point(13, 337);
            btnAddViatura.Name = "btnAddViatura";
            btnAddViatura.Size = new Size(111, 27);
            btnAddViatura.TabIndex = 13;
            btnAddViatura.Text = "Adicionar Viatura";
            btnAddViatura.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            Sair.Location = new Point(582, 262);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 15;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // AddMedOcor
            // 
            AddMedOcor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddMedOcor.Location = new Point(285, 141);
            AddMedOcor.Margin = new Padding(4, 3, 4, 3);
            AddMedOcor.Name = "AddMedOcor";
            AddMedOcor.Size = new Size(111, 45);
            AddMedOcor.TabIndex = 16;
            AddMedOcor.Text = "Adicionar a Ocorrência";
            AddMedOcor.UseVisualStyleBackColor = true;
            // 
            // AddEnfOcor
            // 
            AddEnfOcor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddEnfOcor.Location = new Point(719, 141);
            AddEnfOcor.Margin = new Padding(4, 3, 4, 3);
            AddEnfOcor.Name = "AddEnfOcor";
            AddEnfOcor.Size = new Size(111, 45);
            AddEnfOcor.TabIndex = 17;
            AddEnfOcor.Text = "Adicionar a Ocorrência";
            AddEnfOcor.UseVisualStyleBackColor = true;
            // 
            // AddViatOcor
            // 
            AddViatOcor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddViatOcor.Location = new Point(285, 337);
            AddViatOcor.Margin = new Padding(4, 3, 4, 3);
            AddViatOcor.Name = "AddViatOcor";
            AddViatOcor.Size = new Size(111, 45);
            AddViatOcor.TabIndex = 18;
            AddViatOcor.Text = "Adicionar a Ocorrência";
            AddViatOcor.UseVisualStyleBackColor = true;
            // 
            // FormINEM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 389);
            Controls.Add(AddViatOcor);
            Controls.Add(AddEnfOcor);
            Controls.Add(AddMedOcor);
            Controls.Add(Sair);
            Controls.Add(btnRemViatura);
            Controls.Add(btnAddViatura);
            Controls.Add(btnRemEnfermeiro);
            Controls.Add(btnAddEnfermeiro);
            Controls.Add(btnRemoverMedico);
            Controls.Add(btnAdicionarMedico);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxINEMViaturas);
            Controls.Add(listBoxINEMEnfermeiros);
            Controls.Add(listBoxINEMMedicos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormINEM";
            Text = "INEM";
            Load += FormINEM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxINEMEnfermeiros;
        private ListBox listBoxINEMViaturas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdicionarMedico;
        private Button btnRemoverMedico;
        private Button btnRemEnfermeiro;
        private Button btnAddEnfermeiro;
        private Button btnRemViatura;
        private Button btnAddViatura;
        private Button Sair;
        private Button AddMedOcor;
        private Button AddEnfOcor;
        private Button AddViatOcor;
    }
}
