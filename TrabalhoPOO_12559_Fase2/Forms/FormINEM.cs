using System.Text.Json;
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário para gerir INEM
    /// </summary>
    public partial class FormINEM : Form
    {
        #region Private Properties

        private INEM inem;
        private const string MedicosFilePath = "medicosINEM.json";
        private const string EnfermeirosFilePath = "enfermeirosINEM.json";
        private const string ViaturasFilePath = "viaturasINEM.json";

        #endregion

        #region Constructors

        /// <summary>
        /// Construtor de INEM
        /// </summary>
        public FormINEM()
        {
            InitializeComponent();
            inem = new INEM();
            CarregarDados();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Evento que inicia o formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormINEM_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que atualiza a lista de médicos
        /// </summary>
        public void AtualizarListaMedicos()
        {
            listBoxINEMMedicos.Items.Clear();
            foreach (var medico in INEM.Instance.Medicos)
            {
                listBoxINEMMedicos.Items.Add($"{medico.Nome} - {medico.DataNasc:dd/MM/yyyy}");
            }
        }

        public void AtualizarListaEnfermeiros()
        {
            listBoxINEMEnfermeiros.Items.Clear();
            foreach (var enfermeiro in INEM.Instance.Enfermeiros)
            {
                listBoxINEMEnfermeiros.Items.Add($"{enfermeiro.Nome} - {enfermeiro.DataNasc:dd/MM/yyyy}");
            }
        }

        public void AtualizarListaViaturas()
        {
            listBoxINEMViaturas.Items.Clear();
            foreach (var viatura in INEM.Instance.Viaturas)
            {
                listBoxINEMViaturas.Items.Add($"{viatura.Matricula} - {viatura.TipoEquipamento}");
            }
        }

        private void SalvarDados()
        {
            var medicosINEMJson = JsonSerializer.Serialize(INEM.Instance.Medicos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(MedicosFilePath, medicosINEMJson);

            var enfermeirosINEMJson = JsonSerializer.Serialize(INEM.Instance.Enfermeiros, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(EnfermeirosFilePath, enfermeirosINEMJson);

            var viaturasINEMJson = JsonSerializer.Serialize(INEM.Instance.Viaturas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ViaturasFilePath, viaturasINEMJson);
        }
        private void CarregarDados()
        {
            if (File.Exists(MedicosFilePath))
            {
                var medicosINEMJson = File.ReadAllText(MedicosFilePath);
                INEM.Instance.Medicos = JsonSerializer.Deserialize<List<Medico>>(medicosINEMJson);
            }

            if (File.Exists(EnfermeirosFilePath))
            {
                var enfermeirosINEMJson = File.ReadAllText(EnfermeirosFilePath);
                INEM.Instance.Enfermeiros = JsonSerializer.Deserialize<List<Enfermeiro>>(enfermeirosINEMJson);
            }

            if (File.Exists(ViaturasFilePath))
            {
                var viaturasINEMJson = File.ReadAllText(ViaturasFilePath);
                INEM.Instance.Viaturas = JsonSerializer.Deserialize<List<Viatura>>(viaturasINEMJson);
            }
        }
        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar Sair
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sair_Click(object sender, EventArgs e)
        {
            DataStorage.SaveData(INEM.Instance.Medicos, MedicosFilePath);
            DataStorage.SaveData(INEM.Instance.Enfermeiros, EnfermeirosFilePath);
            this.Close();
        }

        /// <summary>
        /// Evento executado ao clicar "Adicionar Médico"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarMedico_Click(object sender, EventArgs e)
        {
            FormMedico formMedico = new FormMedico(inem);
            formMedico.ShowDialog();
        }

        /// <summary>
        /// Evento executado ao clicar em "Remover Médico".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverMedico_Click(object sender, EventArgs e)
        {
            if (listBoxINEMMedicos.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja remover este médico?", "Confirmar Remoção", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    INEM.Instance.Medicos.RemoveAt(listBoxINEMMedicos.SelectedIndex);
                    MessageBox.Show("Médico removido com sucesso!");
                    AtualizarListaMedicos();
                    DataStorage.SaveData(inem, MedicosFilePath);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um médico para remover.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar "Adicionar Enfermeiro"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEnfermeiro_Click(object sender, EventArgs e)
        {
            FormEnfermeiro formEnfermeiro = new FormEnfermeiro(inem);
            formEnfermeiro.ShowDialog();
        }

        /// <summary>
        /// Evento executado ao clicar "Remover Enfermeiro"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemEnfermeiro_Click(object sender, EventArgs e)
        {
            if (listBoxINEMEnfermeiros.SelectedIndex >= 0)
            {
                INEM.Instance.Enfermeiros.RemoveAt(listBoxINEMEnfermeiros.SelectedIndex);
                MessageBox.Show("Enfermeiro removido com sucesso!");
                AtualizarListaEnfermeiros();
                DataStorage.SaveData(inem, EnfermeirosFilePath); // Salvando os dados atualizados após a remoção.
            }
            else
            {
                MessageBox.Show("Por favor, selecione um enfermeiro para remover.");
            }
        }




        #endregion

    }
}
