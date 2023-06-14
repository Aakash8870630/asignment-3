using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Tree : ITree
    {
        //private string name;
        //private int age;
        private decimal houseAge;
        private decimal houseSize;
        private decimal paddockSize;
        private string ccNumber;
        private TreeDelegate myDel = null;

        public Tree()
        {
            SetUpDelegate();
        }

        public Tree(decimal houseAge, decimal houseSize, decimal paddockSize, string ccNumber)
        {
            //this.name = name;
            //this.age = age;
            this.houseAge = houseAge;
            this.houseSize = houseSize;
            this.paddockSize = paddockSize;
            this.ccNumber = ccNumber;
            SetUpDelegate();
        }

        //public int Age { get => age; set => age = value; }
        //public string Name { get => name; set => name = value; }

        //public string HouseAge { get => houseAge; set => houseAge = value; }

        public decimal HouseAge { get => houseAge; set => houseAge = value; }
        public decimal HouseSize { get => houseSize; set => houseSize = value; }
        public decimal PaddockSize { get => paddockSize; set => paddockSize = value; }
        public string CCNumber { get => ccNumber; set => ccNumber = value; }
        public TreeDelegate MyDel { get => myDel; set => myDel = value; }

        //design, estimation, workers methods to be defined

        //public void WaterTree()
        //{
        //    Console.WriteLine("Tree Watered");
        //}

        //public void AddFertilizer()
        //{
        //    Console.WriteLine("Fertilizer Added");
        //}

        

        public abstract void AdditionalAction();

        public int CompareTo(ITree other)
        {
            return HouseAge.CompareTo(other.HouseAge);
        }

        //public override string ToString()
        //{
        //    return string.Format("Tree is {0} of Age {1}", name, age);
        //}

        /// <summary>
        /// cvsfasdfbhegfasCdvbngryhtegfweascdvfbghrytgwefadsvgbfnhtgrfed
        /// </summary>
        /// 
        public void CreateDesign()
        {
            Console.WriteLine("Design created");
        }

        public void EstimateWork()
        {
            Console.WriteLine("Estimation done");
        }

        public void ArrageWorkers()
        {
            Console.WriteLine("Workers arranged");
        }

        public override string ToString()
        {
            return string.Format("with {0} years of house age, {1} sqyd of house size, {2} sqyd of paddock size, credit card number {3} &", houseAge, houseSize, paddockSize, PrintCreditCard());
        }

        private string PrintCreditCard()
        {
            char[] ccNumArr = CCNumber.ToCharArray();
            for (int i = 4; i < 11; i++)
            {
                ccNumArr[i] = 'X';
            }
            return new string(ccNumArr);
        }

        private void SetUpDelegate()
        {
            //myDel += AddFertilizer;
            //myDel += WaterTree;
            myDel += CreateDesign;
            myDel += EstimateWork;
            myDel += ArrageWorkers;
            myDel += AdditionalAction;
        }
    }
}
