using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFxClassLibrary
{
    public class TestClass
    {
        public static Task<int> DoSomethingAsync()
        {
            return Task.Factory.StartNew(async () =>
            {
                await Task.Delay(1000);
                return 100;
            }).Unwrap();
        }
    }
}
