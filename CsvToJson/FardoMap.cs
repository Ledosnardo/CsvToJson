using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToJson
{
	public class FardoMap : ClassMap<Fardo>
	{
		public FardoMap() {
			Map( f => f.Deposito).Name("Dep");
			Map( f => f.Item).Name("Item");
			Map( f => f.Descricao).Name("Descrição");
			Map( f => f.Un).Name("Un");
			Map( f => f.Lote).Name("Lote/Série");
			Map( f => f.Qtde).Name("Qtde Sistema");
		}
	}
}
