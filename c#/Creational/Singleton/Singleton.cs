using System;
namespace Singleton
{
	public class Singleton
	{
		private static Singleton instance = null;
		private int instanceNumber = 0;
		private static object lockObject = new object();

		private Singleton()
		{
			Console.WriteLine("Instantiating inside private constructor");
			instanceNumber++;
			Console.WriteLine($"Instance number: {instanceNumber} \n");
		}

		public static Singleton Instance
		{
			get
			{
				lock(lockObject)
				{
                    if (instance == null)
						instance = new Singleton();
                }
				return instance;
			}
		}
	}
}

