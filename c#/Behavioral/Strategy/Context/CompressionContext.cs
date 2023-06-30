using System;
using Strategy.Strategy;

namespace Strategy.Context
{
	public class CompressionContext
	{
		private ICompression _icompression;

		public CompressionContext(ICompression icompression)
		{
			_icompression = icompression;
		}

		public void DefineStrategy(ICompression icompression)
		{
			_icompression = icompression;
		}

		public void CreateCompressedFile(string filename)
		{
			_icompression.CompressFile(filename);
		}
	}
}

