﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioMetodoEquipamento
    {
        /// <summary>
        /// identificador do método
        /// </summary>
        public int IdMetodo { get; set; }
        /// <summary>
        /// identificador do equipamento relacionado
        /// </summary>
        public int IdEquipamento { get; set; }
        /// <summary>
        /// exclusão lógica
        /// </summary>
        public int InAtivo { get; set; }

        public virtual TipoDiversos IdEquipamentoNavigation { get; set; }
        public virtual LaboratorioMetodo IdMetodoNavigation { get; set; }
    }
}