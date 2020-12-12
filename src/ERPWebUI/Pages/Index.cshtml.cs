using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADOS.OBJETOS;
using Framework.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ERPWebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var pXML = new ParametrosXml
            {
                { "ID_STATUS", 3 }
            };
            string innerXml = pXML.ToXML().InnerXml;

            var atendimento = new Atendimento(4029993);
            ViewData["Paciente"] = atendimento.PESSOA.NM_PESSOA;
        }
    }
}
