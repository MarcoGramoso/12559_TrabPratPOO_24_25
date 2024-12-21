//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using TrabalhoPOO_12559_Fase1.Modelos;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário Principal
    /// </summary>
    public partial class FormPrincipal : Form
    {
        #region Private Properties
        // Instância da Corporação e do INEM
        private readonly Corporacao corporacao;
        private readonly INEM inem;
        #endregion

        #region Constructor
        /// <summary>
        /// Inicializa uma nova instância da classe
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            corporacao = Corporacao.Instance;  // Obtém a instância Singleton de Corporacao
            inem = INEM.Instance; // Obtém a instância Singleton de INEM
        }


        #endregion

        #region Event Handlers
        /// <summary>
        /// Evento para gerir bombeiros.
        /// </summary>
        private void gerenciarBombeirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBombeiro formBombeiro = new FormBombeiro(corporacao);  // Passa a instância de Corporacao
            formBombeiro.Show();
        }

        /// <summary>
        /// Evento para gerir enfermeiros.
        /// </summary>
        private void gerenciarEnfermeirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnfermeiro formEnfermeiro = new FormEnfermeiro(inem);  // Passa a instância de INEM
            formEnfermeiro.Show();
        }

        /// <summary>
        /// Evento para gerir médicos.
        /// </summary>
        private void gerenciarMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedico formMedico = new FormMedico(inem);  // Passa a instância de INEM
            formMedico.Show();
        }

        /// <summary>
        /// Evento para gerir viaturas.
        /// </summary>
        private void gerenciarViaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViatura formViatura = new FormViatura();  // Se FormViatura não precisar de parâmetros, basta deixar como está
            formViatura.Show();
        }

        /// <summary>
        /// Evento para gerir ocorrências.
        /// </summary>
        private void gerirOcorrenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOcorrencia formOcorrencia = new FormOcorrencia();  // Se FormOcorrencia não precisar de parâmetros, basta deixar como está
            formOcorrencia.Show();
        }

        /// <summary>
        /// Evento para gerir INEM.
        /// </summary>
        private void gerirINEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormINEM formINEM = new FormINEM();  // Se FormINEM não precisar de parâmetros, basta deixar como está
            formINEM.Show();
        }

        /// <summary>
        /// Evento para gerir corporação.
        /// </summary>
        private void gerirCorporacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCorporacao formCorporacao = new FormCorporacao();  // Se FormCorporacao não precisar de parâmetros, basta deixar como está
            formCorporacao.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
