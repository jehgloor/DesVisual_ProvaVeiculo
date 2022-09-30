using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model
{
    public class Veiculo
    {
        [Key]
        
        public int IdVeiculo { get; set; }
        
        public string Descricao { get; set; }
        
        public int Ano { get; set; }
        
        public string Placa { get; set; }
        [Required (ErrorMessage = " O modelo é obrigatório")]
        public string Modelo { get; set; }
        
        public string Marca { get; set; }
        
        public string Cor { get; set; }
    }
}
