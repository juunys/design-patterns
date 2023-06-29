using System;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
	public abstract class AbstractionGenerateFile
	{
		protected IGenerateFile generateFile;

		protected AbstractionGenerateFile(IGenerateFile generateFile)
		{
			this.generateFile = generateFile;
		}

		public virtual void SaveFile(Employee employee)
		{
			generateFile.SaveFile(employee);
		}
	}
}

