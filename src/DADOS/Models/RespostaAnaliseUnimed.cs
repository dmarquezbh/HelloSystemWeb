﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RespostaAnaliseUnimed
    {
        public RespostaAnaliseUnimed()
        {
            AnaliseUnimed = new HashSet<AnaliseUnimed>();
        }

        public int IdRespostaAnalise { get; set; }
        public string TxRespostaAnalise { get; set; }

        public virtual ICollection<AnaliseUnimed> AnaliseUnimed { get; set; }
    }
}