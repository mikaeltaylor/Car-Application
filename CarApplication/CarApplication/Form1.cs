using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApplication
{
 
    public partial class CarApplication : Form
    {
        int speed;
        int newSpeed;
        string make;
        string model;
        int year;
        
        public CarApplication()
        {
            //Let's initialize everything in the form, get things started.
            Car car = new Car(make, year, model);//Have to initialize this to have the correct speed of 0 for our speed label.
            InitializeComponent();
            lblSpeedOutput.Text = Convert.ToString(car.speed);//And... here's that speed of 0 for our speed label.
        }

        private void btnAccel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) && string.IsNullOrWhiteSpace(txtYear.Text))
            {//Make sure the user input isn't empty, and prompt for input otherwise.
                MessageBox.Show("Please enter a value for Make, and Year and then click submit.");
            }
            else
            {
                Car car = new Car(make, year, model);
                newSpeed = speed += 5;//Add 5 to speed
                car.speed = newSpeed;//Update the speed.
                car.make = txtMake.Text;//Bring in user input for make
                car.year = Convert.ToInt32(txtYear.Text);//Bring in user input for year.
                lblSpeedOutput.Text = Convert.ToString(car.speed);//Update the speed label
            }
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMake.Text) && string.IsNullOrWhiteSpace(txtYear.Text))
            {//Make sure the user entered valid data, and hits submit first.
                MessageBox.Show("Please enter a value for Make, Model, and Year and click submit.");
            }
            else
            {//If they did, continue
                Car car = new Car(make, year, model);
                if (speed > 0)//As long as the speed is greater than 0, allow them to brake. 
                {
                    newSpeed = speed -= 5;//Subtract five from the speed.
                    car.speed = newSpeed;//Update the speed.
                    lblCarOutput.Text = "Car: " + car.year + " " + car.make + " " + car.model;//Update the car output label.
                    lblSpeedOutput.Text = Convert.ToString(car.speed);//Update the label with correct speed information.
                }
                else { MessageBox.Show("The vehicle is stopped. Braking is futile at this point."); }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) && string.IsNullOrWhiteSpace(txtModel.Text) && string.IsNullOrWhiteSpace(txtYear.Text))
            {//Make sure the user input has been entered.
                MessageBox.Show("Please input valid entries for Make, Model, and year of the vehicle");
            }
            else
            {
                make = txtMake.Text;//Make of the vehicle from user input
                model = txtModel.Text;//Model of the vehicle from user input
                year = Convert.ToInt32(txtYear.Text);//Year of the vehicle from user input
                if (year > 1807 && year < 2017)
                {//If the car has a valid year..
                    Car car = new Car(make, year, model);
                    lblCarOutput.Text = "Car: " + car.year + " " + car.make + " " + car.model;
                    car.speed = 0;
                    lblSpeedOutput.Text = Convert.ToString(car.speed);
                }//Otherwise, send out an informational error message prompting for a valid year.
                else { MessageBox.Show("In 1807, François Isaac de Rivaz designed the first car powered by an internal combustion engine fueled by hydrogen. In 1886 the first petrol or gasoline powered automobile the Benz Patent-Motorwagen was invented by Karl Benz. Unless history has rewritten itself, we'll need a valid year for the automobile please."); }
            }
        }
    }
}