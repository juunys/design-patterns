using System;
namespace TemplateMethod.AbstractClass
{
	public abstract class VideoPlayer
	{
		// Template Method
		public void ExecuteVideo()
		{
			LoadFile();
			DecodeVideoFormat();
			InitiateExecution();
		}

        // default procedure
        public void LoadFile()
		{
			Console.WriteLine("Arquivo de video carregado...\n");
		}

        // procedure that will be overwritten
        public abstract void DecodeVideoFormat();

		// default procedure
		public void InitiateExecution()
		{
            Console.WriteLine("O vídeo iniciou a execução...\n");
        }

    }
}

