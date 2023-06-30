using TemplateMethod.AbstractClass;
using TemplateMethod.ConcreteClass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Template Method ###");
        Console.ReadLine();

        Console.WriteLine("------------ Video Player - video MP4 ---------------\n");
        VideoPlayer fileVideo = new VideoMp4();
        fileVideo.LoadFile();
        fileVideo.DecodeVideoFormat();
        fileVideo.InitiateExecution();

        Console.WriteLine("------------ Video Player - video MKV ---------------\n");
        fileVideo = new VideoMkv();
        fileVideo.LoadFile();
        fileVideo.DecodeVideoFormat();
        fileVideo.InitiateExecution();

        Console.ReadLine();
    }
}