
using CsvHelper;
using CsvHelper.Configuration;
using CsvToJson;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.PortableExecutable;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
	HasHeaderRecord = true
};

List<Fardo> listFardos;

using (var reader = new StreamReader("../../../epl.csv"))
using (var csv = new CsvReader(reader, config))
{
	csv.Context.RegisterClassMap<FardoMap>();
 
	listFardos = csv.GetRecords<Fardo>().ToList();

	Console.WriteLine(listFardos.Count);
}
