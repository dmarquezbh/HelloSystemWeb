﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Acompanhante = new HashSet<Acompanhante>();
            Agencia = new HashSet<Agencia>();
            AgendaCc = new HashSet<AgendaCc>();
            AgendaHdCorpoClinico = new HashSet<AgendaHdCorpoClinico>();
            AgendaHdIdMedicoNavigation = new HashSet<AgendaHd>();
            AgendaHdIdPacienteNavigation = new HashSet<AgendaHd>();
            AgendaProfissionalSaudeOperadoraHorario = new HashSet<AgendaProfissionalSaudeOperadoraHorario>();
            AgendaSadtBloqueioPacienteIdMedicoNavigation = new HashSet<AgendaSadtBloqueioPaciente>();
            AgendaSadtBloqueioPacienteIdPacienteNavigation = new HashSet<AgendaSadtBloqueioPaciente>();
            AgendaSadtIdMedicoNavigation = new HashSet<AgendaSadt>();
            AgendaSadtIdOperadoraNavigation = new HashSet<AgendaSadt>();
            AgendaSadtIdPacienteNavigation = new HashSet<AgendaSadt>();
            AltaMedica = new HashSet<AltaMedica>();
            Alvara = new HashSet<Alvara>();
            AntecipacaoEntrega = new HashSet<AntecipacaoEntrega>();
            AntimicrobianoPedido = new HashSet<AntimicrobianoPedido>();
            ArquivoRemessaLayoutOperadora = new HashSet<ArquivoRemessaLayoutOperadora>();
            AtendeSadt = new HashSet<AtendeSadt>();
            AtendimentoHistoricoMedicoIdMedicoAnteriorNavigation = new HashSet<AtendimentoHistoricoMedico>();
            AtendimentoHistoricoMedicoIdMedicoAtualNavigation = new HashSet<AtendimentoHistoricoMedico>();
            AtendimentoIdMedicoPrincipalNavigation = new HashSet<Atendimento>();
            AtendimentoIdPessoaNavigation = new HashSet<Atendimento>();
            AtendimentoMedico = new HashSet<AtendimentoMedico>();
            AtendimentoMedicoCancelado = new HashSet<AtendimentoMedicoCancelado>();
            BoletoCobranca = new HashSet<BoletoCobranca>();
            Bordero = new HashSet<Bordero>();
            Carencia = new HashSet<Carencia>();
            CarenciaPaciente = new HashSet<CarenciaPaciente>();
            CartaRecurso = new HashSet<CartaRecurso>();
            CheckinEnfermagem = new HashSet<CheckinEnfermagem>();
            Cheque = new HashSet<Cheque>();
            ChequeParametrosImpressao = new HashSet<ChequeParametrosImpressao>();
            ClinicaMedicoLancamentoAvulsoIdClinicaNavigation = new HashSet<ClinicaMedicoLancamentoAvulso>();
            ClinicaMedicoLancamentoAvulsoIdMedicoNavigation = new HashSet<ClinicaMedicoLancamentoAvulso>();
            ClinicaUnidadeOrganizacionalMedicoVigencia = new HashSet<ClinicaUnidadeOrganizacionalMedicoVigencia>();
            CobrancaJudicial = new HashSet<CobrancaJudicial>();
            CobrancaTerceirizada = new HashSet<CobrancaTerceirizada>();
            ComposicaoItem = new HashSet<ComposicaoItem>();
            ComposicaoItemCarga = new HashSet<ComposicaoItemCarga>();
            ConciliacaoCobranca = new HashSet<ConciliacaoCobranca>();
            ContaCorrente = new HashSet<ContaCorrente>();
            ContaDtLiberacaoTab = new HashSet<ContaDtLiberacaoTab>();
            ContaItemServicoMedicoExecutante = new HashSet<ContaItemServicoMedicoExecutante>();
            ContaPagar = new HashSet<ContaPagar>();
            ContaReceberIdPessoaNavigation = new HashSet<ContaReceber>();
            ContaReceberIdResponsavelNavigation = new HashSet<ContaReceber>();
            Cotacao = new HashSet<Cotacao>();
            CotacaoFornecedor = new HashSet<CotacaoFornecedor>();
            CronogramaConta = new HashSet<CronogramaConta>();
            DefaultContabil = new HashSet<DefaultContabil>();
            DietaPadronizadaMedicamentoOperadora = new HashSet<DietaPadronizadaMedicamentoOperadora>();
            Documento = new HashSet<Documento>();
            DocumentoEmprestimoIdEmprestadoNavigation = new HashSet<DocumentoEmprestimo>();
            DocumentoEmprestimoIdPacienteNavigation = new HashSet<DocumentoEmprestimo>();
            DocumentoFluxoDocumentoFinalidade = new HashSet<DocumentoFluxoDocumentoFinalidade>();
            DocumentoLoteMedico = new HashSet<DocumentoLoteMedico>();
            DocumentoexigidoOperadora = new HashSet<DocumentoexigidoOperadora>();
            Emprestimo = new HashSet<Emprestimo>();
            EquipeResponsavel = new HashSet<EquipeResponsavel>();
            ExameServico = new HashSet<ExameServico>();
            FaturaFinanceira = new HashSet<FaturaFinanceira>();
            FaturamentoConta = new HashSet<FaturamentoConta>();
            FaturamentoContaTiss = new HashSet<FaturamentoContaTiss>();
            FluxoEtapa = new HashSet<FluxoEtapa>();
            FornecedorTributoAliquota = new HashSet<FornecedorTributoAliquota>();
            GeracaoAjusteServicoHistorico = new HashSet<GeracaoAjusteServicoHistorico>();
            GuiaFaixaNumeracao = new HashSet<GuiaFaixaNumeracao>();
            GuiaIdMedicoAutorizadorNavigation = new HashSet<Guia>();
            GuiaIdMedicoExecutanteNavigation = new HashSet<Guia>();
            GuiaIdMedicoNavigation = new HashSet<Guia>();
            GuiaIdOperadoraNavigation = new HashSet<Guia>();
            InspecaoRecebimento = new HashSet<InspecaoRecebimento>();
            IntegracaoConnect = new HashSet<IntegracaoConnect>();
            Interconsulta = new HashSet<Interconsulta>();
            KitProcedimentoServico = new HashSet<KitProcedimentoServico>();
            KitTaxasGases = new HashSet<KitTaxasGases>();
            KitTaxasGasesOperadora = new HashSet<KitTaxasGasesOperadora>();
            LaboratorioPedidoIdMedicoSolicitanteNavigation = new HashSet<LaboratorioPedido>();
            LaboratorioPedidoIdPacienteNavigation = new HashSet<LaboratorioPedido>();
            LancamentoBancarioComplemento = new HashSet<LancamentoBancarioComplemento>();
            LancamentoBancarioIdCredorFavorecidoNavigation = new HashSet<LancamentoBancario>();
            LancamentoBancarioIdOperadoraResponsavelCreditoNavigation = new HashSet<LancamentoBancario>();
            LeitoEventoLeito = new HashSet<LeitoEventoLeito>();
            LeitoReservaIdColaboradorNavigation = new HashSet<LeitoReserva>();
            LeitoReservaIdPacienteNavigation = new HashSet<LeitoReserva>();
            MedicoEspecialidade = new HashSet<MedicoEspecialidade>();
            NotaEmitida = new HashSet<NotaEmitida>();
            NotaEntradaIdFornecedorNavigation = new HashSet<NotaEntrada>();
            NotaEntradaIdTransportadoraNavigation = new HashSet<NotaEntrada>();
            NotaExcluida = new HashSet<NotaExcluida>();
            ObservacaoAgendacc = new HashSet<ObservacaoAgendacc>();
            ObservacaoAgendasadt = new HashSet<ObservacaoAgendasadt>();
            OperadoraCodigoHospital = new HashSet<OperadoraCodigoHospital>();
            OperadoraEmpresaConveniadaIdOperadoraNavigation = new HashSet<OperadoraEmpresaConveniada>();
            OperadoraEmpresaConveniadaIdPessoaNavigation = new HashSet<OperadoraEmpresaConveniada>();
            OperadoraEmpresaPagante = new HashSet<OperadoraEmpresaPagante>();
            OperadoraEspecialidade = new HashSet<OperadoraEspecialidade>();
            OperadoraHistorico = new HashSet<OperadoraHistorico>();
            OperadoraModuloDigitoVerificador = new HashSet<OperadoraModuloDigitoVerificador>();
            OperadoraParametro = new HashSet<OperadoraParametro>();
            OperadoraRecebimento = new HashSet<OperadoraRecebimento>();
            OperadoraUnidadeOrganizacionalCredenciada = new HashSet<OperadoraUnidadeOrganizacionalCredenciada>();
            OrcamentoValoresOpme = new HashSet<OrcamentoValoresOpme>();
            OrdemCompra = new HashSet<OrdemCompra>();
            OrdemCompraCaracteristica = new HashSet<OrdemCompraCaracteristica>();
            OrdemServicoExameExamePrioridadeEtapaIdFuncResponsavelNavigation = new HashSet<OrdemServicoExameExamePrioridadeEtapa>();
            OrdemServicoExameExamePrioridadeEtapaIdPrestadorNavigation = new HashSet<OrdemServicoExameExamePrioridadeEtapa>();
            OrdemServicoIdFuncAberturaNavigation = new HashSet<OrdemServico>();
            OrdemServicoIdFuncExecutanteNavigation = new HashSet<OrdemServico>();
            OrdemServicoIdMedicoSolicitanteNavigation = new HashSet<OrdemServico>();
            OrdemServicoServico = new HashSet<OrdemServicoServico>();
            PacoteFaturamento = new HashSet<PacoteFaturamento>();
            PedidoDeSangueHemoplus = new HashSet<PedidoDeSangueHemoplus>();
            PessoaCaracteristica = new HashSet<PessoaCaracteristica>();
            PessoaCaracteristicaHistorico = new HashSet<PessoaCaracteristicaHistorico>();
            PessoaCorreioEletronico = new HashSet<PessoaCorreioEletronico>();
            PessoaCorreioEletronicoHistoricoNaoRegistro = new HashSet<PessoaCorreioEletronicoHistoricoNaoRegistro>();
            PessoaEndereco = new HashSet<PessoaEndereco>();
            PessoaHistorico = new HashSet<PessoaHistorico>();
            PessoaImagem = new HashSet<PessoaImagem>();
            PessoaPessoaIdPessoaFilhoNavigation = new HashSet<PessoaPessoa>();
            PessoaPessoaIdPessoaPaiNavigation = new HashSet<PessoaPessoa>();
            PessoaPlano = new HashSet<PessoaPlano>();
            PessoaPlanoContas = new HashSet<PessoaPlanoContas>();
            PessoaRelacionamento = new HashSet<PessoaRelacionamento>();
            PessoaTelefone = new HashSet<PessoaTelefone>();
            PessoaUrl = new HashSet<PessoaUrl>();
            Plano = new HashSet<Plano>();
            PlanoEmpresaConveniada = new HashSet<PlanoEmpresaConveniada>();
            PlanoOperadoraCategoria = new HashSet<PlanoOperadoraCategoria>();
            PlanoRede = new HashSet<PlanoRede>();
            PlanoTratamentoOncologia = new HashSet<PlanoTratamentoOncologia>();
            ProcedimentoPedido = new HashSet<ProcedimentoPedido>();
            ProcedimentosServico = new HashSet<ProcedimentosServico>();
            ProdutoDetalheFabricante = new HashSet<ProdutoDetalheFabricante>();
            ProdutoDetalheFabricanteCodigoBarras = new HashSet<ProdutoDetalheFabricanteCodigoBarras>();
            ProdutoDetalheFabricanteServicoProdutoTabelaOperadora = new HashSet<ProdutoDetalheFabricanteServicoProdutoTabelaOperadora>();
            ProdutoDetalheOperadoraServicoCaracteristicaTipo = new HashSet<ProdutoDetalheOperadoraServicoCaracteristicaTipo>();
            ProdutoFabricante = new HashSet<ProdutoFabricante>();
            ProdutoFornecedor = new HashSet<ProdutoFornecedor>();
            ProdutoNaoCoberto = new HashSet<ProdutoNaoCoberto>();
            ProdutoNaoCobrado = new HashSet<ProdutoNaoCobrado>();
            ProdutoQtdeAutorizada = new HashSet<ProdutoQtdeAutorizada>();
            ProdutoUnidadeMedidaConversao = new HashSet<ProdutoUnidadeMedidaConversao>();
            ProdutoUnidadeMedidaConversaoHistorico = new HashSet<ProdutoUnidadeMedidaConversaoHistorico>();
            ProfissionalSaudeCbo = new HashSet<ProfissionalSaudeCbo>();
            ProfissionalSaudeOperadoraIdOperadoraNavigation = new HashSet<ProfissionalSaudeOperadora>();
            ProfissionalSaudeOperadoraIdProfissionalNavigation = new HashSet<ProfissionalSaudeOperadora>();
            RecusaMaterialIdFornecedorNavigation = new HashSet<RecusaMaterial>();
            RecusaMaterialIdTransportadoraNavigation = new HashSet<RecusaMaterial>();
            RegistroEletronico = new HashSet<RegistroEletronico>();
            RegistroEletronicoArquivo = new HashSet<RegistroEletronicoArquivo>();
            RegistroEletronicoModeloServico = new HashSet<RegistroEletronicoModeloServico>();
            Relacionamento = new HashSet<Relacionamento>();
            RepasseCustoOperacionalPacote = new HashSet<RepasseCustoOperacionalPacote>();
            RepasseExcecaoHistorico = new HashSet<RepasseExcecaoHistorico>();
            RepasseMedicoHistoricoIdClinicaNavigation = new HashSet<RepasseMedicoHistorico>();
            RepasseMedicoHistoricoIdMedicoNavigation = new HashSet<RepasseMedicoHistorico>();
            RepasseMedicoIdClinicaNavigation = new HashSet<RepasseMedico>();
            RepasseMedicoIdMedicoNavigation = new HashSet<RepasseMedico>();
            RepasseOperadoraUnidadeOrganizacionalServico = new HashSet<RepasseOperadoraUnidadeOrganizacionalServico>();
            ReservaHorarioSadt = new HashSet<ReservaHorarioSadt>();
            RestricaoServico = new HashSet<RestricaoServico>();
            RetornoArquivo = new HashSet<RetornoArquivo>();
            SacOcorrencia = new HashSet<SacOcorrencia>();
            ServicoClassificacaoHospitalSus = new HashSet<ServicoClassificacaoHospitalSus>();
            ServicoExcecao = new HashSet<ServicoExcecao>();
            ServicoExcecaoPlano = new HashSet<ServicoExcecaoPlano>();
            ServicoGuia = new HashSet<ServicoGuia>();
            ServicoOperadoraPlanoServicoCaracteristicaTipo = new HashSet<ServicoOperadoraPlanoServicoCaracteristicaTipo>();
            ServicoOperadoraServicoCaracteristicaTipo = new HashSet<ServicoOperadoraServicoCaracteristicaTipo>();
            ServicoOperadoraServicoProdutoTabela = new HashSet<ServicoOperadoraServicoProdutoTabela>();
            ServicoOperadoraServicoProdutoTabelaPlano = new HashSet<ServicoOperadoraServicoProdutoTabelaPlano>();
            ServicoPreco = new HashSet<ServicoPreco>();
            ServicoPrecoSus = new HashSet<ServicoPrecoSus>();
            ServicoProdutoTabela = new HashSet<ServicoProdutoTabela>();
            ServicoProdutoTabelaOperadora = new HashSet<ServicoProdutoTabelaOperadora>();
            ServicoProdutoTabelaOperadoraClassificacaoProduto = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProduto>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo>();
            ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico = new HashSet<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico>();
            ServicoProdutoTabelaOperadoraHistorico = new HashSet<ServicoProdutoTabelaOperadoraHistorico>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo>();
            ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico = new HashSet<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico>();
            ServicoQuantidadeAutorizada = new HashSet<ServicoQuantidadeAutorizada>();
            ServicoReducaoAcrescimo = new HashSet<ServicoReducaoAcrescimo>();
            ServicoServicoProdutoTabelaOperadora = new HashSet<ServicoServicoProdutoTabelaOperadora>();
            ServicoTraducaoVigencia = new HashSet<ServicoTraducaoVigencia>();
            SessaoPortal = new HashSet<SessaoPortal>();
            Solicitacao = new HashSet<Solicitacao>();
            Tissfinalidade = new HashSet<Tissfinalidade>();
            TissfinalidadeOperadora = new HashSet<TissfinalidadeOperadora>();
            Tissmensagem = new HashSet<Tissmensagem>();
            Tributo = new HashSet<Tributo>();
            UnidadeOrganizacional = new HashSet<UnidadeOrganizacional>();
            UnidadeOrganizacionalColaborador = new HashSet<UnidadeOrganizacionalColaborador>();
            UnidadeOrganizacionalHorarioAgendaBaseAgenda = new HashSet<UnidadeOrganizacionalHorarioAgendaBaseAgenda>();
            UnidadeOrganizacionalHorarioAgendaMarcacao = new HashSet<UnidadeOrganizacionalHorarioAgendaMarcacao>();
            UnidadeOrganizacionalHorarioAgendaReserva = new HashSet<UnidadeOrganizacionalHorarioAgendaReserva>();
            UnidadeOrganizacionalOperadoraPlanoServicoAutomatico = new HashSet<UnidadeOrganizacionalOperadoraPlanoServicoAutomatico>();
            UsuarioOperadora = new HashSet<UsuarioOperadora>();
        }

        public int IdPessoa { get; set; }
        public string NmPessoa { get; set; }
        public int IdPessoaTipo { get; set; }
        public int IdOrigemCadastroTipo { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdSinples { get; set; }
        public int? IdGrupo { get; set; }
        public string Telefone { get; set; }
        public DateTime? DtCriacao { get; set; }

        public virtual TipoDiversos IdOrigemCadastroTipoNavigation { get; set; }
        public virtual TipoDiversos IdPessoaTipoNavigation { get; set; }
        public virtual ArquivoRemessa ArquivoRemessa { get; set; }
        public virtual FaturamentoContaTipo FaturamentoContaTipo { get; set; }
        public virtual GeraProntuario GeraProntuario { get; set; }
        public virtual OperadoraIss OperadoraIss { get; set; }
        public virtual RemuneracaoServico RemuneracaoServico { get; set; }
        public virtual ICollection<Acompanhante> Acompanhante { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<AgendaCc> AgendaCc { get; set; }
        public virtual ICollection<AgendaHdCorpoClinico> AgendaHdCorpoClinico { get; set; }
        public virtual ICollection<AgendaHd> AgendaHdIdMedicoNavigation { get; set; }
        public virtual ICollection<AgendaHd> AgendaHdIdPacienteNavigation { get; set; }
        public virtual ICollection<AgendaProfissionalSaudeOperadoraHorario> AgendaProfissionalSaudeOperadoraHorario { get; set; }
        public virtual ICollection<AgendaSadtBloqueioPaciente> AgendaSadtBloqueioPacienteIdMedicoNavigation { get; set; }
        public virtual ICollection<AgendaSadtBloqueioPaciente> AgendaSadtBloqueioPacienteIdPacienteNavigation { get; set; }
        public virtual ICollection<AgendaSadt> AgendaSadtIdMedicoNavigation { get; set; }
        public virtual ICollection<AgendaSadt> AgendaSadtIdOperadoraNavigation { get; set; }
        public virtual ICollection<AgendaSadt> AgendaSadtIdPacienteNavigation { get; set; }
        public virtual ICollection<AltaMedica> AltaMedica { get; set; }
        public virtual ICollection<Alvara> Alvara { get; set; }
        public virtual ICollection<AntecipacaoEntrega> AntecipacaoEntrega { get; set; }
        public virtual ICollection<AntimicrobianoPedido> AntimicrobianoPedido { get; set; }
        public virtual ICollection<ArquivoRemessaLayoutOperadora> ArquivoRemessaLayoutOperadora { get; set; }
        public virtual ICollection<AtendeSadt> AtendeSadt { get; set; }
        public virtual ICollection<AtendimentoHistoricoMedico> AtendimentoHistoricoMedicoIdMedicoAnteriorNavigation { get; set; }
        public virtual ICollection<AtendimentoHistoricoMedico> AtendimentoHistoricoMedicoIdMedicoAtualNavigation { get; set; }
        public virtual ICollection<Atendimento> AtendimentoIdMedicoPrincipalNavigation { get; set; }
        public virtual ICollection<Atendimento> AtendimentoIdPessoaNavigation { get; set; }
        public virtual ICollection<AtendimentoMedico> AtendimentoMedico { get; set; }
        public virtual ICollection<AtendimentoMedicoCancelado> AtendimentoMedicoCancelado { get; set; }
        public virtual ICollection<BoletoCobranca> BoletoCobranca { get; set; }
        public virtual ICollection<Bordero> Bordero { get; set; }
        public virtual ICollection<Carencia> Carencia { get; set; }
        public virtual ICollection<CarenciaPaciente> CarenciaPaciente { get; set; }
        public virtual ICollection<CartaRecurso> CartaRecurso { get; set; }
        public virtual ICollection<CheckinEnfermagem> CheckinEnfermagem { get; set; }
        public virtual ICollection<Cheque> Cheque { get; set; }
        public virtual ICollection<ChequeParametrosImpressao> ChequeParametrosImpressao { get; set; }
        public virtual ICollection<ClinicaMedicoLancamentoAvulso> ClinicaMedicoLancamentoAvulsoIdClinicaNavigation { get; set; }
        public virtual ICollection<ClinicaMedicoLancamentoAvulso> ClinicaMedicoLancamentoAvulsoIdMedicoNavigation { get; set; }
        public virtual ICollection<ClinicaUnidadeOrganizacionalMedicoVigencia> ClinicaUnidadeOrganizacionalMedicoVigencia { get; set; }
        public virtual ICollection<CobrancaJudicial> CobrancaJudicial { get; set; }
        public virtual ICollection<CobrancaTerceirizada> CobrancaTerceirizada { get; set; }
        public virtual ICollection<ComposicaoItem> ComposicaoItem { get; set; }
        public virtual ICollection<ComposicaoItemCarga> ComposicaoItemCarga { get; set; }
        public virtual ICollection<ConciliacaoCobranca> ConciliacaoCobranca { get; set; }
        public virtual ICollection<ContaCorrente> ContaCorrente { get; set; }
        public virtual ICollection<ContaDtLiberacaoTab> ContaDtLiberacaoTab { get; set; }
        public virtual ICollection<ContaItemServicoMedicoExecutante> ContaItemServicoMedicoExecutante { get; set; }
        public virtual ICollection<ContaPagar> ContaPagar { get; set; }
        public virtual ICollection<ContaReceber> ContaReceberIdPessoaNavigation { get; set; }
        public virtual ICollection<ContaReceber> ContaReceberIdResponsavelNavigation { get; set; }
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        public virtual ICollection<CotacaoFornecedor> CotacaoFornecedor { get; set; }
        public virtual ICollection<CronogramaConta> CronogramaConta { get; set; }
        public virtual ICollection<DefaultContabil> DefaultContabil { get; set; }
        public virtual ICollection<DietaPadronizadaMedicamentoOperadora> DietaPadronizadaMedicamentoOperadora { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual ICollection<DocumentoEmprestimo> DocumentoEmprestimoIdEmprestadoNavigation { get; set; }
        public virtual ICollection<DocumentoEmprestimo> DocumentoEmprestimoIdPacienteNavigation { get; set; }
        public virtual ICollection<DocumentoFluxoDocumentoFinalidade> DocumentoFluxoDocumentoFinalidade { get; set; }
        public virtual ICollection<DocumentoLoteMedico> DocumentoLoteMedico { get; set; }
        public virtual ICollection<DocumentoexigidoOperadora> DocumentoexigidoOperadora { get; set; }
        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
        public virtual ICollection<EquipeResponsavel> EquipeResponsavel { get; set; }
        public virtual ICollection<ExameServico> ExameServico { get; set; }
        public virtual ICollection<FaturaFinanceira> FaturaFinanceira { get; set; }
        public virtual ICollection<FaturamentoConta> FaturamentoConta { get; set; }
        public virtual ICollection<FaturamentoContaTiss> FaturamentoContaTiss { get; set; }
        public virtual ICollection<FluxoEtapa> FluxoEtapa { get; set; }
        public virtual ICollection<FornecedorTributoAliquota> FornecedorTributoAliquota { get; set; }
        public virtual ICollection<GeracaoAjusteServicoHistorico> GeracaoAjusteServicoHistorico { get; set; }
        public virtual ICollection<GuiaFaixaNumeracao> GuiaFaixaNumeracao { get; set; }
        public virtual ICollection<Guia> GuiaIdMedicoAutorizadorNavigation { get; set; }
        public virtual ICollection<Guia> GuiaIdMedicoExecutanteNavigation { get; set; }
        public virtual ICollection<Guia> GuiaIdMedicoNavigation { get; set; }
        public virtual ICollection<Guia> GuiaIdOperadoraNavigation { get; set; }
        public virtual ICollection<InspecaoRecebimento> InspecaoRecebimento { get; set; }
        public virtual ICollection<IntegracaoConnect> IntegracaoConnect { get; set; }
        public virtual ICollection<Interconsulta> Interconsulta { get; set; }
        public virtual ICollection<KitProcedimentoServico> KitProcedimentoServico { get; set; }
        public virtual ICollection<KitTaxasGases> KitTaxasGases { get; set; }
        public virtual ICollection<KitTaxasGasesOperadora> KitTaxasGasesOperadora { get; set; }
        public virtual ICollection<LaboratorioPedido> LaboratorioPedidoIdMedicoSolicitanteNavigation { get; set; }
        public virtual ICollection<LaboratorioPedido> LaboratorioPedidoIdPacienteNavigation { get; set; }
        public virtual ICollection<LancamentoBancarioComplemento> LancamentoBancarioComplemento { get; set; }
        public virtual ICollection<LancamentoBancario> LancamentoBancarioIdCredorFavorecidoNavigation { get; set; }
        public virtual ICollection<LancamentoBancario> LancamentoBancarioIdOperadoraResponsavelCreditoNavigation { get; set; }
        public virtual ICollection<LeitoEventoLeito> LeitoEventoLeito { get; set; }
        public virtual ICollection<LeitoReserva> LeitoReservaIdColaboradorNavigation { get; set; }
        public virtual ICollection<LeitoReserva> LeitoReservaIdPacienteNavigation { get; set; }
        public virtual ICollection<MedicoEspecialidade> MedicoEspecialidade { get; set; }
        public virtual ICollection<NotaEmitida> NotaEmitida { get; set; }
        public virtual ICollection<NotaEntrada> NotaEntradaIdFornecedorNavigation { get; set; }
        public virtual ICollection<NotaEntrada> NotaEntradaIdTransportadoraNavigation { get; set; }
        public virtual ICollection<NotaExcluida> NotaExcluida { get; set; }
        public virtual ICollection<ObservacaoAgendacc> ObservacaoAgendacc { get; set; }
        public virtual ICollection<ObservacaoAgendasadt> ObservacaoAgendasadt { get; set; }
        public virtual ICollection<OperadoraCodigoHospital> OperadoraCodigoHospital { get; set; }
        public virtual ICollection<OperadoraEmpresaConveniada> OperadoraEmpresaConveniadaIdOperadoraNavigation { get; set; }
        public virtual ICollection<OperadoraEmpresaConveniada> OperadoraEmpresaConveniadaIdPessoaNavigation { get; set; }
        public virtual ICollection<OperadoraEmpresaPagante> OperadoraEmpresaPagante { get; set; }
        public virtual ICollection<OperadoraEspecialidade> OperadoraEspecialidade { get; set; }
        public virtual ICollection<OperadoraHistorico> OperadoraHistorico { get; set; }
        public virtual ICollection<OperadoraModuloDigitoVerificador> OperadoraModuloDigitoVerificador { get; set; }
        public virtual ICollection<OperadoraParametro> OperadoraParametro { get; set; }
        public virtual ICollection<OperadoraRecebimento> OperadoraRecebimento { get; set; }
        public virtual ICollection<OperadoraUnidadeOrganizacionalCredenciada> OperadoraUnidadeOrganizacionalCredenciada { get; set; }
        public virtual ICollection<OrcamentoValoresOpme> OrcamentoValoresOpme { get; set; }
        public virtual ICollection<OrdemCompra> OrdemCompra { get; set; }
        public virtual ICollection<OrdemCompraCaracteristica> OrdemCompraCaracteristica { get; set; }
        public virtual ICollection<OrdemServicoExameExamePrioridadeEtapa> OrdemServicoExameExamePrioridadeEtapaIdFuncResponsavelNavigation { get; set; }
        public virtual ICollection<OrdemServicoExameExamePrioridadeEtapa> OrdemServicoExameExamePrioridadeEtapaIdPrestadorNavigation { get; set; }
        public virtual ICollection<OrdemServico> OrdemServicoIdFuncAberturaNavigation { get; set; }
        public virtual ICollection<OrdemServico> OrdemServicoIdFuncExecutanteNavigation { get; set; }
        public virtual ICollection<OrdemServico> OrdemServicoIdMedicoSolicitanteNavigation { get; set; }
        public virtual ICollection<OrdemServicoServico> OrdemServicoServico { get; set; }
        public virtual ICollection<PacoteFaturamento> PacoteFaturamento { get; set; }
        public virtual ICollection<PedidoDeSangueHemoplus> PedidoDeSangueHemoplus { get; set; }
        public virtual ICollection<PessoaCaracteristica> PessoaCaracteristica { get; set; }
        public virtual ICollection<PessoaCaracteristicaHistorico> PessoaCaracteristicaHistorico { get; set; }
        public virtual ICollection<PessoaCorreioEletronico> PessoaCorreioEletronico { get; set; }
        public virtual ICollection<PessoaCorreioEletronicoHistoricoNaoRegistro> PessoaCorreioEletronicoHistoricoNaoRegistro { get; set; }
        public virtual ICollection<PessoaEndereco> PessoaEndereco { get; set; }
        public virtual ICollection<PessoaHistorico> PessoaHistorico { get; set; }
        public virtual ICollection<PessoaImagem> PessoaImagem { get; set; }
        public virtual ICollection<PessoaPessoa> PessoaPessoaIdPessoaFilhoNavigation { get; set; }
        public virtual ICollection<PessoaPessoa> PessoaPessoaIdPessoaPaiNavigation { get; set; }
        public virtual ICollection<PessoaPlano> PessoaPlano { get; set; }
        public virtual ICollection<PessoaPlanoContas> PessoaPlanoContas { get; set; }
        public virtual ICollection<PessoaRelacionamento> PessoaRelacionamento { get; set; }
        public virtual ICollection<PessoaTelefone> PessoaTelefone { get; set; }
        public virtual ICollection<PessoaUrl> PessoaUrl { get; set; }
        public virtual ICollection<Plano> Plano { get; set; }
        public virtual ICollection<PlanoEmpresaConveniada> PlanoEmpresaConveniada { get; set; }
        public virtual ICollection<PlanoOperadoraCategoria> PlanoOperadoraCategoria { get; set; }
        public virtual ICollection<PlanoRede> PlanoRede { get; set; }
        public virtual ICollection<PlanoTratamentoOncologia> PlanoTratamentoOncologia { get; set; }
        public virtual ICollection<ProcedimentoPedido> ProcedimentoPedido { get; set; }
        public virtual ICollection<ProcedimentosServico> ProcedimentosServico { get; set; }
        public virtual ICollection<ProdutoDetalheFabricante> ProdutoDetalheFabricante { get; set; }
        public virtual ICollection<ProdutoDetalheFabricanteCodigoBarras> ProdutoDetalheFabricanteCodigoBarras { get; set; }
        public virtual ICollection<ProdutoDetalheFabricanteServicoProdutoTabelaOperadora> ProdutoDetalheFabricanteServicoProdutoTabelaOperadora { get; set; }
        public virtual ICollection<ProdutoDetalheOperadoraServicoCaracteristicaTipo> ProdutoDetalheOperadoraServicoCaracteristicaTipo { get; set; }
        public virtual ICollection<ProdutoFabricante> ProdutoFabricante { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public virtual ICollection<ProdutoNaoCoberto> ProdutoNaoCoberto { get; set; }
        public virtual ICollection<ProdutoNaoCobrado> ProdutoNaoCobrado { get; set; }
        public virtual ICollection<ProdutoQtdeAutorizada> ProdutoQtdeAutorizada { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversao> ProdutoUnidadeMedidaConversao { get; set; }
        public virtual ICollection<ProdutoUnidadeMedidaConversaoHistorico> ProdutoUnidadeMedidaConversaoHistorico { get; set; }
        public virtual ICollection<ProfissionalSaudeCbo> ProfissionalSaudeCbo { get; set; }
        public virtual ICollection<ProfissionalSaudeOperadora> ProfissionalSaudeOperadoraIdOperadoraNavigation { get; set; }
        public virtual ICollection<ProfissionalSaudeOperadora> ProfissionalSaudeOperadoraIdProfissionalNavigation { get; set; }
        public virtual ICollection<RecusaMaterial> RecusaMaterialIdFornecedorNavigation { get; set; }
        public virtual ICollection<RecusaMaterial> RecusaMaterialIdTransportadoraNavigation { get; set; }
        public virtual ICollection<RegistroEletronico> RegistroEletronico { get; set; }
        public virtual ICollection<RegistroEletronicoArquivo> RegistroEletronicoArquivo { get; set; }
        public virtual ICollection<RegistroEletronicoModeloServico> RegistroEletronicoModeloServico { get; set; }
        public virtual ICollection<Relacionamento> Relacionamento { get; set; }
        public virtual ICollection<RepasseCustoOperacionalPacote> RepasseCustoOperacionalPacote { get; set; }
        public virtual ICollection<RepasseExcecaoHistorico> RepasseExcecaoHistorico { get; set; }
        public virtual ICollection<RepasseMedicoHistorico> RepasseMedicoHistoricoIdClinicaNavigation { get; set; }
        public virtual ICollection<RepasseMedicoHistorico> RepasseMedicoHistoricoIdMedicoNavigation { get; set; }
        public virtual ICollection<RepasseMedico> RepasseMedicoIdClinicaNavigation { get; set; }
        public virtual ICollection<RepasseMedico> RepasseMedicoIdMedicoNavigation { get; set; }
        public virtual ICollection<RepasseOperadoraUnidadeOrganizacionalServico> RepasseOperadoraUnidadeOrganizacionalServico { get; set; }
        public virtual ICollection<ReservaHorarioSadt> ReservaHorarioSadt { get; set; }
        public virtual ICollection<RestricaoServico> RestricaoServico { get; set; }
        public virtual ICollection<RetornoArquivo> RetornoArquivo { get; set; }
        public virtual ICollection<SacOcorrencia> SacOcorrencia { get; set; }
        public virtual ICollection<ServicoClassificacaoHospitalSus> ServicoClassificacaoHospitalSus { get; set; }
        public virtual ICollection<ServicoExcecao> ServicoExcecao { get; set; }
        public virtual ICollection<ServicoExcecaoPlano> ServicoExcecaoPlano { get; set; }
        public virtual ICollection<ServicoGuia> ServicoGuia { get; set; }
        public virtual ICollection<ServicoOperadoraPlanoServicoCaracteristicaTipo> ServicoOperadoraPlanoServicoCaracteristicaTipo { get; set; }
        public virtual ICollection<ServicoOperadoraServicoCaracteristicaTipo> ServicoOperadoraServicoCaracteristicaTipo { get; set; }
        public virtual ICollection<ServicoOperadoraServicoProdutoTabela> ServicoOperadoraServicoProdutoTabela { get; set; }
        public virtual ICollection<ServicoOperadoraServicoProdutoTabelaPlano> ServicoOperadoraServicoProdutoTabelaPlano { get; set; }
        public virtual ICollection<ServicoPreco> ServicoPreco { get; set; }
        public virtual ICollection<ServicoPrecoSus> ServicoPrecoSus { get; set; }
        public virtual ICollection<ServicoProdutoTabela> ServicoProdutoTabela { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadora> ServicoProdutoTabelaOperadora { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProduto> ServicoProdutoTabelaOperadoraClassificacaoProduto { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa> ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativa { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico> ServicoProdutoTabelaOperadoraClassificacaoProdutoAlternativaHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo> ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupo { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico> ServicoProdutoTabelaOperadoraClassificacaoProdutoGrupoHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaOperadoraHistorico> ServicoProdutoTabelaOperadoraHistorico { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo> ServicoProdutoTabelaPlanoClassificacaoProdutoGrupo { get; set; }
        public virtual ICollection<ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico> ServicoProdutoTabelaPlanoClassificacaoProdutoGrupoHistorico { get; set; }
        public virtual ICollection<ServicoQuantidadeAutorizada> ServicoQuantidadeAutorizada { get; set; }
        public virtual ICollection<ServicoReducaoAcrescimo> ServicoReducaoAcrescimo { get; set; }
        public virtual ICollection<ServicoServicoProdutoTabelaOperadora> ServicoServicoProdutoTabelaOperadora { get; set; }
        public virtual ICollection<ServicoTraducaoVigencia> ServicoTraducaoVigencia { get; set; }
        public virtual ICollection<SessaoPortal> SessaoPortal { get; set; }
        public virtual ICollection<Solicitacao> Solicitacao { get; set; }
        public virtual ICollection<Tissfinalidade> Tissfinalidade { get; set; }
        public virtual ICollection<TissfinalidadeOperadora> TissfinalidadeOperadora { get; set; }
        public virtual ICollection<Tissmensagem> Tissmensagem { get; set; }
        public virtual ICollection<Tributo> Tributo { get; set; }
        public virtual ICollection<UnidadeOrganizacional> UnidadeOrganizacional { get; set; }
        public virtual ICollection<UnidadeOrganizacionalColaborador> UnidadeOrganizacionalColaborador { get; set; }
        public virtual ICollection<UnidadeOrganizacionalHorarioAgendaBaseAgenda> UnidadeOrganizacionalHorarioAgendaBaseAgenda { get; set; }
        public virtual ICollection<UnidadeOrganizacionalHorarioAgendaMarcacao> UnidadeOrganizacionalHorarioAgendaMarcacao { get; set; }
        public virtual ICollection<UnidadeOrganizacionalHorarioAgendaReserva> UnidadeOrganizacionalHorarioAgendaReserva { get; set; }
        public virtual ICollection<UnidadeOrganizacionalOperadoraPlanoServicoAutomatico> UnidadeOrganizacionalOperadoraPlanoServicoAutomatico { get; set; }
        public virtual ICollection<UsuarioOperadora> UsuarioOperadora { get; set; }
    }
}