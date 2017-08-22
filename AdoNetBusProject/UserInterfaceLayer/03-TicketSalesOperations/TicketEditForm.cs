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

namespace UserInterfaceLayer._03_TicketSalesOperations
{
    public partial class TicketEditForm : Form
    {
        TicketBussiness _ticketBLL;
        Employee _employee;
        Ticket ticket;
        BusBussiness _busBLL;
        List<int> _seatList;
        TripBussiness _tripBLL;
        Trip _trip = new Trip();
        List<Trip> _tripList;
        CityBussiness _cityBLL;
        List<City> _cityList;
        int seatCount = 0;

        public TicketEditForm()
        {
            InitializeComponent();
        }

        public TicketEditForm(Employee _employee)
        {
            this._employee = _employee;
        }

        private void TicketEditForm_Load(object sender, EventArgs e)
        {
            _ticketBLL = new TicketBussiness(_employee);
             // ID kısmı
            label1.Visible = false;
            lblTicketID.Visible = false;

           
        }

        public int GetSeatCount()
        {
            int tripID = Convert.ToInt32(cmbTripID.ValueMember);
             _trip = _tripBLL.GetBLL(tripID);

           
            Bus bus = new Bus();
            bus = _busBLL.GetBLL(_trip.BusID);
            seatCount = bus.SeatCount;
            return seatCount;

        }


        public void FillSeat()
        {
            List<int> _seatList = new List<int>();
            _seatList.Capacity = seatCount;
            for (int i = 1; i < seatCount + 1 ; i++)
            {
                _seatList.Add(i);
            }
        }
        

        private void cmbTripID_DisplayMemberChanged(object sender, EventArgs e)
        {
            FillSeat();
            cmbSeatNumber.DataSource = _seatList;
            
        }

     
        
    }
}
