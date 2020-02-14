using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {

        List<Car> carsList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;
            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Car c = new Car(year, make, colour, mileage);

            carsList.Add(c);
            outputLabel.Text = "";
            //for (int i = 0; i < carsList.Count; i++)
            //{
            //    outputLabel.Text += carsList[i].year + " " +
            //        carsList[i].make + " " + carsList[i].colour
            //        + " " + carsList[i].mileage + "\n";
            //}

            foreach(Car car in carsList)
            {
                outputLabel.Text += car.year + " " + car.make + " " + car.colour + " " + car.mileage + "\n";
            }

        }
    }
}
