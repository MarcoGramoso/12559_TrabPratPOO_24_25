namespace TrabalhoPOO_12559_Fase2
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegisto;

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
            lblUtilizador = new Label();
            lblSenha = new Label();
            txtUtilizador = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnRegisto = new Button();
            SuspendLayout();
            // 
            // lblUtilizador
            // 
            lblUtilizador.AutoSize = true;
            lblUtilizador.Location = new Point(89, 57);
            lblUtilizador.Name = "lblUtilizador";
            lblUtilizador.Size = new Size(60, 15);
            lblUtilizador.TabIndex = 0;
            lblUtilizador.Text = "Utilizador:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(89, 83);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // txtUtilizador
            // 
            txtUtilizador.Location = new Point(156, 54);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.Size = new Size(207, 23);
            txtUtilizador.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(156, 80);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(156, 106);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnRegisto
            // 
            btnRegisto.Location = new Point(262, 106);
            btnRegisto.Name = "btnRegisto";
            btnRegisto.Size = new Size(100, 23);
            btnRegisto.TabIndex = 5;
            btnRegisto.Text = "Registo";
            btnRegisto.UseVisualStyleBackColor = true;
            btnRegisto.Click += btnRegisto_Click;
            // 
            // FormLogin
            // 
            ClientSize = new Size(503, 250);
            Controls.Add(btnRegisto);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUtilizador);
            Controls.Add(lblSenha);
            Controls.Add(lblUtilizador);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}