using BusCompanyClassLibrary;
using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer._02_TravelTransactions
{
    public partial class TripEditForm : Form
    {
        Route _routeToAdd;
        Employee _empToAdd;
        Hour _hourToAdd;

        TripEmployee _tripEmp;
        TripDetails _tDetails;
        Trip _trip;
        Employee _emp;

        List<Bus> _busList;
        List<Hour> _hourList;
        List<Route> _routeList;
        List<Employee> _empList;

        TripDetailsBussiness _tdBussiness;
        TripEmployeeBussiness _teBussiness;
        TripBussiness _tripBuss;

        public TripEditForm()
        {
            InitializeComponent();
            lblID.Visible = false;
            lblIDValue.Visible = false;
        }

        private void TripEditForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
            RouteBussiness rBuss = new RouteBussiness(_emp);
            HourBussiness hBuss = new HourBussiness(_emp);
            _tdBussiness = new TripDetailsBussiness(_emp);
            _teBussiness = new TripEmployeeBussiness(_emp);
            _tripBuss = new TripBussiness(_emp);
            try
            {
                _routeList = rBuss.GetAllBLL();
                _hourList = hBuss.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshRouteComboBox();
            RefreshCmbHour();
        }

        private void btnTripEdit_Click(object sender, EventArgs e)
        {
            if (lstRoute.Items.Count == lstRouteHour.Items.Count)
            {
                bool result = false;
                if (_trip.ID == null)
                {
                    _trip = new Trip();
                    _tDetails = new TripDetails();
                    _tripEmp = new TripEmployee();
                }
                _trip.BusID = (int)((Bus)cmbBus.SelectedItem).ID;
                try
                {
                    result = _tripBuss.SaveBLL(_trip);
                    int counter = 0;
                    foreach (Route item in lstRoute.Items)
                    {
                        _tDetails.EndDate = dtpEndDate.Value;
                        _tDetails.StartDate = dtpStartDate.Value;
                        _tDetails.PredictedTime = dtpPredictedTime.Value.ToShortTimeString();
                        _tDetails.HourID = (int)((Hour)lstRouteHour.Items[counter]).ID;
                        _tDetails.RouteID = (int)item.ID;
                        counter++;
                        result = _tdBussiness.SaveBLL(_tDetails);
                    }
                    foreach (Employee item in lstEmployee.Items)
                    {
                        _tripEmp.EmployeeID = (int)item.ID;
                        result = _teBussiness.SaveBLL(_tripEmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Rota sayısı ve rota saati sayısı eşit olmalı!");
            }
        }

        #region Bus
        private void RefreshCmbBus()
        {
            //TODO: Bus entity düzenlenirse yakışıklı olur.
            cmbBus.DataSource = null;
            cmbBus.DataSource = _busList;
            cmbBus.DisplayMember = "ID";
        }
        private void btnGetControlledBus_Click(object sender, EventArgs e)
        {
            BusBussiness bBuss = new BusBussiness(_emp);
            try
            {
                _busList = bBuss.GetAllByDate(dtpStartDate.Value, dtpEndDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshCmbBus();
        }
        #endregion

        #region Route
        private void RefreshRouteComboBox()
        {
            cmbRoute.DataSource = null;
            cmbRoute.DataSource = _routeList;
            cmbRoute.DisplayMember = "Name";
        }
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            _routeToAdd = (Route)cmbRoute.SelectedItem;
            _routeList.Remove(_routeToAdd);
            lstRoute.Items.Add(_routeToAdd);
            RefreshRouteComboBox();
        }

        private void btnRemoveRoute_Click(object sender, EventArgs e)
        {
            if (lstRoute.SelectedItem != null)
            {
                _routeToAdd = (Route)lstRoute.SelectedItem;
                lstRoute.Items.Remove(_routeToAdd);
                _routeList.Add(_routeToAdd);
                RefreshRouteComboBox();
            }
        }

        #endregion

        #region Employee
        private void RefreshEmployeeComboBox()
        {
            cmbEmployee.DataSource = null;
            cmbEmployee.DataSource = _empList;

        }
        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            EmployeeBussiness eBuss = new EmployeeBussiness(_emp);
            _empList = eBuss.GetAllTripByDateEmp(dtpStartDate.Value, dtpEndDate.Value);
            RefreshEmployeeComboBox();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _empToAdd = (Employee)cmbEmployee.SelectedItem;
            _empList.Remove(_empToAdd);
            lstEmployee.Items.Add(_empToAdd);
            RefreshEmployeeComboBox();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedItem != null)
            {
                _empToAdd = (Employee)lstEmployee.SelectedItem;
                lstEmployee.Items.Remove(_empToAdd);
                _empList.Add(_empToAdd);
                RefreshEmployeeComboBox();
            }
        }
        #endregion

        #region Hour
        private void RefreshCmbHour()
        {
            cmbHour.DataSource = null;
            cmbHour.DataSource = _hourList;
            cmbHour.DisplayMember = "DepartureTime";
        }

        private void btnAddHour_Click(object sender, EventArgs e)
        {
            _hourToAdd = (Hour)cmbHour.SelectedItem;
            lstRouteHour.Items.Add(_hourToAdd);
            _hourList.Remove(_hourToAdd);
            RefreshCmbHour();
        }

        private void btnRemoveHour_Click(object sender, EventArgs e)
        {
            _hourToAdd = ((Hour)lstRouteHour.SelectedItem);
            _hourList.Add(_hourToAdd);
            lstRouteHour.Items.Remove(_hourToAdd);
            RefreshCmbHour();
        }
        #endregion

    }
}
