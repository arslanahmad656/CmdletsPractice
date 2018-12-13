using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.ComponentModel;

namespace GetProc
{
    [RunInstaller(true)]
    public class GetProcSnapIn : PSSnapIn
    {
        public override string Name => "GetProcSnapin";

        public override string Vendor => "RAVIAN656";

        public override string Description => "RAVIAN656.GetProcSnapIn";
    }
}
