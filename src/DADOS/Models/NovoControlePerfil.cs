﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class NovoControlePerfil
    {
        public int IdControle { get; set; }
        public int IdPerfil { get; set; }

        public virtual NovoControle IdControleNavigation { get; set; }
        public virtual Perfil IdPerfilNavigation { get; set; }
    }
}