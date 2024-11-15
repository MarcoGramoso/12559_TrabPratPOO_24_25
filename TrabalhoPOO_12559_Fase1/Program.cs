//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Enums;
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase1.Interfaces;

namespace TrabalhoPOO_12559_Fase1
{
    class Program
    {
        #region Methods
        static void Main(string[] args)
        {
            //Cria uma corporação de bombeiros
            Corporacao corporacao1 = new Corporacao("Bombeiros Voluntários de Barcelos");
            Corporacao corporacao2 = new Corporacao("Bombeiros Voluntários de Albufeira");

            //Cria uma base do INEM
            INEM inem1 = new INEM("Centro Orientação de Doentes Urgentes do Porto");

            //Cria viaturas
            Viatura viatura1 = new Viatura(TipoEquipamento.Ambulancia, "BO-10-OS");
            Viatura viatura2 = new Viatura(TipoEquipamento.ViaturaIncendio, "FO-00-GO");
            Viatura viatura3 = new Viatura(TipoEquipamento.ViaturaMedica, "IN-15-EM");

            //Cria bombeiros
            Bombeiro bombeiro1 = new Bombeiro("Bombeiro Borges", new DateTime(1982, 06, 13));
            Bombeiro bombeiro2 = new Bombeiro("Bombeiro Lima", new DateTime(1979, 12, 29));

            //Cria médico
            Medico medico1 = new("Dr. Silva", new DateTime(1985, 10, 05));

            //Cria enfermeiro
            Enfermeiro enfermeiro1 = new Enfermeiro("Enf. Sousa", new DateTime(1985, 05, 06));

            //Adiciona viatura à corporação de Bombeiros
            corporacao1.AddViatura(viatura1);
            corporacao2.AddViatura(viatura2);

            //Adiciona bombeiros à corporação de Bombeiros
            corporacao1.AddBombeiro(bombeiro2);
            corporacao2.AddBombeiro(bombeiro1);

            //Adiciona viatura à base do INEM
            inem1.AddViatura(viatura3);

            //Adiciona medico e enfermeiro à base do INEM
            inem1.AddMedico(medico1);
            inem1.AddEnfermeiro(enfermeiro1);

            // Criação de ocorrências e alocação de meios
            Ocorrencia ocorrencia1 = new Ocorrencia("Incêndio florestal", "Monte de Santa Maria");
            Console.WriteLine("Ocorrência criada: " + ocorrencia1);
            ocorrencia1.AdicionarPessoa(bombeiro1);
            ocorrencia1.AdicionarMeio(viatura2);
            
            // Atualização do status da ocorrência
            ocorrencia1.AtualizarStatus(StatusOcorrencia.EmCurso);

            // Fecho da ocorrência e salvar a ocorrência em um arquivo txt
            ocorrencia1.AtualizarStatus(StatusOcorrencia.Fechada);
            ocorrencia1.SalvarOcorrencia();
            Console.WriteLine("Ocorrência salva no arquivo.\n");

            // Criação de uma 2ª ocorrência e alocação de meios
            Ocorrencia ocorrencia2 = new Ocorrencia("Doença Subita", "Rua das Flores");
            Console.WriteLine("Ocorrência criada: " + ocorrencia2);
            ocorrencia2.AtualizarStatus(StatusOcorrencia.Despachodemeios);
            ocorrencia2.AdicionarPessoa(bombeiro2);
            ocorrencia2.AdicionarMeio(viatura1);

            // Atualiza a ocorrencia e envia mais meios
            ocorrencia2.AtualizarStatus(StatusOcorrencia.EmCurso);
            ocorrencia2.AdicionarPessoa(medico1);
            ocorrencia2.AdicionarPessoa(enfermeiro1);
            ocorrencia2.AdicionarMeio(viatura3);
            ocorrencia2.SalvarOcorrencia();
            medico1.Indisponivel();
            Console.WriteLine("Ocorrência Salva");
        }
        #endregion
    }
}

