using System;
using Bridge.Domain;

namespace Bridge.Implementor
{
	public interface IGenerateFile
	{
		void SaveFile(Employee employee);
	}
}

