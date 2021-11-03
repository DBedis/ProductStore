using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical : Product
    {
        
        public string LabName { get; set; }
        public Adresse Myadresse{ get; set; }

        public override void GetMyType()
        {
            System.Console.WriteLine("\n Product : Chemical");
        }
    }
}
