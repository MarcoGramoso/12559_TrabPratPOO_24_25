namespace TrabalhoPOO_12559_Fase2
{
    partial class FormOcorrencia
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionarOcorrencia;
        private System.Windows.Forms.Button btnAtualizarStatus;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ListBox listBoxOcorrencias;

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
            btnAdicionarOcorrencia = new Button();
            btnAtualizarStatus = new Button();
            txtDescricao = new TextBox();
            txtLocal = new TextBox();
            comboBoxStatus = new ComboBox();
            listBoxOcorrencias = new ListBox();
            Local = new Label();
            Descricao = new Label();
            btnINEM = new Button();
            btnCorporacao = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdicionarOcorrencia
            // 
            btnAdicionarOcorrencia.Location = new Point(649, 27);
            btnAdicionarOcorrencia.Name = "btnAdicionarOcorrencia";
            btnAdicionarOcorrencia.Size = new Size(173, 23);
            btnAdicionarOcorrencia.TabIndex = 0;
            btnAdicionarOcorrencia.Text = "Adicionar Nova Ocorrência";
            btnAdicionarOcorrencia.UseVisualStyleBackColor = true;
            btnAdicionarOcorrencia.Click += btnAdicionarOcorrencia_Click;
            // 
            // btnAtualizarStatus
            // 
            btnAtualizarStatus.Location = new Point(374, 131);
            btnAtualizarStatus.Name = "btnAtualizarStatus";
            btnAtualizarStatus.Size = new Size(120, 24);
            btnAtualizarStatus.TabIndex = 1;
            btnAtualizarStatus.Text = "Atualizar Status";
            btnAtualizarStatus.UseVisualStyleBackColor = true;
            btnAtualizarStatus.Click += btnAtualizarStatus_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(74, 41);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(569, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(74, 12);
            txtLocal.Name = "txtLocal";
            txtLocal.PlaceholderText = "Local";
            txtLocal.Size = new Size(569, 23);
            txtLocal.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(500, 132);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(120, 23);
            comboBoxStatus.TabIndex = 5;
            // 
            // listBoxOcorrencias
            // 
            listBoxOcorrencias.FormattingEnabled = true;
            listBoxOcorrencias.ItemHeight = 15;
            listBoxOcorrencias.Location = new Point(12, 176);
            listBoxOcorrencias.Name = "listBoxOcorrencias";
            listBoxOcorrencias.Size = new Size(811, 94);
            listBoxOcorrencias.TabIndex = 6;
            // 
            // Local
            // 
            Local.AutoSize = true;
            Local.Location = new Point(12, 15);
            Local.Name = "Local";
            Local.Size = new Size(35, 15);
            Local.TabIndex = 7;
            Local.Text = "Local";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Location = new Point(12, 44);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(58, 15);
            Descricao.TabIndex = 8;
            Descricao.Text = "Descrição";
            // 
            // btnINEM
            // 
            btnINEM.Location = new Point(12, 131);
            btnINEM.Name = "btnINEM";
            btnINEM.Size = new Size(75, 23);
            btnINEM.TabIndex = 9;
            btnINEM.Text = "INEM";
            btnINEM.UseVisualStyleBackColor = true;
            // 
            // btnCorporacao
            // 
            btnCorporacao.Location = new Point(152, 131);
            btnCorporacao.Name = "btnCorporacao";
            btnCorporacao.Size = new Size(87, 23);
            btnCorporacao.TabIndex = 10;
            btnCorporacao.Text = "Corporação";
            btnCorporacao.UseVisualStyleBackColor = true;
            btnCorporacao.Click += btnCorporacao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 113);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 11;
            label1.Text = "Adicionar Meios";
            // 
            // FormOcorrencia
            // 
            ClientSize = new Size(835, 414);
            Controls.Add(label1);
            Controls.Add(btnCorporacao);
            Controls.Add(btnINEM);
            Controls.Add(Descricao);
            Controls.Add(Local);
            Controls.Add(listBoxOcorrencias);
            Controls.Add(comboBoxStatus);
            Controls.Add(txtLocal);
            Controls.Add(txtDescricao);
            Controls.Add(btnAtualizarStatus);
            Controls.Add(btnAdicionarOcorrencia);
            Name = "FormOcorrencia";
            Text = "Gerenciar Ocorrências";
            Load += FormOcorrencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Local;
        private Label Descricao;
        private Button btnINEM;
        private Button btnCorporacao;
        private Label label1;
    }
}
