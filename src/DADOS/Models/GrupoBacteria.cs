﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GrupoBacteria
    {
        public GrupoBacteria()
        {
            GrupoBacteriaAntibiotico = new HashSet<GrupoBacteriaAntibiotico>();
            GrupoBacteriaBacteria = new HashSet<GrupoBacteriaBacteria>();
        }

        public int IdGrupoBacteria { get; set; }
        public string NmGrupoBacteria { get; set; }

        public virtual ICollection<GrupoBacteriaAntibiotico> GrupoBacteriaAntibiotico { get; set; }
        public virtual ICollection<GrupoBacteriaBacteria> GrupoBacteriaBacteria { get; set; }
    }
}