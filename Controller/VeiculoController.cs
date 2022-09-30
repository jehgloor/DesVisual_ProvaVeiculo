using Microsoft.AspNetCore.Mvc;
using prova.Data;
using prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();
        private Context _context;

        public VeiculoController(Context context)
        {
            _context = context;
        }



            [HttpGet]
            public IEnumerable<Veiculo> BuscarTodos()
                {
                    return _context.Veiculos;
                }
        [HttpGet("{id}")]
        public IActionResult BuscaPorId(int id)
        {
            Veiculo veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.IdVeiculo == id);
            if(veiculo != null)
            {
                return Ok(veiculo);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult SalvarVeiculo([FromBody] Veiculo veiculo)
        {
            if(veiculo.Ano > 1930)
            {
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
                return CreatedAtAction(nameof(BuscaPorId), new { Id = veiculo.IdVeiculo }, veiculo);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public void DeletePorId(int id)
        {
            Veiculo veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.IdVeiculo == id);
            if(veiculo != null)
            {
                _context.Veiculos.Remove(veiculo);
                _context.SaveChanges();
            }
        }


    }
}
