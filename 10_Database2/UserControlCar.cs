using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Database2
{
    public partial class UserControlCar : UserControl
    {
        Car car;
        public UserControlCar()
        {
            InitializeComponent();
        }
        public UserControlCar(Car car)
        {
            InitializeComponent();
            this.car = car;
            textBoxMark.Text = car.Mark;
            numericUpDownPrice.Value = car.Price;
        }

        internal void prepareCarSave(Person person)
        {
            if (checkBoxDelete.Checked)
            {
                if (car != null)
                {
                    FormMain.DatabaseDT.Cars.DeleteOnSubmit(car);
                }
            }
            else
            {
                if (car == null)
                {
                    car = new Car();
                    //car.Person = person;
                    person.Cars.Add(car);
                    //FormMain.DatabaseDT.Cars.InsertOnSubmit(car);
                }
                car.Mark = textBoxMark.Text;
                car.Price = numericUpDownPrice.Value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked)
            {
                textBoxMark.Enabled = false;
                numericUpDownPrice.Enabled = false;
            }
            else
            {
                textBoxMark.Enabled = true;
                numericUpDownPrice.Enabled = true;
            }
        }
    }
}
