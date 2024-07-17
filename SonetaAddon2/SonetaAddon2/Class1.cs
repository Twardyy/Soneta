using Limilabs.Mail;
using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Text;
using SonetaAddon2;
using Soneta.Business.UI;

[assembly: Worker(typeof(SonetaAddon2.Class1), typeof(Soneta.Handel.DokHandlowe))]

namespace SonetaAddon2
{
    public class Class1
    {

        [Action("Test", Target = ActionTarget.Menu, Priority = 10002)]
        public object xdd()
        {
            return new MessageBoxInformation("TEST", "test1");
        }
    }
}
