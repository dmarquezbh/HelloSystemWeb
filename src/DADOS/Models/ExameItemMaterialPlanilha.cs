﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameItemMaterialPlanilha
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdExame { get; set; }
        public int IdItemExame { get; set; }
        public int IdMaterialTipo { get; set; }
        public string TxDescExame { get; set; }

        public virtual Exame IdExameNavigation { get; set; }
        public virtual ItemExame IdItemExameNavigation { get; set; }
        public virtual TipoDiversos IdMaterialTipoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}