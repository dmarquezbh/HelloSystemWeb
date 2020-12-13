﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Folhadesala
    {
        public Folhadesala()
        {
            EquipeResponsavel = new HashSet<EquipeResponsavel>();
            ProcedimentoSecundarioFolhaDeSala = new HashSet<ProcedimentoSecundarioFolhaDeSala>();
            RegistroEletronico = new HashSet<RegistroEletronico>();
            TaxaFolhaDeSala = new HashSet<TaxaFolhaDeSala>();
        }

        public int? NrFolhaDeSala { get; set; }
        public int IdProcedimentoPrincipal { get; set; }
        public int? IdAnestesia { get; set; }
        public DateTime HrInicio { get; set; }
        public DateTime? HrFim { get; set; }
        public string TxObservacoes { get; set; }
        public string TxJustificativaMatmedCirurgiao { get; set; }
        public bool InPreenchimentoConcluido { get; set; }
        public int? IdUsuarioConcluiuPreenchimento { get; set; }
        public int IdCheckinEnfermagem { get; set; }
        public bool InFolhaDeSalaPrincipal { get; set; }
        public DateTime? HrAnestesiaInicio { get; set; }
        public DateTime? HrAnestesiaFim { get; set; }
        public int? IdTipoGrauContaminacao { get; set; }
        public int? IdTipoAsa { get; set; }
        public int? IdCaraterCirurgia { get; set; }
        public string TxFilme { get; set; }
        public string TxKv { get; set; }
        public string TxMa { get; set; }
        public DateTime? DtFinalizacao { get; set; }

        public virtual TipoDiversos IdAnestesiaNavigation { get; set; }
        public virtual CheckinEnfermagem IdCheckinEnfermagemNavigation { get; set; }
        public virtual Servico IdProcedimentoPrincipalNavigation { get; set; }
        public virtual TipoDiversos IdTipoAsaNavigation { get; set; }
        public virtual TipoDiversos IdTipoGrauContaminacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioConcluiuPreenchimentoNavigation { get; set; }
        public virtual ICollection<EquipeResponsavel> EquipeResponsavel { get; set; }
        public virtual ICollection<ProcedimentoSecundarioFolhaDeSala> ProcedimentoSecundarioFolhaDeSala { get; set; }
        public virtual ICollection<RegistroEletronico> RegistroEletronico { get; set; }
        public virtual ICollection<TaxaFolhaDeSala> TaxaFolhaDeSala { get; set; }
    }
}