﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Exame
    {
        public Exame()
        {
            ExameAcidenteExame = new HashSet<ExameAcidenteExame>();
            ExameExameAmostraIdExameFilhoNavigation = new HashSet<ExameExameAmostra>();
            ExameExameAmostraIdExamePaiNavigation = new HashSet<ExameExameAmostra>();
            ExameExameIdExameFilhoNavigation = new HashSet<ExameExame>();
            ExameExameIdExamePaiNavigation = new HashSet<ExameExame>();
            ExameItemColeta = new HashSet<ExameItemColeta>();
            ExameItemMaterialPlanilha = new HashSet<ExameItemMaterialPlanilha>();
            ExameMaterialColeta = new HashSet<ExameMaterialColeta>();
            ExamePessoaEntidade = new HashSet<ExamePessoaEntidade>();
            ExameServico = new HashSet<ExameServico>();
            ExameTempoLiberacao = new HashSet<ExameTempoLiberacao>();
            LaboratorioPedido = new HashSet<LaboratorioPedido>();
            LaboratorioPedidoItem = new HashSet<LaboratorioPedidoItem>();
            LaboratorioUnidadeSolicitanteExcecao = new HashSet<LaboratorioUnidadeSolicitanteExcecao>();
            OrdemServicoExame = new HashSet<OrdemServicoExame>();
            PacoteExameExame = new HashSet<PacoteExameExame>();
        }

        /// <summary>
        /// identificador do exame
        /// </summary>
        public int IdExame { get; set; }
        /// <summary>
        /// nome do exame
        /// </summary>
        public string NmExame { get; set; }
        /// <summary>
        /// se o resultado pode ser consultado pelos médicos na tela de pedidos
        /// </summary>
        public bool? InEntregaPessoal { get; set; }
        /// <summary>
        /// mnemonico do exame
        /// </summary>
        public string TxMnemonico { get; set; }
        /// <summary>
        /// exames parecidos
        /// </summary>
        public string TxSinonimia { get; set; }
        /// <summary>
        /// indicações dos exames
        /// </summary>
        public string TxIndicacao { get; set; }
        /// <summary>
        /// preparo do paciente
        /// </summary>
        public string TxPreparo { get; set; }
        public int? IdServico { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        /// <summary>
        /// para exames de cultura de bacterias
        /// </summary>
        public bool? InPesquisaBacteria { get; set; }
        /// <summary>
        /// exclusao lógica
        /// </summary>
        public bool? InAtivo { get; set; }
        /// <summary>
        /// observação que aparece no laudo
        /// </summary>
        public string TxObservacaoPadrao { get; set; }
        /// <summary>
        /// se o laudo vai aparecer o nome do paciente, como HIV
        /// </summary>
        public bool InImprimeSesmt { get; set; }
        /// <summary>
        /// bancada que o exame é realizado
        /// </summary>
        public int? IdSessaoTecnica { get; set; }
        public int? IdGrupo { get; set; }
        public bool? InColetaLaboratorio { get; set; }
        /// <summary>
        /// pode ser pacote ou simples
        /// </summary>
        public int IdTipoExame { get; set; }
        /// <summary>
        /// quanto tempo dura o exame em dias
        /// </summary>
        public int? NrTempoRealizacao { get; set; }
        /// <summary>
        /// texto de preparo da coleta
        /// </summary>
        public string TxPreparoColeta { get; set; }
        /// <summary>
        /// tipo do resultado do laudo será impresso
        /// </summary>
        public int? IdResultadoTipo { get; set; }
        /// <summary>
        /// texto dos interferentes
        /// </summary>
        public string TxInterferentes { get; set; }
        /// <summary>
        /// quais exames são relacionados
        /// </summary>
        public string TxRelacionados { get; set; }
        /// <summary>
        /// para cancelar a solicitação de novos exames
        /// </summary>
        public bool? InAtivado { get; set; }
        /// <summary>
        /// exame não é cobrado e não cai na conta
        /// </summary>
        public bool InExameGratuito { get; set; }
        public TimeSpan? NrHoraRealizacao { get; set; }
        /// <summary>
        /// obrigatoriedade da comunicação ao médico para resultado crítico
        /// </summary>
        public bool InExigeComunicacao { get; set; }
        public bool InSomenteUmPorDia { get; set; }

        public virtual TipoDiversos IdResultadoTipoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
        public virtual UnidadeOrganizacional IdSessaoTecnicaNavigation { get; set; }
        public virtual TipoDiversos IdTipoExameNavigation { get; set; }
        public virtual ICollection<ExameAcidenteExame> ExameAcidenteExame { get; set; }
        public virtual ICollection<ExameExameAmostra> ExameExameAmostraIdExameFilhoNavigation { get; set; }
        public virtual ICollection<ExameExameAmostra> ExameExameAmostraIdExamePaiNavigation { get; set; }
        public virtual ICollection<ExameExame> ExameExameIdExameFilhoNavigation { get; set; }
        public virtual ICollection<ExameExame> ExameExameIdExamePaiNavigation { get; set; }
        public virtual ICollection<ExameItemColeta> ExameItemColeta { get; set; }
        public virtual ICollection<ExameItemMaterialPlanilha> ExameItemMaterialPlanilha { get; set; }
        public virtual ICollection<ExameMaterialColeta> ExameMaterialColeta { get; set; }
        public virtual ICollection<ExamePessoaEntidade> ExamePessoaEntidade { get; set; }
        public virtual ICollection<ExameServico> ExameServico { get; set; }
        public virtual ICollection<ExameTempoLiberacao> ExameTempoLiberacao { get; set; }
        public virtual ICollection<LaboratorioPedido> LaboratorioPedido { get; set; }
        public virtual ICollection<LaboratorioPedidoItem> LaboratorioPedidoItem { get; set; }
        public virtual ICollection<LaboratorioUnidadeSolicitanteExcecao> LaboratorioUnidadeSolicitanteExcecao { get; set; }
        public virtual ICollection<OrdemServicoExame> OrdemServicoExame { get; set; }
        public virtual ICollection<PacoteExameExame> PacoteExameExame { get; set; }
    }
}