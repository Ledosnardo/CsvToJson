
using System.Text.Json.Serialization;

using Newtonsoft.Json;

static void Main(string[] args)
{
	Console.Write("Digite o caminho completo do arquivo CSV: ");
	string filePath = Console.ReadLine();

	try
	{
		var csvData = ConvertCsvToJson(filePath);
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Erro: {ex.Message}");
	}

	 string ConvertCsvToJson(string filePath)
	{
		var csvLines = File.ReadAllLines(filePath);

		var headers = csvLines[0].Split(',');
		var rows = new List< Dictionary<string, string> > ();

		for(var i = 1; i < csvLines.Length; i++)
		{
			var values = csvLines[i].Split(",");
			var rowDict = new Dictionary<string, string> ();

			for(var j = 0; i < headers.Length;)
			{
				rowDict[headers[j]] = values[j];
			}
			rows.Add(rowDict);
		}

		return "";
	}
}