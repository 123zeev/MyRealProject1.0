using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BAPDatabase;
using BAPWcf;

namespace BAPHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(BAPService));
            service.Open();
            Console.ReadLine();
        }
    }
}
