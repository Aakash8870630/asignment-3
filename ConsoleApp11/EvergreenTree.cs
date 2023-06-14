using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class EvergreenTree : Tree //Business
    {
        public EvergreenTree()
        {
        }

        //public EvergreenTree(string name, int age) : base(name, age)
        //{
        //}

        public EvergreenTree(decimal houseAge, decimal houseSize, decimal paddockSize, string ccNumber) : base(houseAge, houseSize, paddockSize, ccNumber)
        {
        }

        private bool needSofaset;

        public bool SofaSet
        {
            get => needSofaset;
            set => needSofaset = value;
        }

        public override void AdditionalAction()
        {
            Console.WriteLine("Customer lobbies created\n");
        }

        public override string ToString()
        {
            return string.Format("\nBusiness owners {0} {1}", base.ToString(), needSofaset ? "with sofa set" : "without sofa set");
        }
    }
}
