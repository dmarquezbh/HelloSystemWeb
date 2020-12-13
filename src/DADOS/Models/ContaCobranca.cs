﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaCobranca
    {
        public ContaCobranca()
        {
            ContaCobrancaComplementoHistorico = new HashSet<ContaCobrancaComplementoHistorico>();
            FaturamentoPerda = new HashSet<FaturamentoPerda>();
        }

        public int IdConta { get; set; }
        public double? VlConta { get; set; }
        public double? VlTotalGlosas { get; set; }
        public double? VlTotalFi { get; set; }
        public double? VlTotalAcrescimo { get; set; }
        public double? VlTotalRevertido { get; set; }
        public double? VlTotalConta { get; set; }
        public double? VlGlosaGenerica { get; set; }
        public bool? InGlosaGenerica { get; set; }
        public string TxDescGlosaGenerica { get; set; }
        public string TxObsSituacaoGlosa { get; set; }
        public DateTime? DtDevolucaoCorrecao { get; set; }
        public string TxMotivoDevolucao { get; set; }
        public int? IdUnidadeOrganizacionalDev { get; set; }
        public int? IdUsuario { get; set; }
        public bool? InProduto { get; set; }
        public double? VlAcrescimoGenerico { get; set; }
        public string TxDescAcrescimoGenerico { get; set; }
        public string IdJustificativaGlosaGenerica { get; set; }
        public decimal? VlTerceiro { get; set; }
        public decimal? VlHospital { get; set; }
        public decimal? VlTotalCredito { get; set; }
        public decimal? VlTotalEstorno { get; set; }
        public decimal? VlTotalLiberado { get; set; }
        public bool? InGlosaTotal { get; set; }
        public decimal VlTotalGlosasContaLimpa { get; set; }
        public decimal VlTotalFiContaLimpa { get; set; }

        public virtual JustificativaGlosaFi IdJustificativaGlosaGenericaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalDevNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ContaCobrancaComplemento ContaCobrancaComplemento { get; set; }
        public virtual RecursoGlosaGenerica RecursoGlosaGenerica { get; set; }
        public virtual ReversaoGlosaGenerica ReversaoGlosaGenerica { get; set; }
        public virtual ICollection<ContaCobrancaComplementoHistorico> ContaCobrancaComplementoHistorico { get; set; }
        public virtual ICollection<FaturamentoPerda> FaturamentoPerda { get; set; }
    }
}