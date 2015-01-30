/* This program displays the firends' firs names, last names, phone numbers, month and day of birthdays within month of birthday with graphic design interface. 
 * Filename: FriendBirthdayReminder
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

namespace FriendBirthdayReminder
{
    public partial class FriendRecordsForm : Form
    {
        const string FILENAME =
            @"E:\Records.txt";
        string recordIn;
        string field;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public FriendRecordsForm()
        {
            InitializeComponent();
        }

        private void showRecordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                field = recordIn;
                monthBox.Text = field;
            }
            catch (NullReferenceException)
            {
                inputLabel.Text = "You have viewed\nall the records.";
                showRecordsButton.Enabled = false;
                recordBox.Text = reader.ReadLine();
            }
        }
    }
}
