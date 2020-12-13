﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ImpressaoEtiqueta
    {
        /// <summary>
        /// identificador único do texto da impressao
        /// </summary>
        public int IdImpresaoEtiqueta { get; set; }
        /// <summary>
        /// tipo da impressao, tipo tabela 409
        /// </summary>
        public int IdTipoImpressao { get; set; }
        /// <summary>
        /// texto com códi; que será enviado a impressora
        /// </summary>
        public string TxImpressao { get; set; }
        /// <summary>
        /// armazena as variaveis que o usuario pode utilizar
        /// </summary>
        public string TxInstrucoes { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }

        public virtual TipoDiversos IdTipoImpressaoNavigation { get; set; }
    }
}