﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameItemExameTipoTabela
    {
        public int IdExameMaterialMeioMetodo { get; set; }
        public int IdItemExame { get; set; }
        public int IdTipoTabela { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ExameItemExame Id { get; set; }
        public virtual TipoTabela IdTipoTabelaNavigation { get; set; }
    }
}