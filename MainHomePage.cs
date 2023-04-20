﻿using mschreiber_Software2_c969Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class MainHomePage : Form
    {
        public MainHomePage()
        {
            InitializeComponent();
            ChangeColorofButtons();
            //get localization data
            string userLocation = CultureInfo.CurrentCulture.DisplayName;
            //get the current date and time 
            DateTime currentDateTime = DateTime.Now;
            // Set the text of the label element
            lbl_UserLocationAndTime.Text = $"Location: {userLocation} \nDate and Time: {currentDateTime.ToString()}";
        }

        DataTable appointmentList = new DataTable();
        bool isEditing = false;

        private void MainHomePage_Load(object sender, EventArgs e)
        {
            //create columns 
            //concatenate first+last name
            appointmentList.Columns.Add("Name");
            appointmentList.Columns.Add("Date");
            appointmentList.Columns.Add("Time");
            appointmentList.Columns.Add("Extra Column?");

            //point datagridview to the data source
            dgv_AppointmentGrid.DataSource = appointmentList;
        }
        private void ViewAppointmentsButton_Click(object sender, EventArgs e)
        {
           //this will change the DGV based on the radio button selection
        }

        private void CreateNewAppointment_Click(object sender, EventArgs e)
        {
            //open the createnewappointment screen
            AddNewAppointment createNewAppointment = new AddNewAppointment();
            createNewAppointment.Show();
            createNewAppointment.Location = new Point(btn_AddNewAppointment.Right, btn_AddNewAppointment.Top);
            
        }
        private void btn_ModifyAppointment_Click(object sender, EventArgs e)
        {
            ModifyAppointment modifyAppointment = new ModifyAppointment();       
            modifyAppointment.Show();
            modifyAppointment.Location = new Point(btn_ModifyAppointment.Right, btn_ModifyAppointment.Top);

        }

        private void MainHomePageExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.Show();
        }

        
        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            //Remove entry from the appointment DGV
        }

        private void ViewThisWeekRadioButton(object sender, EventArgs e)
        {

        }

        private void ViewThisMonthRadioButton(object sender, EventArgs e)
        {

        }

        public void ChangeColorofButtons()
        {
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);
            
            hoverColorChanger.Attach(btn_AddCustomer);
            hoverColorChanger.Attach(btn_UpdateCustomer);
            hoverColorChanger.Attach(btn_ViewAppointments);
            hoverColorChanger.Attach(btn_AddNewAppointment);
            hoverColorChanger.Attach(btn_DeleteAppointment);
            hoverColorChanger.Attach(btn_ModifyAppointment);
            hoverColorChanger.Attach(btn_Exit);
        }

        
    }
}
