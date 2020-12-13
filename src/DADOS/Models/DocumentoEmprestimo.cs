﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DocumentoEmprestimo
    {
        public DocumentoEmprestimo()
        {
            DocumentoEmprestimoHistorico = new HashSet<DocumentoEmprestimoHistorico>();
        }

        /// <summary>
        /// identificado único do emprestimo
        /// </summary>
        public int IdEmprestimo { get; set; }
        /// <summary>
        /// status da tabela 386
        /// </summary>
        public int IdStatusEmprestimo { get; set; }
        /// <summary>
        /// número do atendimento, mas não é chave da tabela atendimento
        /// </summary>
        public int NrAtendimento { get; set; }
        /// <summary>
        /// número da conta, mas não é chave da tabela Conta
        /// </summary>
        public int? NrConta { get; set; }
        /// <summary>
        /// o paciente que o prontuário pertence, tabela PESSOA campo ID_PESSOA
        /// </summary>
        public int IdPaciente { get; set; }
        /// <summary>
        /// número de folhas que o prontuário possui
        /// </summary>
        public int? NrFolhas { get; set; }
        /// <summary>
        /// número da pasta aonde o prontuário está armazenado fisicametne
        /// </summary>
        public string NmPasta { get; set; }
        /// <summary>
        /// id da pessoa que pegou emprestado o prontuário
        /// </summary>
        public int IdEmprestado { get; set; }
        /// <summary>
        /// nome do setor da pessoa que pegou o emprestimo
        /// </summary>
        public string NmSetor { get; set; }
        /// <summary>
        /// data que o prontuário foi emprestado
        /// </summary>
        public DateTime DtEmprestimo { get; set; }
        /// <summary>
        /// data que o prontuário foi devolvido
        /// </summary>
        public DateTime? DtDevolucao { get; set; }
        public DateTime? DtRenovacao { get; set; }
        /// <summary>
        /// observação
        /// </summary>
        public string TxObservacao { get; set; }

        public virtual Pessoa IdEmprestadoNavigation { get; set; }
        public virtual Pessoa IdPacienteNavigation { get; set; }
        public virtual TipoDiversos IdStatusEmprestimoNavigation { get; set; }
        public virtual ICollection<DocumentoEmprestimoHistorico> DocumentoEmprestimoHistorico { get; set; }
    }
}