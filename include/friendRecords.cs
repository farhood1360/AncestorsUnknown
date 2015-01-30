/* This program creates the friend class and stores firends' firs names, last names, phone numbers, month and day of birthdays with graphic design interface. 
 * Filename: WriteFriendRecordss
 * Written by: Farhood Rashidi
 * Written on: 05/03/2013 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FriendRecords
{ 
    public partial class FriendRecordsForm : Form
    {
        const string DELIM = ",";
        const string FILENAME =
        @"E:\Records.txt";
        string fName;
        string lName;
        int phone;
        DateTime day;
        DateTime month;
        static FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        
        public FriendRecordsForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            fName = firstNameTextBox.Text;
            lName = lastNameTextBox.Text;
            phone = Convert.ToInt32(phoneTextBox.Text);
            day = Convert.ToDateTime(dateOfBirthTimePicker.Text);
            month = Convert.ToDateTime(dateOfBirthTimePicker.Text);
            writer.WriteLine(fName + DELIM + lName + DELIM + phone + DELIM + day + DELIM + month);
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneTextBox.Clear();
            dateOfBirthTimePicker.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneTextBox.Clear();
            dateOfBirthTimePicker.Text = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Friend
    {
        private string firstName;
        private string lastName;
        private int phoneNumbers;
        private DateTime dayOfBirthday;
        private DateTime monthOfBirthday;
        public Friend (string fName, string lName, int phone, DateTime day, DateTime month)
        {
          FirstName = fName;
          LastName = lName;
          PhoneNumbers = phone;
          DayOfBirthday = day;
          MonthOfBirthday = month;
        }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public int PhoneNumbers { get; set; }
        public DateTime DayOfBirthday { get; set; }
        public DateTime MonthOfBirthday { get; set; }
    }
}
