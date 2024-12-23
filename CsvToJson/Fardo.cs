using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToJson
{
	public class Fardo
	{
        public Fardo() {
            Id = Guid.NewGuid().ToString("N");
        }

		public string Id { get; }
        public string? Deposito { get; set; }
        public required string Item { get; set; }
        public required string Descricao { get; set; }
        public required string Un { get; set; }
		public required string Lote { get; set; }
        public required string Qtde { get; set; }
	}
}
