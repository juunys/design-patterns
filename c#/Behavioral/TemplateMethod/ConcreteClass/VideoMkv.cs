using System;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClass
{
	public class VideoMkv : VideoPlayer
    {
        public override void DecodeVideoFormat()
        {
            Console.WriteLine("O vídeo está sendo processado com o Decode MKV");
        }
    }
}

