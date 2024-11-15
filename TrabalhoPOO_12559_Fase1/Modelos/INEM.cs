//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO_12559_Fase1.Utilitários;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class INEM
    {
        #region Private Properties
        private string baseINEM { get; set; }
        private List<Viatura> viaturas = [];
        private List<Medico> medicos = [];
        private List<Enfermeiro> enfermeiros = [];
        #endregion

        #region Public Properties
        public string BaseINEM
        {
            get => baseINEM;
            set => baseINEM = value;
        }
        public List<Viatura> Viaturas
        {
            get => viaturas;
            set => viaturas.AddRange(value);
        }
        public List<Medico> Medicos

        {
            get => medicos;
            set => medicos.AddRange(value);
        }

        public List <Enfermeiro> Enfermeiros
        {
            get => enfermeiros;
            set => enfermeiros.AddRange(value);
        }

        #endregion

        #region Constructors
        public INEM(string baseINEM)
        {
            this.BaseINEM = baseINEM;
        }
        #endregion
       
        #region Methods
        public void AddViatura(Viatura viaturas)
        {
            Viaturas.Add(viaturas);
            string tipoVeiculo = Utilitarios.tipoVeiculo(viaturas.tipoEquipamento);
            Console.WriteLine($"{tipoVeiculo} de matricula {viaturas.Matricula} adicionada à base INEM {baseINEM}.");
        }
        public void AddMedico(Medico medicos)
        {
            Medicos.Add(medicos);
            Console.WriteLine($"{medicos.Nome} adicionado à base INEM {baseINEM}");
        }

        public void AddEnfermeiro(Enfermeiro enfermeiros)
        {
            Enfermeiros.Add(enfermeiros);
            Console.WriteLine($"{enfermeiros.Nome} adicionado à base INEM {baseINEM}");
        }

        #endregion
    }
}