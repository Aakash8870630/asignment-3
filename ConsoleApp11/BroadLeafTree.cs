using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class BroadLeafTree : Tree //House
    {
        public BroadLeafTree()
        {
        }

        //public BroadLeafTree(string name, int age) : base(name, age)
        //{
        //}

        public BroadLeafTree(decimal houseAge, decimal houseSize, decimal paddockSize, string ccNumber) : base(houseAge, houseSize, paddockSize, ccNumber)
        {
        }

        private bool needHvac;

        public bool HVAC
        {
            get => needHvac;
            set => needHvac = value;
        }

        public override void AdditionalAction()
        {
            Console.WriteLine("Sun room created\n");
        }

        public override string ToString()
        {
            return string.Format("\nHouse owners {0} {1}", base.ToString(), needHvac ? "with HVAC system" : "without HVAC system");
        }
    }
}
