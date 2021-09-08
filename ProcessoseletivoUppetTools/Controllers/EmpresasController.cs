using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessoseletivoUppetTools.Context;
using ProcessoseletivoUppetTools.Libraries.ApisExt;
using ProcessoseletivoUppetTools.Models;
using ProcessoseletivoUppetTools.Models.RetornoApi;

namespace ProcessoseletivoUppetTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ApiCnpjDevHub _apiCnpjDevHub;

        public EmpresasController(AppDbContext context, ApiCnpjDevHub apiCnpjDevHub)
        {
            _context = context;
            _apiCnpjDevHub = apiCnpjDevHub;
        }

        // GET: api/Empresas
        [HttpGet]
        public ActionResult<IEnumerable<Empresa>> GetEmpresas()
        {
            return _context.Empresas.ToList();
        }

        // GET: api/Empresas/5
        [HttpGet("{CNPJ}")]
        public async Task<ActionResult<Empresa>> GetEmpresa(string CNPJ)
        {
            var empresa = await _context.Empresas.FindAsync(CNPJ);

            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }

       

        // POST: api/Empresas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresa([FromBody] Empresa empresa)
        {
            Root  root = _apiCnpjDevHub.RetornoApi(empresa.Cnpj);

            if (root.@return == "OK" && root.status == true)
            {
                bool empresaExists = EmpresaExists(empresa.Cnpj);
                if (empresaExists)
                {
                    empresa = _apiCnpjDevHub.AdicionarEmpresa(root.result);

                    _context.Empresas.Add(empresa);
                    await _context.SaveChangesAsync();

                    return this.Ok(empresa);
                }
                else
                    return this.BadRequest("Empresa cadastrada no Sistema");
            }

            return this.BadRequest(root.message);


        }

        // DELETE: api/Empresas/5
        [HttpDelete("{CNPJ}")]
        public async Task<IActionResult> DeleteEmpresa(string CNPJ)
        {
            var empresa = await _context.Empresas.FindAsync(CNPJ);
            if (empresa == null)
            {
                return NotFound();
            }

            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpresaExists(string CNPJ)
        {
            return _context.Empresas.Any(e => e.Cnpj == CNPJ);
        }
    }
}
