﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AgendaFarmaciaUnidadeOrganizacional
    {
        public int IdUnidadeOrganizacional { get; set; }
        public int IdAgendaFarmacia { get; set; }
        public int NrSequencia { get; set; }

        public virtual AgendaFarmacia IdAgendaFarmaciaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
    }
}