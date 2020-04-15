using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Filial
    {
        public int CarsInGarage = 0, SalaryFund = 20000, DaysBeforeSalary = 30, MaxCarToBuy = 0, CarPrice = 10000, FilialPrice = 250000, StuffPerFilial = 12, RewardPerFelial = 3000;
        
        public delegate void Container();
        
        public event Container ChoseCount;

        private static Filial instance;

        public List<Filial> Filials = new List<Filial>();

        public static Filial getInstance() {
            
                if (instance==null)
                {
                    instance = new Filial();
                }
                return instance;
             
        }
        public void addFilial()
        {
            instance.Filials.Add(new Filial());
        }


        public void OrderCars(float Money)
        {
            int PossibleCount = instance.Filials.Count * 50;

            
             PossibleCount -= instance.CarsInGarage;
            
            
            instance.MaxCarToBuy = Math.Min(PossibleCount, (int)(Money / instance.CarPrice));

            ChoseCount();
        }
       

        

    }
}
