using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInTypes
{
    public class AddInTypeB: HostSDK.IAddIn
    {
        public string DoSomeThing(int x)
        {
            return "AddInTypeB: " + (x*2).ToString();
        }
    }
}
