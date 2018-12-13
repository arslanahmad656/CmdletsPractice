using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace GetProc
{
    [Cmdlet(VerbsCommon.Get, "Proc")]
    public class GetProc : Cmdlet
    {
        protected override void BeginProcessing()
        {
            WriteDebug("Begin processing");
        }

        protected override void EndProcessing()
        {
            WriteDebug("End processing");
        }

        protected override void ProcessRecord()
        {
            WriteDebug("Process record");
            WriteObject(System.Diagnostics.Process.GetProcesses(), true);
        }

        protected override void StopProcessing()
        {
            WriteDebug("Stopp processing");
        }
    }
}
