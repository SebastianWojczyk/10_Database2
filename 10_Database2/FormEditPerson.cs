using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Database2
{
    public partial class FormEditPerson : Form
    {
        Person person;
        public FormEditPerson()
        {
            InitializeComponent();
        }
        public FormEditPerson(Person person)
        {
            InitializeComponent();
            this.person = person;
            textBoxName.Text = person.Name;
            dateTimePickerDrivingLicense.Value = person.DateDrivingLicense;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Add
            if (person == null)
            {
                person = new Person();
                FormMain.DatabaseDT.Persons.InsertOnSubmit(person);
            }
            person.Name = textBoxName.Text;
            person.DateDrivingLicense = dateTimePickerDrivingLicense.Value;
            
            FormMain.DatabaseDT.SubmitChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
