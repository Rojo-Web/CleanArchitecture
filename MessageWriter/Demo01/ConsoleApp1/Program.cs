using MyLibrary;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Write("hello");

            FiggleWriter FWriter = new FiggleWriter();
            FWriter.Write("hello");
        }
    }
}