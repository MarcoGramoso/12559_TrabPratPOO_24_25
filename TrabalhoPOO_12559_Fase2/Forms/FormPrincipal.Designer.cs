namespace TrabalhoPOO_12559_Fase2
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarBombeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEnfermeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarViaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarOcorrenciasToolStripMenuItem;

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
            menuStrip1 = new MenuStrip();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            gerenciarBombeirosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarEnfermeirosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarMedicosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarViaturasToolStripMenuItem = new ToolStripMenuItem();
            gerenciarOcorrenciasToolStripMenuItem = new ToolStripMenuItem();
            gerenciarINEMToolStripMenuItem = new ToolStripMenuItem();
            gerirCorporaçãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarBombeirosToolStripMenuItem, gerenciarEnfermeirosToolStripMenuItem, gerenciarMedicosToolStripMenuItem, gerenciarViaturasToolStripMenuItem, gerenciarOcorrenciasToolStripMenuItem, gerenciarINEMToolStripMenuItem, gerirCorporaçãoToolStripMenuItem });
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(69, 20);
            gerenciarToolStripMenuItem.Text = "Menu de Gestão";
            // 
            // gerenciarBombeirosToolStripMenuItem
            // 
            gerenciarBombeirosToolStripMenuItem.Name = "gerenciarBombeirosToolStripMenuItem";
            gerenciarBombeirosToolStripMenuItem.Size = new Size(190, 22);
            gerenciarBombeirosToolStripMenuItem.Text = "Gerir Bombeiros";
            gerenciarBombeirosToolStripMenuItem.Click += gerenciarBombeirosToolStripMenuItem_Click;
            // 
            // gerenciarEnfermeirosToolStripMenuItem
            // 
            gerenciarEnfermeirosToolStripMenuItem.Name = "gerenciarEnfermeirosToolStripMenuItem";
            gerenciarEnfermeirosToolStripMenuItem.Size = new Size(190, 22);
            gerenciarEnfermeirosToolStripMenuItem.Text = "Gerir Enfermeiros";
            gerenciarEnfermeirosToolStripMenuItem.Click += gerenciarEnfermeirosToolStripMenuItem_Click;
            // 
            // gerenciarMedicosToolStripMenuItem
            // 
            gerenciarMedicosToolStripMenuItem.Name = "gerenciarMedicosToolStripMenuItem";
            gerenciarMedicosToolStripMenuItem.Size = new Size(190, 22);
            gerenciarMedicosToolStripMenuItem.Text = "Gerir Médicos";
            gerenciarMedicosToolStripMenuItem.Click += gerenciarMedicosToolStripMenuItem_Click;
            // 
            // gerenciarViaturasToolStripMenuItem
            // 
            gerenciarViaturasToolStripMenuItem.Name = "gerenciarViaturasToolStripMenuItem";
            gerenciarViaturasToolStripMenuItem.Size = new Size(190, 22);
            gerenciarViaturasToolStripMenuItem.Text = "Gerir Viaturas";
            gerenciarViaturasToolStripMenuItem.Click += gerenciarViaturasToolStripMenuItem_Click;
            // 
            // gerenciarOcorrenciasToolStripMenuItem
            // 
            gerenciarOcorrenciasToolStripMenuItem.Name = "gerenciarOcorrenciasToolStripMenuItem";
            gerenciarOcorrenciasToolStripMenuItem.Size = new Size(190, 22);
            gerenciarOcorrenciasToolStripMenuItem.Text = "Gerir Ocorrências";
            gerenciarOcorrenciasToolStripMenuItem.Click += gerirOcorrenciasToolStripMenuItem_Click;
            // 
            // gerenciarINEMToolStripMenuItem
            // 
            gerenciarINEMToolStripMenuItem.Name = "gerenciarINEMToolStripMenuItem";
            gerenciarINEMToolStripMenuItem.Size = new Size(190, 22);
            gerenciarINEMToolStripMenuItem.Text = "Gerir INEM";
            gerenciarINEMToolStripMenuItem.Click += gerirINEMToolStripMenuItem_Click;
            // 
            // gerirCorporaçãoToolStripMenuItem
            // 
            gerirCorporaçãoToolStripMenuItem.Name = "gerirCorporaçãoToolStripMenuItem";
            gerirCorporaçãoToolStripMenuItem.Size = new Size(190, 22);
            gerirCorporaçãoToolStripMenuItem.Text = "Gerir Corporação";
            gerirCorporaçãoToolStripMenuItem.Click += gerirCorporacaoToolStripMenuItem_Click;
    
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Menu Principal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

      

        private ToolStripMenuItem gerenciarINEMToolStripMenuItem;
        private ToolStripMenuItem gerirCorporaçãoToolStripMenuItem;
    }
}