﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Blocktable
    {
        public int? Blockedsid { get; set; }
        public int? Blockingsid { get; set; }
        public string Eventinfo1 { get; set; }
        public string Eventinfo2 { get; set; }
        public int? Waittime { get; set; }
        public string Hostname { get; set; }
        public DateTime? DatBloqueio { get; set; }
        public string ProgramName1 { get; set; }
        public string ProgramName2 { get; set; }
        public string HostBlocking { get; set; }
    }
}