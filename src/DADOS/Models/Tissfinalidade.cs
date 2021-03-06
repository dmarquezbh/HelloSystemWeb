﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Tissfinalidade
    {
        public Tissfinalidade()
        {
            TissarquivoGerado = new HashSet<TissarquivoGerado>();
            TissarquivoGeradoRecurso = new HashSet<TissarquivoGeradoRecurso>();
            TissfinalidadeCampoValor = new HashSet<TissfinalidadeCampoValor>();
            TissfinalidadeOperadora = new HashSet<TissfinalidadeOperadora>();
        }

        public int IdFinalidade { get; set; }
        public string TxDescricao { get; set; }
        public int? IdVersao { get; set; }
        public int? IdOperadora { get; set; }
        public bool? InExterno { get; set; }
        public string TxArquivo { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public bool? InPadrao { get; set; }
        public int IdTipoMensagem { get; set; }

        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Tissversao IdVersaoNavigation { get; set; }
        public virtual ICollection<TissarquivoGerado> TissarquivoGerado { get; set; }
        public virtual ICollection<TissarquivoGeradoRecurso> TissarquivoGeradoRecurso { get; set; }
        public virtual ICollection<TissfinalidadeCampoValor> TissfinalidadeCampoValor { get; set; }
        public virtual ICollection<TissfinalidadeOperadora> TissfinalidadeOperadora { get; set; }
    }
}