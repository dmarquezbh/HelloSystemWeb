﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Monitor
    {
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        public string TextData { get; set; }
        public int? ClientProcessId { get; set; }
        public string ApplicationName { get; set; }
        public int? Spid { get; set; }
        public long? Duration { get; set; }
        public DateTime? StartTime { get; set; }
    }
}