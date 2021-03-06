﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LaudoSadt
    {
        public LaudoSadt()
        {
            LaudoSadtIntegracaoConnect = new HashSet<LaudoSadtIntegracaoConnect>();
        }

        public int IdLaudoSadt { get; set; }
        public int IdCheckinEnfermagem { get; set; }
        public int? IdServico { get; set; }
        public int? IdProcedimentoPrincipalFolhadesala { get; set; }
        public int? IdProcedimentoSecundarioFolhadesala { get; set; }
        public int IdStatusLaudo { get; set; }
        public int? IdModeloLaudoSadt { get; set; }
        public string TxHtmlLaudo { get; set; }
        public string TxEnderecoEntrega { get; set; }
        public string NmDestinatarioLaudo { get; set; }
        public string NmEntregadorLaudo { get; set; }
        public byte[] AdAudioLaudo { get; set; }
        public string TxTextoLaudo { get; set; }
        public byte[] AdPdfLaudo { get; set; }
        public DateTime? DtLaudo { get; set; }
        /// <summary>
        /// accession number, número que identifica o exame no PACS
        /// </summary>
        public string NrAccession { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdMedico { get; set; }
        public string Rn { get; set; }
        public string TxDocumentosCancelados { get; set; }
        public string PatientId { get; set; }

        public virtual ModeloLaudoSadt IdModeloLaudoSadtNavigation { get; set; }
        public virtual ICollection<LaudoSadtIntegracaoConnect> LaudoSadtIntegracaoConnect { get; set; }
    }
}