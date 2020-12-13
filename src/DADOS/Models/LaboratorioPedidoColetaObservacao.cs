﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioPedidoColetaObservacao
    {
        /// <summary>
        /// identificador única da observação da coleta por pedido
        /// </summary>
        public int IdLaboratorioPedidoColetaObservacao { get; set; }
        /// <summary>
        /// identificador do pedido
        /// </summary>
        public int IdLaboratorioPedido { get; set; }
        /// <summary>
        /// observação da coleta por pedido
        /// </summary>
        public string TxObservacao { get; set; }
        /// <summary>
        /// data que foi lançada a observação
        /// </summary>
        public DateTime DtObservacao { get; set; }
        /// <summary>
        /// usuário que digitou a observação
        /// </summary>
        public int? IdUsuario { get; set; }

        public virtual LaboratorioPedido IdLaboratorioPedidoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}