using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public enum HouseTypes
    {
        House = 1,
        Business,
        Farmers
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }

        public void Go()
        {
            string answer = string.Empty;

            using (NurseryList nl = new NurseryList())
            {
                do
            {
                string stringAgeOfHouse = string.Empty;
                decimal houseAge = 0;
                do
                {
                    Console.Write("\nEnter house age [0 - 50]: ");
                    stringAgeOfHouse = Console.ReadLine();

                } while (!(decimal.TryParse(stringAgeOfHouse, out houseAge) && houseAge >= 0 && houseAge <= 50));

                string sizeOfHouse = string.Empty;
                decimal houseSize = 0;
                do
                {
                    Console.Write("Enter house size in sqyd [50 - 1000] : ");
                    sizeOfHouse = Console.ReadLine();

                } while (!(decimal.TryParse(sizeOfHouse, out houseSize) && houseSize >= 50 && houseSize <= 1000));

                string sizeOfPaddock = string.Empty;
                decimal paddockSize = 0;
                do
                {
                    Console.Write("Enter paddock size in sqyd [50 - 200] : ");
                    sizeOfPaddock = Console.ReadLine();

                } while (!(decimal.TryParse(sizeOfPaddock, out paddockSize) && paddockSize >= 50 && paddockSize <= 200));

                string ccNumber = string.Empty;
                var v = new NurseryList();
                do
                {
                    Console.Write("Enter credit card number [16 digits only] : ");
                    ccNumber = Console.ReadLine();
                } while (!v.CheckCreditCard(ccNumber));

                int ownerType = 0;
                string stringOwner = string.Empty;

                do
                {
                    Console.Write("Enter property owner[1-House, 2-Business, 3-Farmer]: ");
                    stringOwner = Console.ReadLine();
                }
                while (!(int.TryParse(stringOwner, out ownerType) && ownerType >= (int)HouseTypes.House && ownerType <= (int)HouseTypes.Farmers));

                Tree theProperty = null;
                switch (ownerType)
                {
                    case (int)HouseTypes.House:
                        theProperty = new BroadLeafTree()
                        {
                            HouseAge = houseAge,
                            HouseSize = houseSize,
                            PaddockSize = paddockSize,
                            CCNumber = ccNumber
                        };
                        string needHvac = string.Empty;
                        do
                        {
                            Console.Write("Do you need HVAC system?[Y/N]:");
                            needHvac = Console.ReadLine().ToUpper();
                        } while (needHvac.Length != 1 || (needHvac != "Y" && needHvac != "N"));
                        ((BroadLeafTree)theProperty).HVAC = (needHvac == "Y") ? true : false;
                        break;

                    case (int)HouseTypes.Business:
                        theProperty = new EvergreenTree()
                        {
                            HouseAge = houseAge,
                            HouseSize = houseSize,
                            PaddockSize = paddockSize,
                            CCNumber = ccNumber
                        };
                        string needSofaset = string.Empty;

                        do
                        {
                            Console.Write("Do you need sofaset?[Y/N]:");
                            needSofaset = Console.ReadLine().ToUpper();

                        } while (needSofaset.Length != 1 || (needSofaset != "Y" && needSofaset != "N"));
                        ((EvergreenTree)theProperty).SofaSet = (needSofaset == "Y") ? true : false;
                        break;

                    case (int)HouseTypes.Farmers:
                        theProperty = new FruitTree()
                        {
                            HouseAge = houseAge,
                            HouseSize = houseSize,
                            PaddockSize = paddockSize,
                            CCNumber = ccNumber
                        };
                        string needGrainCoolers = string.Empty;
                        do
                        {
                            Console.Write("Do you need grain coolers?[Y/N]:");
                            needGrainCoolers = Console.ReadLine().ToUpper();
                        } while (needGrainCoolers.Length != 1 || (needGrainCoolers != "Y" && needGrainCoolers != "N"));
                        ((FruitTree)theProperty).GrainCoolers = (needGrainCoolers == "Y") ? true : false;
                        break;
                }

                nl.Add(theProperty);

                Console.Write("Do you want to enter more?[Y/N]:");
                answer = Console.ReadLine().ToUpper();
            } while (answer.Length == 1 && answer.ToUpper() == "Y");

                nl.Sort();
                for (int i = 0; i < nl.Count(); i++)
                {
                    Console.WriteLine(nl[i]);
                    Console.WriteLine("Tree #{0}", i + 1);
                    nl[i].MyDel(); //printing process
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //using (NurseryList nl = new NurseryList())
            //{
            //    //House
            //    BroadLeafTree blt = new BroadLeafTree(51, 222, 123, "1111111111111111");
            //    nl.Add(blt);

            //    //Business
            //    EvergreenTree et = new EvergreenTree(51, 222, 123, "3333333333333333");
            //    nl.Add(et);

            //    //Farmers
            //    FruitTree ft = new FruitTree(51, 222, 123, "2222222222222222");
            //    nl.Add(ft);
            //    nl.Sort();
            //    for (int i = 0;i < nl.Count(); i++)
            //    {
            //        Console.WriteLine(nl[i]);
            //        Console.WriteLine("Tree #{0}", i + 1);
            //        nl[i].MyDel(); //printing process
            //    }
            //}
        }
    }
}
