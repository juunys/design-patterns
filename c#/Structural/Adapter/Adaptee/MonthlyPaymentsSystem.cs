using System;
using Adapter.Domain;

namespace Adapter.Adaptee
{
	public class MonthlyPaymentsSystem
	{
		public void MontlhyPaymentCalculation(List<Student> studentsList)
		{
			foreach(Student st in studentsList)
			{
				Console.WriteLine(
					$"Aluno {st.Name} " +
					$"- Valor da mensalidade {st.MonthlyPayment}"
				);
			}
		}
	}
}

