﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club_Project
{
    public partial class Form4 : Form
    {
        public static UserInformation thisUser = new UserInformation();
        public static UserLog thisLog = new UserLog();
        public static UserContact thisContact = new UserContact();

        public Form4(UserLog user)
        {
            InitializeComponent();
            using (FitnessClubDBEntities1 database = new FitnessClubDBEntities1())
            {
                thisUser = database.UserInformations.FirstOrDefault(x => x.loginID == user.loginID);
                thisContact = database.UserContacts.FirstOrDefault(x => x.userContactID == thisUser.userContactID);
            }
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 bb = new Form5();
            bb.PopulateDataGridView();
            bb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 cc = new Form6();
            cc.PopulateDataGridView();
            cc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 dd = new Form7();
            dd.Show();
        
        }
    }
}
