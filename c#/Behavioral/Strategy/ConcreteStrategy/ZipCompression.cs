using System;
using Strategy.Strategy;

namespace Strategy.ConcreteStrategy
{
	public class ZipCompression : ICompression
	{
        public void CompressFile(string filename)
        {
            Console.WriteLine($"\nO arquivo '{filename}' foi compactado usando o método Zip.\n Um arquivo com extensão .zip foi criado");
        }
    }
}

