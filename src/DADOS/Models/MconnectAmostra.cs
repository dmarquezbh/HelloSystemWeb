﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class MconnectAmostra
    {
        public MconnectAmostra()
        {
            MconnectExame = new HashSet<MconnectExame>();
            MconnectOcorrencias = new HashSet<MconnectOcorrencias>();
        }

        public string Amostra { get; set; }
        public string Registro { get; set; }
        public string Diluicao { get; set; }
        public string Agrupamento { get; set; }
        public string Laboratorio { get; set; }
        public string Instrumento { get; set; }
        public string Origem { get; set; }
        public string Material { get; set; }
        public string Rack { get; set; }
        public string Escaninho { get; set; }
        public string DataColeta { get; set; }
        public string HoraColeta { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<MconnectExame> MconnectExame { get; set; }
        public virtual ICollection<MconnectOcorrencias> MconnectOcorrencias { get; set; }
    }
}