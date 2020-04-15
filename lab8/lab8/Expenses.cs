using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Expenses : Form
    {
        private static Expenses instance;

        public static Expenses getInstance()
        {

            if (instance == null)
            {
                instance = new Expenses();
            }

            return instance;

        }

        public Expenses()
        {
            InitializeComponent();
            Draw();

        }
        public void Draw()
        {
            if (DataCollecter.getInstance().MonthCounter <= 1)
            {
                panel1.Visible = false;
                NoInfoLbl.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                NoInfoLbl.Visible = false;
                IncomeLbl.Text = DataCollecter.getInstance().IncomeOfPreviousMonth.ToString();
                SoldCarsLbl.Text = SoldCars.getInstance().TotalSoldCars.ToString();
                CarsInTOLbl.Text = SoldCars.getInstance().soldCars.Count().ToString();
                IncomeBoostlbl.Text = DataCollecter.getInstance().SellingBoostUp.ToString();
                StuffRewardLbl.Text = DataCollecter.getInstance().Reward.ToString();
            }
            
        }
    }
}
