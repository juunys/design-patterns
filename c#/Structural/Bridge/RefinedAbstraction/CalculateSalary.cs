 using System;
using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.RefinedAbstraction
{
	public class CalculateSalary : AbstractionGenerateFile
    {
		public CalculateSalary(IGenerateFile generateFile) : base(generateFile)
		{
		}

		public void ProcessEmployeeSalary(Employee employee)
		{
			employee.TotalSalary = employee.BaseSalary + employee.Incentive;

			Console.WriteLine($"Valor do Salário Total para o funcionário {employee.Id}" +
				$": R$ {employee.TotalSalary}");

			generateFile.SaveFile(employee);
		}
	}
}

