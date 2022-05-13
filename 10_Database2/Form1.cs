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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
