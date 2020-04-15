using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class SoldCars
    {
        public int TechObservRemain = 4, DaysBeforeNextObserve = 30, TechObsserveCost = 250, TotalSoldCars = 0;
        public List<SoldCars> soldCars = new List<SoldCars>();
        private static SoldCars instance;

        public delegate void Container();

        public event Container ObserveProgram;

        public static SoldCars getInstance()
        {

            if (instance == null)
            {
                instance = new SoldCars();
            }
            return instance;

        }
        public void AddCarToObserveProgramm()
        {
            instance.soldCars.Add(new SoldCars());
            instance.TotalSoldCars++;
        }
        public void CheckForObserveDate()
        {

            foreach (var car in instance.soldCars.ToArray())
            {

                car.DaysBeforeNextObserve--;
                if (car.DaysBeforeNextObserve == 0)
                {
                    ObserveProgram();

                    car.TechObservRemain--;
                    if (car.TechObservRemain == 0)
                    {
                        instance.soldCars.Remove(car);
                        
                        continue;
                    }
                    car.DaysBeforeNextObserve = 30;
                }
            }
            
        }
    }
}
