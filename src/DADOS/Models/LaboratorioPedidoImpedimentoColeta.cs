﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaboratorioPedidoImpedimentoColeta
    {
        public int IdLaboratorioPedidoImpedimentoColeta { get; set; }
        public int IdLaboratorioPedido { get; set; }
        public int IdImpedimentoColeta { get; set; }
        public DateTime DtRegistro { get; set; }
        public int IdUsuario { get; set; }

        public virtual TipoDiversos IdImpedimentoColetaNavigation { get; set; }
        public virtual LaboratorioPedido IdLaboratorioPedidoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}