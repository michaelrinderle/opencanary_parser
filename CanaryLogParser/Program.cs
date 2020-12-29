using CanaryLogParser.Models;

namespace CanaryLogParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Database data = new Database("./opencanary.log");
            // data.printPorts();

            data.printCreds();
        }
    }
}
