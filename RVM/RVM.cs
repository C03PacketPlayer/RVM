using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVM
{
    public class RVM : IDisposable
    {
        public static RVM INSTANCE = new RVM();

        public float classVersion = 10;

        public void start()
        {
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        public void Dispose()
        {
            
        }
    }
}
