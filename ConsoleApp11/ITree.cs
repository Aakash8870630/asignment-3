using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public delegate void TreeDelegate();
    public interface ITree : IComparable<ITree>
    {
        //int Age { get; set; }
        //string Name { get; set; }
        decimal HouseAge { get; set; }
        decimal HouseSize { get; set; }
        decimal PaddockSize { get; set; }
        string CCNumber { get; set; }

        //age, size, p size, cc variables(get and set) to be created
        TreeDelegate MyDel { get; set; }
        //void AddFertilizer();
        //void WaterTree();
        //design, estimation, workers methods to be declared
        void CreateDesign();
        void EstimateWork();
        void ArrageWorkers();

        void AdditionalAction();
    }
}
