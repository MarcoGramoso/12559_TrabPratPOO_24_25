namespace TrabalhoPOO_12559_Fase2
{
    partial class FormMedico
    {
        #region Private Properties
        private System.ComponentModel.IContainer components = null;
        private Button btnAdicionarMedico;
        private Button btnAdicionarAoINEM;
        private TextBox txtNomeMedico;
        private DateTimePicker dtpDataNascMedico;
        private ListBox listBoxMedicos;
        private Label label1;
        private Label label2;
        private Button Sair;
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Methods
        private void InitializeComponent()
        {
            btnAdicionarMedico = new Button();
            btnAdicionarAoINEM = new Button();
            txtNomeMedico = new TextBox();
            dtpDataNascMedico = new DateTimePicker();
            listBoxMedicos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            Sair = new Button();
            btnRemoverMedico = new Button();
            SuspendLayout();
            // 
            // btnAdicionarMedico
            // 
            btnAdicionarMedico.Location = new Point(507, 12);
            btnAdicionarMedico.Name = "btnAdicionarMedico";
            btnAdicionarMedico.Size = new Size(140, 27);
            btnAdicionarMedico.TabIndex = 0;
            btnAdicionarMedico.Text = "Adicionar Médico";
            btnAdicionarMedico.UseVisualStyleBackColor = true;
            btnAdicionarMedico.Click += btnAdicionarMedico_Click;
            // 
            // btnAdicionarAoINEM
            // 
            btnAdicionarAoINEM.Location = new Point(12, 353);
            btnAdicionarAoINEM.Name = "btnAdicionarAoINEM";
            btnAdicionarAoINEM.Size = new Size(140, 27);
            btnAdicionarAoINEM.TabIndex = 1;
            btnAdicionarAoINEM.Text = "Adicionar ao INEM";
            btnAdicionarAoINEM.UseVisualStyleBackColor = true;
            btnAdicionarAoINEM.Click += btnAdicionarAoINEM_Click;
            // 
            // txtNomeMedico
            // 
            txtNomeMedico.Location = new Point(129, 12);
            txtNomeMedico.Name = "txtNomeMedico";
            txtNomeMedico.Size = new Size(276, 23);
            txtNomeMedico.TabIndex = 2;
            // 
            // dtpDataNascMedico
            // 
            dtpDataNascMedico.Location = new Point(129, 41);
            dtpDataNascMedico.Name = "dtpDataNascMedico";
            dtpDataNascMedico.Size = new Size(276, 23);
            dtpDataNascMedico.TabIndex = 3;
            // 
            // listBoxMedicos
            // 
            listBoxMedicos.FormattingEnabled = true;
            listBoxMedicos.ItemHeight = 15;
            listBoxMedicos.Location = new Point(12, 86);
            listBoxMedicos.Name = "listBoxMedicos";
            listBoxMedicos.Size = new Size(635, 244);
            listBoxMedicos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Data de Nascimento";
            // 
            // Sair
            // 
            Sair.Location = new Point(572, 355);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 8;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // btnRemoverMedico
            // 
            btnRemoverMedico.Location = new Point(507, 45);
            btnRemoverMedico.Margin = new Padding(4, 3, 4, 3);
            btnRemoverMedico.Name = "btnRemoverMedico";
            btnRemoverMedico.Size = new Size(140, 27);
            btnRemoverMedico.TabIndex = 9;
            btnRemoverMedico.Text = "Remover Médico";
            btnRemoverMedico.UseVisualStyleBackColor = true;
            btnRemoverMedico.Click += btnRemoverMedico_Click;
            // 
            // FormMedico
            // 
            ClientSize = new Size(656, 444);
            Controls.Add(btnRemoverMedico);
            Controls.Add(Sair);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxMedicos);
            Controls.Add(dtpDataNascMedico);
            Controls.Add(txtNomeMedico);
            Controls.Add(btnAdicionarAoINEM);
            Controls.Add(btnAdicionarMedico);
            Name = "FormMedico";
            Text = "Gerir Médicos";
            Load += FormMedico_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnRemoverMedico;
    }
}