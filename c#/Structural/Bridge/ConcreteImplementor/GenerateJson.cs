using System;
using System.Text.Json;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
	public class GenerateJson : IGenerateFile
	{
		private string fileName = "SalarioFuncionario.json";

		public void SaveFile(Employee employee)
		{
			var serializedEmployee = JsonSerializer.Serialize(employee);
			File.WriteAllText(fileName, serializedEmployee);

			Console.WriteLine($"Salário para o funcionário : {employee.Name} " +
				$"gerado com sucesso em : {fileName} \n");
		}
	}
}

