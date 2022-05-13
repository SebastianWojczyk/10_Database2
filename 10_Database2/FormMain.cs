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
    /*
    CREATE TABLE[dbo].[Person]
    (
       [Id] INT NOT NULL PRIMARY KEY IDENTITY,
       [Name] NVARCHAR(50) NOT NULL,
       [DateDrivingLicense] DATE NOT NULL
    )
    CREATE TABLE [dbo].[Car]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
        [Mark] NVARCHAR(50) NOT NULL, 
        [Price] DECIMAL(18, 2) NOT NULL, 
        [PersonId] INT NOT NULL, 
        CONSTRAINT [FK_Car_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
    )
    */
    public partial class FormMain : Form
    {
        static public DatabaseDataContext DatabaseDT = new DatabaseDataContext();
        public FormMain()
        {
            InitializeComponent();

            RefreshPersons();
        }

        private void RefreshPersons()
        {
            listBoxPersons.Items.Clear();
            listBoxPersons.Items.AddRange(DatabaseDT.Persons.ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem != null)
            {
                if (listBoxPersons.SelectedItem is Person)
                {
                    Person p = listBoxPersons.SelectedItem as Person;

                    if (MessageBox.Show("Czy chcesz usunąć osobę? " +
                                        (p.Cars.Count() > 0 ? $"Ma {p.Cars.Count()} samochodów" : ""),
                                       "UWAGA",
                                       MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatabaseDT.Cars.DeleteAllOnSubmit(p.Cars);
                        DatabaseDT.Persons.DeleteOnSubmit(p);
                        DatabaseDT.SubmitChanges();
                        RefreshPersons();
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEditPerson fep = new FormEditPerson();
            if (fep.ShowDialog() == DialogResult.OK)
            {
                RefreshPersons();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem != null)
            {
                if (listBoxPersons.SelectedItem is Person)
                {
                    Person p = listBoxPersons.SelectedItem as Person;

                    FormEditPerson fep = new FormEditPerson(p);
                    if (fep.ShowDialog() == DialogResult.OK)
                    {
                        RefreshPersons();
                    }
                }
            }
        }
    }
    partial class Person
    {
        public override string ToString()
        {
            Decimal avg = 0;
            if (this.Cars.Count() > 0)
            {
                avg = this.Cars.Average(c => c.Price);
            }

            return $"{this.Name} {this.Cars.Count()} szt. po {avg}";
        }
    }
}
