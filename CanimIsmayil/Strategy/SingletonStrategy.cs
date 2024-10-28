using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanimIsmayil.Strategy
{
    internal class SingletonStrategy : BaseStrategy
    {
        public override void Register()
        {
            Console.WriteLine("Singleton");
        }
    }
}
