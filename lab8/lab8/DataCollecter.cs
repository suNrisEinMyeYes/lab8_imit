using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class DataCollecter
    {
        private static DataCollecter instance;
        
        public static DataCollecter getInstance()
        {

            if (instance == null)
            {
                instance = new DataCollecter();
            }

            return instance;

        }

        public float income = 0, MonthCounter = 0, IncomeOfPreviousMonth = 0, DifferenceBetweenIncomes = 0, SellingBoostUp = 0;
        public bool Reward = false;
        
        public  void boostIncome(float EarnedMoney)
        {
            income += EarnedMoney;
        }
        public  void deboostIncome(float SpentMoney)
        {
            income -= SpentMoney;
        }

        public  void MonthController()
        {
            MonthCounter++;
            
            if (MonthCounter == 1)
            {
                IncomeOfPreviousMonth = income;
            }
            else
            {
                instance.DifferenceBetweenIncomes = instance.income - instance.IncomeOfPreviousMonth;

                instance.SellingBoostUp = Math.Abs(instance.DifferenceBetweenIncomes / instance.IncomeOfPreviousMonth);

                instance.Reward = false;

                if (instance.SellingBoostUp >=0.3 && instance.DifferenceBetweenIncomes > 0)
                {
                    instance.deboostIncome(Filial.getInstance().Filials.Count * Filial.getInstance().RewardPerFelial);
                    instance.Reward = true;
                }
                
                
                
                instance.IncomeOfPreviousMonth = instance.income;

            }

            instance.income = 0;
            
        }
    }
}
