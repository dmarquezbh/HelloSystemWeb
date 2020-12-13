﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Atendimento
    {
        public Atendimento()
        {
            AcompanhamentoGuias = new HashSet<AcompanhamentoGuias>();
            Acompanhante = new HashSet<Acompanhante>();
            AgendaSadt = new HashSet<AgendaSadt>();
            AntimicrobianoPedido = new HashSet<AntimicrobianoPedido>();
            AtendimentoArquivo = new HashSet<AtendimentoArquivo>();
            AtendimentoCancelado = new HashSet<AtendimentoCancelado>();
            AtendimentoCid = new HashSet<AtendimentoCid>();
            AtendimentoClassificacaoRisco = new HashSet<AtendimentoClassificacaoRisco>();
            AtendimentoDecisao = new HashSet<AtendimentoDecisao>();
            AtendimentoExameAcidente = new HashSet<AtendimentoExameAcidente>();
            AtendimentoHistoricoMedico = new HashSet<AtendimentoHistoricoMedico>();
            AtendimentoLeito = new HashSet<AtendimentoLeito>();
            AtendimentoMedico = new HashSet<AtendimentoMedico>();
            AtendimentoMedicoCancelado = new HashSet<AtendimentoMedicoCancelado>();
            AtendimentoObservacao = new HashSet<AtendimentoObservacao>();
            AtendimentoProcedimento = new HashSet<AtendimentoProcedimento>();
            AtendimentoServico = new HashSet<AtendimentoServico>();
            AtendimentoUsuario = new HashSet<AtendimentoUsuario>();
            CheckinEnfermagem = new HashSet<CheckinEnfermagem>();
            ConsignadoPendenteNota = new HashSet<ConsignadoPendenteNota>();
            Conta = new HashSet<Conta>();
            ContaComplemento = new HashSet<ContaComplemento>();
            ContaCorrente = new HashSet<ContaCorrente>();
            ControleVisitantes = new HashSet<ControleVisitantes>();
            DrgMedico = new HashSet<DrgMedico>();
            DrgProcedimento = new HashSet<DrgProcedimento>();
            DrgProcedimentoMedico = new HashSet<DrgProcedimentoMedico>();
            ExamesAnteriores = new HashSet<ExamesAnteriores>();
            GuiaAtendimento = new HashSet<GuiaAtendimento>();
            Interconsulta = new HashSet<Interconsulta>();
            LaboratorioPedido = new HashSet<LaboratorioPedido>();
            LeitoSolicitacao = new HashSet<LeitoSolicitacao>();
            LgpdLog = new HashSet<LgpdLog>();
            ObservacaoNutricional = new HashSet<ObservacaoNutricional>();
            OrdemServico = new HashSet<OrdemServico>();
            PedidoDeSangueHemoplus = new HashSet<PedidoDeSangueHemoplus>();
            ProcedimentoPedido = new HashSet<ProcedimentoPedido>();
            ProtocoloAtendimento = new HashSet<ProtocoloAtendimento>();
            RegistroEletronico = new HashSet<RegistroEletronico>();
            RegistroEletronicoArquivo = new HashSet<RegistroEletronicoArquivo>();
            RegistroEletronicoDeclaracao = new HashSet<RegistroEletronicoDeclaracao>();
            RestoIngestao = new HashSet<RestoIngestao>();
            ServicoUnicoAtendimento = new HashSet<ServicoUnicoAtendimento>();
            Solicitacao = new HashSet<Solicitacao>();
            SolicitacaoRefeicaoEspecial = new HashSet<SolicitacaoRefeicaoEspecial>();
        }

        public int IdAtendimento { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdPlano { get; set; }
        public string NrCartaoIdentificacao { get; set; }
        public string NrMatricula { get; set; }
        public DateTime? DtValidadeCartao { get; set; }
        public string NmTitular { get; set; }
        public DateTime? DtAtendimento { get; set; }
        public DateTime? DtAltaMedica { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? IdTipoInternacao { get; set; }
        public int? IdTipoInternacaoPaciente { get; set; }
        public int? IdProcedencia { get; set; }
        public int? IdTipoAtendimento { get; set; }
        public int? IdStatusAtendimento { get; set; }
        public string TxCondicaoPgto { get; set; }
        public string NrAutorizacao { get; set; }
        public int? IdMedicoPrincipal { get; set; }
        public bool? InSemOnus { get; set; }
        public string TxAutorizacaoSemOnus { get; set; }
        public string NmEmpresa { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InDescParticular { get; set; }
        public int? IdJustificativaCancelamento { get; set; }
        public DateTime? DtVenccarenc { get; set; }
        public string TxIntercambio { get; set; }
        public int? IdProcedimentoCiha { get; set; }
        public int? IdCidCiha { get; set; }
        public string NrVia { get; set; }
        public int? NrDrg { get; set; }

        public virtual TipoDiversos IdJustificativaCancelamentoNavigation { get; set; }
        public virtual Pessoa IdMedicoPrincipalNavigation { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual TipoDiversos IdProcedenciaNavigation { get; set; }
        public virtual TipoDiversos IdStatusAtendimentoNavigation { get; set; }
        public virtual TipoDiversos IdTipoAtendimentoNavigation { get; set; }
        public virtual TipoDiversos IdTipoInternacaoNavigation { get; set; }
        public virtual TipoDiversos IdTipoInternacaoPacienteNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual AltaMedica AltaMedica { get; set; }
        public virtual AtendimentoAltaAdministrativa AtendimentoAltaAdministrativa { get; set; }
        public virtual AtendimentoComplemento AtendimentoComplemento { get; set; }
        public virtual AtendimentoDrg AtendimentoDrg { get; set; }
        public virtual ColetaDadosPaciente ColetaDadosPaciente { get; set; }
        public virtual DrgAltaAdministrativa DrgAltaAdministrativa { get; set; }
        public virtual DrgBeneficiario DrgBeneficiario { get; set; }
        public virtual DrgCidSecundario DrgCidSecundario { get; set; }
        public virtual DrgInternacao DrgInternacao { get; set; }
        public virtual DrgOperadora DrgOperadora { get; set; }
        public virtual ICollection<AcompanhamentoGuias> AcompanhamentoGuias { get; set; }
        public virtual ICollection<Acompanhante> Acompanhante { get; set; }
        public virtual ICollection<AgendaSadt> AgendaSadt { get; set; }
        public virtual ICollection<AntimicrobianoPedido> AntimicrobianoPedido { get; set; }
        public virtual ICollection<AtendimentoArquivo> AtendimentoArquivo { get; set; }
        public virtual ICollection<AtendimentoCancelado> AtendimentoCancelado { get; set; }
        public virtual ICollection<AtendimentoCid> AtendimentoCid { get; set; }
        public virtual ICollection<AtendimentoClassificacaoRisco> AtendimentoClassificacaoRisco { get; set; }
        public virtual ICollection<AtendimentoDecisao> AtendimentoDecisao { get; set; }
        public virtual ICollection<AtendimentoExameAcidente> AtendimentoExameAcidente { get; set; }
        public virtual ICollection<AtendimentoHistoricoMedico> AtendimentoHistoricoMedico { get; set; }
        public virtual ICollection<AtendimentoLeito> AtendimentoLeito { get; set; }
        public virtual ICollection<AtendimentoMedico> AtendimentoMedico { get; set; }
        public virtual ICollection<AtendimentoMedicoCancelado> AtendimentoMedicoCancelado { get; set; }
        public virtual ICollection<AtendimentoObservacao> AtendimentoObservacao { get; set; }
        public virtual ICollection<AtendimentoProcedimento> AtendimentoProcedimento { get; set; }
        public virtual ICollection<AtendimentoServico> AtendimentoServico { get; set; }
        public virtual ICollection<AtendimentoUsuario> AtendimentoUsuario { get; set; }
        public virtual ICollection<CheckinEnfermagem> CheckinEnfermagem { get; set; }
        public virtual ICollection<ConsignadoPendenteNota> ConsignadoPendenteNota { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
        public virtual ICollection<ContaComplemento> ContaComplemento { get; set; }
        public virtual ICollection<ContaCorrente> ContaCorrente { get; set; }
        public virtual ICollection<ControleVisitantes> ControleVisitantes { get; set; }
        public virtual ICollection<DrgMedico> DrgMedico { get; set; }
        public virtual ICollection<DrgProcedimento> DrgProcedimento { get; set; }
        public virtual ICollection<DrgProcedimentoMedico> DrgProcedimentoMedico { get; set; }
        public virtual ICollection<ExamesAnteriores> ExamesAnteriores { get; set; }
        public virtual ICollection<GuiaAtendimento> GuiaAtendimento { get; set; }
        public virtual ICollection<Interconsulta> Interconsulta { get; set; }
        public virtual ICollection<LaboratorioPedido> LaboratorioPedido { get; set; }
        public virtual ICollection<LeitoSolicitacao> LeitoSolicitacao { get; set; }
        public virtual ICollection<LgpdLog> LgpdLog { get; set; }
        public virtual ICollection<ObservacaoNutricional> ObservacaoNutricional { get; set; }
        public virtual ICollection<OrdemServico> OrdemServico { get; set; }
        public virtual ICollection<PedidoDeSangueHemoplus> PedidoDeSangueHemoplus { get; set; }
        public virtual ICollection<ProcedimentoPedido> ProcedimentoPedido { get; set; }
        public virtual ICollection<ProtocoloAtendimento> ProtocoloAtendimento { get; set; }
        public virtual ICollection<RegistroEletronico> RegistroEletronico { get; set; }
        public virtual ICollection<RegistroEletronicoArquivo> RegistroEletronicoArquivo { get; set; }
        public virtual ICollection<RegistroEletronicoDeclaracao> RegistroEletronicoDeclaracao { get; set; }
        public virtual ICollection<RestoIngestao> RestoIngestao { get; set; }
        public virtual ICollection<ServicoUnicoAtendimento> ServicoUnicoAtendimento { get; set; }
        public virtual ICollection<Solicitacao> Solicitacao { get; set; }
        public virtual ICollection<SolicitacaoRefeicaoEspecial> SolicitacaoRefeicaoEspecial { get; set; }
    }
}