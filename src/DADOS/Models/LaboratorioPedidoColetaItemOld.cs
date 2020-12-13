﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioPedidoColetaItemOld
    {
        /// <summary>
        /// identificador da coleta
        /// </summary>
        public int IdLaboratorioPedidoColeta { get; set; }
        /// <summary>
        /// identificador do item de metadado da coleta no exame
        /// </summary>
        public int IdExameItemColeta { get; set; }
        /// <summary>
        /// valor do metadado
        /// </summary>
        public string TxValor { get; set; }
        /// <summary>
        /// exclusão lógica
        /// </summary>
        public bool? InAtivo { get; set; }

        public virtual ExameItemColeta IdExameItemColetaNavigation { get; set; }
        public virtual LaboratorioPedidoColeta IdLaboratorioPedidoColetaNavigation { get; set; }
    }
}