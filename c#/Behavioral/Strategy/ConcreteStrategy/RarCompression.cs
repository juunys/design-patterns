using System;
using Strategy.Strategy;

namespace Strategy.ConcreteStrategy
{
	public class RarCompression : ICompression
	{
		public void CompressFile(string filename)
		{
			Console.WriteLine($"\nO arquivo '{filename}' foi compactado usando o método Rar.\n Um arquivo com extensão .rar foi criado");
		}
	}
}

