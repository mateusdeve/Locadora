using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Filmes
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime duracao { get; set; }
        public int ano { get; set; }
        [Display(Name = "Classificação")]
        public int classificacao_id { get; set; }
        public int produtora_id { get; set; }
    }

}
