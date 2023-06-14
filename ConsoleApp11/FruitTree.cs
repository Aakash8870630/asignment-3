using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class FruitTree : Tree //Farmers
    {
        public FruitTree()
        {
        }

        //public FruitTree(string name, int age) : base(name, age)
        //{
        //}

        public FruitTree(decimal houseAge, decimal houseSize, decimal paddockSize, string ccNumber) : base(houseAge, houseSize, paddockSize, ccNumber)
        {
        }

        private bool needGrainCoolers;

        public bool GrainCoolers
        {
            get => needGrainCoolers;
            set => needGrainCoolers = value;
        }

        public override void AdditionalAction()
        {
            Console.WriteLine("Grain storage areas created\n");
        }

        public override string ToString()
        {
            return string.Format("\nFarmers {0} {1}", base.ToString(), needGrainCoolers ? "with grain coolers" : "without grain coolers");
        }
    }
}
