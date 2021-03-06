﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameMaterialColeta
    {
        public ExameMaterialColeta()
        {
            ExameItemExame = new HashSet<ExameItemExame>();
            ExameMaterialMetodoAnalisador = new HashSet<ExameMaterialMetodoAnalisador>();
            ExameMaterialMetodoMeioColeta = new HashSet<ExameMaterialMetodoMeioColeta>();
        }

        public int IdExameMaterialMeioMetodo { get; set; }
        public int IdExame { get; set; }
        public int IdMaterialTipo { get; set; }
        public int IdMetodoTipo { get; set; }
        public double? NrVolumeColeta { get; set; }
        public string NrQuantidadeAmostra { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdModeloLaudo { get; set; }
        public bool InImprimeMapa { get; set; }
        public int IdEquipamento { get; set; }

        public virtual TipoDiversos IdEquipamentoNavigation { get; set; }
        public virtual Exame IdExameNavigation { get; set; }
        public virtual ModeloLaudo IdModeloLaudoNavigation { get; set; }
        public virtual ICollection<ExameItemExame> ExameItemExame { get; set; }
        public virtual ICollection<ExameMaterialMetodoAnalisador> ExameMaterialMetodoAnalisador { get; set; }
        public virtual ICollection<ExameMaterialMetodoMeioColeta> ExameMaterialMetodoMeioColeta { get; set; }
    }
}