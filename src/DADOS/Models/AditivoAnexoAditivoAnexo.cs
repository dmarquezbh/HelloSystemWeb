﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AditivoAnexoAditivoAnexo
    {
        public int IdAditivoAnexo { get; set; }
        public int IdAditivoAnexoSubstituicao { get; set; }

        public virtual AditivoAnexo IdAditivoAnexoNavigation { get; set; }
        public virtual AditivoAnexo IdAditivoAnexoSubstituicaoNavigation { get; set; }
    }
}