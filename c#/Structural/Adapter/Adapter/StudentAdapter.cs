using System;
using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
	public class StudentAdapter : ITarget
	{
		private MonthlyPaymentsSystem monthlyPaymentsSystem = new MonthlyPaymentsSystem();

		public void ProcessMonthlyPaymentCalculation(string[,] studentsArray)
		{
			string Id = null;
			string Name = null;
			string Course = null;
			string MonthlyPayment = null;

			List<Student> studentsList = new List<Student>();

            for (int i = 0; i < studentsArray.GetLength(0); i++)
			{
				for (int j = 0; j < studentsArray.GetLength(1); j++)
				{
					if (j == 0)
					{
						Id = studentsArray[i, j];
					}
					else if (j == 1)
					{
						Name = studentsArray[i, j];
					}
					else if (j == 1)
					{
						Course = studentsArray[i, j];
                    }
					else
					{
						if (studentsArray[i, j] != null)
						{
                            MonthlyPayment = studentsArray[i, j];
                        }
                    }
				}
			}

			studentsList.Add(new Student(Convert.ToInt32(Id), Name, Course, Convert.ToDecimal(MonthlyPayment)));

			Console.WriteLine("O adapter converteu o Array[] para List<> de Alunos \n");
            Console.WriteLine("E delegou ao Sistema mensalidades o processamento" + "da mensalidade dos alunos\n");

			monthlyPaymentsSystem.MontlhyPaymentCalculation(studentsList);
        }
	}
}

