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
    public partial class Form1 : Form
    {
        float Pocket;
        Random rnd;
        Expenses expenses;
        

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            Pocket = 750000;
            PocketLbl.Text = Pocket.ToString() + '$';
            
            rnd = new Random();
            Filial.getInstance().ChoseCount += CarNumbChoose;
            SoldCars.getInstance().ObserveProgram += RealizeObserveProgram;

            
            
        }


        // statistics clicker
        

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            expenses = new Expenses();

            expenses.Show();

            
        }
        

        //filials buy/sell buttons
        private void BuyFillialBtn_Click(object sender, EventArgs e)
        {
            if (Pocket > Filial.getInstance().FilialPrice)
            { 
                Filial.getInstance().addFilial();

                FilialsLbl.Text = (Int32.Parse(FilialsLbl.Text) + 1).ToString();

                Pocket -= Filial.getInstance().FilialPrice;

                DataCollecter.getInstance().deboostIncome(Filial.getInstance().FilialPrice);

                PocketLbl.Text = Pocket.ToString() + " $";

                NotEnoughMoneyLbl.Visible = false;
            }
            else
            {
                NotEnoughMoneyLbl.Visible = true;
            }
        }
        
        

        //order cars block

        private void choserStateChanger(bool state)
        {
            trackBar1.Visible = state;

            ApproveBtn.Visible = state;

            DismissBtn.Visible = state;

            ValueLbl.Visible = state;
        }
        
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Filial.getInstance().OrderCars(Pocket);
        }

        private void CarNumbChoose()
        {
            trackBar1.Maximum = Filial.getInstance().MaxCarToBuy;

            choserStateChanger(true);
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            Filial.getInstance().CarsInGarage += trackBar1.Value;

            CarsLbl.Text = Filial.getInstance().CarsInGarage.ToString();

            Pocket -= trackBar1.Value * Filial.getInstance().CarPrice;

            DataCollecter.getInstance().deboostIncome(trackBar1.Value * Filial.getInstance().CarPrice);

            PocketLbl.Text = Pocket.ToString() + " $";

            choserStateChanger(false);

            trackBar1.Value = 0;
        }

        private void DismissBtn_Click(object sender, EventArgs e)
        {
            choserStateChanger(false);

            trackBar1.Value = 0;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ValueLbl.Text = trackBar1.Value.ToString();
        }

        //--------------------------------------------------------------------

        private void RealizeObserveProgram()
        {
            Pocket -= SoldCars.getInstance().TechObsserveCost;

            DataCollecter.getInstance().deboostIncome(SoldCars.getInstance().TechObsserveCost);

            PocketLbl.Text = Pocket.ToString() + " $";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = (Int32.Parse(Date.Text) + 1).ToString();
            

            if (Filial.getInstance().Filials.Count > 0)
            {
                Pocket += B_logic.DayActivity();

                PocketLbl.Text = Pocket.ToString() + " $";
            }
            

            StuffLbl.Text = (Filial.getInstance().StuffPerFilial * Filial.getInstance().Filials.Count).ToString();

            FilialsLbl.Text = Filial.getInstance().Filials.Count.ToString();

            CarsLbl.Text = Filial.getInstance().CarsInGarage.ToString();

            if (Int32.Parse(Date.Text) == 30)
            {
                Date.Text = "0";

                Month.Text = (Int32.Parse(Month.Text) + 1).ToString();

                Pocket += B_logic.MonthActivity();

                PocketLbl.Text = Pocket.ToString() + " $";
            }

            if (Int32.Parse(Month.Text) == 13)
            {
                Month.Text = "0";
                Year.Text = (Int32.Parse(Year.Text) + 1).ToString();
            }
        }
    }
}
