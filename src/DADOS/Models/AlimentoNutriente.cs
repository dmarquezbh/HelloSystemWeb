﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AlimentoNutriente
    {
        public int IdAlimento { get; set; }
        public int IdNutriente { get; set; }
        public decimal QnNutriente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool InAtivo { get; set; }

        public virtual Nutriente IdNutrienteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}