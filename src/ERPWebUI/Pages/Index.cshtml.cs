using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADOS.Data;
using Framework.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ERPWebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HospitaleDbContext _context;

        public IndexModel(ILogger<IndexModel> logger,
            HospitaleDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            var pXML = new ParametrosXml
            {
                { "ID_STATUS", 3 }
            };
            string innerXml = pXML.ToXML().InnerXml;

            var atendimento = new DADOS.OBJETOS.Atendimento(4029993);
            ViewData["PacienteGerador"] = atendimento.PESSOA.NM_PESSOA;

            var atend = _context.Atendimento
                .Include(a => a.IdPessoaNavigation)
                .Where(a => a.IdAtendimento == 4029993)
                .First();

            ViewData["PacienteEF"] = atend.IdPessoaNavigation.NmPessoa;
        }
    }
}
