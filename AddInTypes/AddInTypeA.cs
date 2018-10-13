using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInTypes
{
    public class AddInTypeA : HostSDK.IAddIn
    {
        public string DoSomeThing(int x)
        {
            return "AddInTypeA: " + x.ToString();
        }
    }
}
