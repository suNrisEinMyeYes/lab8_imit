using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class B_logic
    {

        public static int carsSold = 0;

        public static float DayActivity()
        {
            Random rnd = new Random();

            var filialsCount = Filial.getInstance().Filials.Count();

            int CarsBought = (rnd.Next() % 3) * filialsCount;

            float SoldGoodsIncome = (250 + rnd.Next() % 250) * filialsCount;

            float TechObservIncomes = ((2 - rnd.Next() % 2) * SoldCars.getInstance().TechObsserveCost)* filialsCount;

            float MoneyToChange = 0;

            int limit = CarsBought;


            if (CarsBought > Filial.getInstance().CarsInGarage)
            {
                limit = Filial.getInstance().CarsInGarage;
            }
            for (int i = 0; i < limit; i++)
            {
                SoldCars.getInstance().AddCarToObserveProgramm();
                
            }
            
            foreach (var filial in Filial.getInstance().Filials)
            {
                filial.DaysBeforeSalary--;
                if (filial.DaysBeforeSalary == 0)
                {
                    MoneyToChange -= filial.SalaryFund;
                    filial.DaysBeforeSalary = 30;
                }
            }

            MoneyToChange += limit * (Filial.getInstance().CarPrice + 5000)  + SoldGoodsIncome + TechObservIncomes;

            DataCollecter.getInstance().boostIncome(MoneyToChange);

            Filial.getInstance().CarsInGarage -= limit;

            SoldCars.getInstance().CheckForObserveDate();

            return MoneyToChange;
        }

        public static float MonthActivity()
        {
            DataCollecter.getInstance().deboostIncome(Filial.getInstance().CarsInGarage * 200);
            DataCollecter.getInstance().MonthController();
            return -Filial.getInstance().CarsInGarage * 200;
        }
    }
}
