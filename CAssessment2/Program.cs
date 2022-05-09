using CAssessment2.Config;
using CAssessment2.Services;
using System;

namespace CAssessment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContainerConfig.Init();
                var runner = ContainerConfig.GetInstance<IRunner>();

                runner.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
