using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAssessment2.Services
{
    public class Runner : IRunner
    {
        private readonly ICorrectionService _correctionService;

        public Runner(ICorrectionService correctionService)
        {
            _correctionService = correctionService;
        }
        public void Run()
        {

            Console.WriteLine("Welcome to Grading Correction Interface!.");
            var command = string.Empty;
            do
            {
                command = Console.ReadLine();
                var result = _correctionService.MyAtoi(command);
                Console.WriteLine(result);
            }
            while (!command.Equals("exit", StringComparison.InvariantCultureIgnoreCase));

            Console.ReadKey();
        }
    }
}
