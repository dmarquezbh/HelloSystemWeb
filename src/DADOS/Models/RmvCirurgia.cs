﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RmvCirurgia
    {
        public int Codcoligada { get; set; }
        public string Prontuario { get; set; }
        public string Paciente { get; set; }
        public string Codespecialidade { get; set; }
        public string Tipocirurgia { get; set; }
        public string Tipoferida { get; set; }
        public DateTime Datahorainicio { get; set; }
        public string DatahorainicioVarchar { get; set; }
        public DateTime? Datahoratermino { get; set; }
        public string DatahoraterminoVarchar { get; set; }
        public int? Asa { get; set; }
        public string Crmanestesista { get; set; }
        public string Tipoanestesia { get; set; }
        public string Codcirurgia { get; set; }
    }
}