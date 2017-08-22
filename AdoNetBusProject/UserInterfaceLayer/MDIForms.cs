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
using UserInterfaceLayer._00_EmployeeTransactions;
using UserInterfaceLayer._01_VehicleOperations;
using UserInterfaceLayer._02_TravelTransactions;
using UserInterfaceLayer._03_TicketSalesOperations;
using UserInterfaceLayer._04_GeneralOperations;

namespace UserInterfaceLayer
{
    public partial class MDIForms : Form
    {
        Employee _emp;
        public MDIForms()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {


            //  Burada sistem login işlemleri yapıldı..


            _emp = new Employee();
            _emp.Mail = txtUserName.Text;
            _emp.Password = txtPassword.Text;
            EmployeeBussiness _empBLL = new EmployeeBussiness(_emp);
            List<Employee> empList = new List<Employee>();

            empList = _empBLL.GetAllBLL();

            foreach (Employee item in empList)
            {
                if (item.RoleID == 1)
                {
                    if (_emp.Mail == item.Mail && _emp.Password == item.Password)
                    {
                        _emp.RoleID = 1;
                        menuManager.Visible = true;
                        panel1.Visible = false;
                    }
                }
                else if (item.RoleID == 2)
                {
                    if (_emp.Mail == item.Mail && _emp.Password == item.Password)
                    {
                        _emp.RoleID = 2;
                        menuSalesPerson.Visible = true;
                        panel1.Visible = false;
                    }
                }
                else if (item.RoleID == 3 || item.RoleID == 4)
                {
                    if (_emp.Mail == item.Mail && _emp.Password == item.Password)
                    {
                        menuBusStaff.Visible = true;
                        panel1.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sistemde kayıtlı olmayan kullanıcı adı ve şifresi ile giriş yapılamaz..");
                }
            }
            
            // Login ekranı kontrollerinin içeriği temizleniyor.
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            // Çıkış işlemi yapılıyor ve login ekranına geçiliyor.
            menuManager.Visible = false;
            panel1.Visible = true;
        }

        private void miExit_SP_Click(object sender, EventArgs e)
        {
            // Çıkış işlemi yapılıyor ve login ekranına geçiliyor.
            menuSalesPerson.Visible = false;
            panel1.Visible = true;
        }

        private void miExit_BS_Click(object sender, EventArgs e)
        {
            // Çıkış işlemi yapılıyor ve login ekranına geçiliyor.
            menuBusStaff.Visible = false;
            panel1.Visible = true;
        }

        private void miRoles_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RoleForm>("Pozisyon İşlemleri");

            //RoleForm role = new RoleForm();
            //role.MdiParent = this;
            //role.Text = "Pozisyon İşlemleri";
            //role.Show();
        }

        private void miEditEmployee_Click(object sender, EventArgs e)
        {
            OpenControlledForm<EmployeeEditForm>("Yeni Çalışan Tanımlama");

            //EmployeeEditForm empEditForm = new EmployeeEditForm();
            //empEditForm.MdiParent = this;
            //empEditForm.Text = "Yeni Çalışan Tanımlama";
            //empEditForm.Show();
        }

        private void miEmployeeList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<EmployeeListForm>("Çalışanlar Listesi");

            //EmployeeListForm empListForm = new EmployeeListForm();
            //empListForm.MdiParent = this;
            //empListForm.Text = "Çalışanlar Listesi";
            //empListForm.Show();

        }

        private void miEditBrand_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BrandEditForm>("Yeni Marka Tanımlama");

            //BrandEditForm brandEditForm = new BrandEditForm();
            //brandEditForm.MdiParent = this;
            //brandEditForm.Text = "Yeni Marka Tanımlama";
            //brandEditForm.Show();
        }

        private void miEditModel_Click(object sender, EventArgs e)
        {
            OpenControlledForm<ModelEditForm>("Yeni Model Tanımlama");

            //ModelEditForm modelEditForm = new ModelEditForm();
            //modelEditForm.MdiParent = this;
            //modelEditForm.Text = "Yeni Model Tanımlama";
            //modelEditForm.Show();
        }

        private void miEditType_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BusTypeEditForm>("Yeni Tip Tanımlama");

            //BusTypeEditForm busTypeEditForm = new BusTypeEditForm();
            //busTypeEditForm.MdiParent = this;
            //busTypeEditForm.Text = "Yeni Tip Tanımlama";
            //busTypeEditForm.Show();
        }

        private void miEditBus_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BusEditForm>("Yeni Otobüs Tanımlama");

            //BusEditForm busEditForm = new BusEditForm();
            //busEditForm.MdiParent = this;
            //busEditForm.Text = "Yeni Otobüs Tanımlama";
            //busEditForm.Show();
        }

        private void miBrandList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BrandListForm>("Marka Listesi");

            //BrandListForm brandListForm = new BrandListForm();
            //brandListForm.MdiParent = this;
            //brandListForm.Text = "Marka Listesi";
            //brandListForm.Show();
        }

        private void miModelList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<ModelListForm>("Model Listesi");

            //ModelListForm modelListForm = new ModelListForm();
            //modelListForm.MdiParent = this;
            //modelListForm.Text = "Model Listesi";
            //modelListForm.Show();
        }

        private void miTypeList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BusTypeListForm>("Tip Listesi");

            //BusTypeListForm busTypeListForm = new BusTypeListForm();
            //busTypeListForm.MdiParent = this;
            //busTypeListForm.Text = "Tip Listesi";
            //busTypeListForm.Show();
        }

        private void miBusList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BusListForm>("Otobüs Listesi");

            //BusListForm busListForm = new BusListForm();
            //busListForm.MdiParent = this;
            //busListForm.Text = "Otobüs Listesi";
            //busListForm.Show();
        }

        private void miEditRoute_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RouteEditForm>("Yeni Rota Tanımlama");

            //RouteEditForm routeEditForm = new RouteEditForm();
            //routeEditForm.MdiParent = this;
            //routeEditForm.Text = "Yeni Rota Tanımlama";
            //routeEditForm.Show();
        }

        private void miEditTrip_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TripEditForm>("Yeni Sefer Tanımlama");

            //TripEditForm tripEditForm = new TripEditForm();
            //tripEditForm.MdiParent = this;
            //tripEditForm.Text = "Yeni Sefer Tanımlama";
            //tripEditForm.Show();
        }

        private void miEditHour_Click(object sender, EventArgs e)
        {
            OpenControlledForm<HourEditForm>("Yeni Hareket Saati Tanımlama");

            //HourEditForm hourEditForm = new HourEditForm();
            //hourEditForm.MdiParent = this;
            //hourEditForm.Text = "Yeni Hareket Saati Tanımlama";
            //hourEditForm.Show();
        }

        private void miRouteList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RouteListForm>("Rota Listesi");

            //RouteListForm routeListForm = new RouteListForm();
            //routeListForm.MdiParent = this;
            //routeListForm.Text = "Rota Listesi";
            //routeListForm.Show();
        }

        private void miTripList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TripListForm>("Sefer Listesi");

            //TripListForm tripListForm = new TripListForm();
            //tripListForm.MdiParent = this;
            //tripListForm.Text = "Sefer Listesi";
            //tripListForm.Show();
        }

        private void miHourList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<HourListForm>("Hareket Saatleri Listesi");

            //HourListForm hourListForm = new HourListForm();
            //hourListForm.MdiParent = this;
            //hourListForm.Text = "Hareket Saatleri Listesi";
            //hourListForm.Show();
        }

        private void miEditTicket_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketEditForm>("Yeni Bilet İşlemi");

            //TicketEditForm ticketEditForm = new TicketEditForm();
            //ticketEditForm.MdiParent = this;
            //ticketEditForm.Text = "Yeni Bilet İşlemi";
            //ticketEditForm.Show();
        }

        private void miTicketList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketListForm>("Bilet Listesi");

            //TicketListForm ticketListForm = new TicketListForm();
            //ticketListForm.MdiParent = this;
            //ticketListForm.Text = "Bilet Listesi";
            //ticketListForm.Show();
        }

        private void miTicketCancellation_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketEditForm>("Bilet İptal İşlemi");

            //TicketEditForm ticketEditForm = new TicketEditForm();
            //ticketEditForm.MdiParent = this;
            //ticketEditForm.Text = "Bilet İptal İşlemi";
            //ticketEditForm.Show();
        }

        private void miEditSale_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleEditForm>("Satış İşlemi");

            //SaleEditForm saleEditForm = new SaleEditForm();
            //saleEditForm.MdiParent = this;
            //saleEditForm.Text = "Satış İşlemi";
            //saleEditForm.Show();
        }

        private void miSaleList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleListForm>("Satış Listesi");

            //SaleListForm saleListForm = new SaleListForm();
            //saleListForm.MdiParent = this;
            //saleListForm.Text = "Satış Listesi";
            //saleListForm.Show();
        }

        private void miSaleCancellation_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleEditForm>("Satış İptal İşlemi");

            //SaleEditForm saleEditForm = new SaleEditForm();
            //saleEditForm.MdiParent = this;
            //saleEditForm.Text = "Satış İptal İşlemi";
            //saleEditForm.Show();
        }

        private void miEditCity_Click(object sender, EventArgs e)
        {
            OpenControlledForm<CityEditForm>("Yeni Şehir Tanımlama");

            //CityEditForm cityEditForm = new CityEditForm();
            //cityEditForm.MdiParent = this;
            //cityEditForm.Text = "Yeni Şehir Tanımlama";
            //cityEditForm.Show();
        }

        private void miCityList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<CityListForm>("Şehir Listesi");

            //CityListForm cityListForm = new CityListForm();
            //cityListForm.MdiParent = this;
            //cityListForm.Text = "Şehir Listesi";
            //cityListForm.Show();
        }

        private void miEditPayment_Click(object sender, EventArgs e)
        {
            OpenControlledForm<PaymentEditForm>("Yeni Ödeme Tipi Tanımlama");

            //PaymentEditForm paymentEditForm = new PaymentEditForm();
            //paymentEditForm.MdiParent = this;
            //paymentEditForm.Text = "Yeni Ödeme Tipi Tanımlama";
            //paymentEditForm.Show();
        }

        private void miPaymentList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<PaymentListForm>("Ödeme Tipi Listesi");

            //PaymentListForm paymentListForm = new PaymentListForm();
            //paymentListForm.MdiParent = this;
            //paymentListForm.Text = "Ödeme Tipi Listesi";
            //paymentListForm.Show();
        }

        private void miEditTicket_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketEditForm>("Yeni Bilet İşlemi");

            //TicketEditForm ticketEditForm = new TicketEditForm();
            //ticketEditForm.MdiParent = this;
            //ticketEditForm.Text = "Yeni Bilet İşlemi";
            //ticketEditForm.Show();
        }

        private void miTicketList_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketListForm>("Bilet Listesi");

            //TicketListForm ticketListForm = new TicketListForm();
            //ticketListForm.MdiParent = this;
            //ticketListForm.Text = "Bilet Listesi";
            //ticketListForm.Show();
        }

        private void miTicketCancellation_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketCancellationForm>("Bilet İptal İşlemi");

            //TicketEditForm ticketEditForm = new TicketEditForm();
            //ticketEditForm.MdiParent = this;
            //ticketEditForm.Text = "Bilet İptal İşlemi";
            //ticketEditForm.Show();
        }

        private void miEditSale_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleEditForm>("Satış İşlemi");

            //SaleEditForm saleEditForm = new SaleEditForm();
            //saleEditForm.MdiParent = this;
            //saleEditForm.Text = "Satış İşlemi";
            //saleEditForm.Show();
        }

        private void miSaleList_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleListForm>("Satış Listesi");

            //SaleListForm saleListForm = new SaleListForm();
            //saleListForm.MdiParent = this;
            //saleListForm.Text = "Satış Listesi";
            //saleListForm.Show();
        }

        private void miSaleCancellation_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<SaleCancellationForm>("Satış İptal İşlemi");

            //SaleEditForm saleEditForm = new SaleEditForm();
            //saleEditForm.MdiParent = this;
            //saleEditForm.Text = "Satış İptal İşlemi";
            //saleEditForm.Show();
        }

        private void miRouteList_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RouteListForm>("Rota Listesi");

            //RouteListForm routeListForm = new RouteListForm();
            //routeListForm.MdiParent = this;
            //routeListForm.Text = "Rota Listesi";
            //routeListForm.Show();
        }

        private void miTripList_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TripListForm>("Sefer Listesi");

            //TripListForm tripListForm = new TripListForm();
            //tripListForm.MdiParent = this;
            //tripListForm.Text = "Sefer Listesi";
            //tripListForm.Show();
        }

        private void miHourList_SP_Click(object sender, EventArgs e)
        {
            OpenControlledForm<HourListForm>("Hareket Saatleri Listesi");

            //HourListForm hourListForm = new HourListForm();
            //hourListForm.MdiParent = this;
            //hourListForm.Text = "Hareket Saatleri Listesi";
            //hourListForm.Show();
        }

        private void miBusList_BS_Click(object sender, EventArgs e)
        {
            OpenControlledForm<BusListForm>("Otobüs Listesi");

            //BusListForm busListForm = new BusListForm();
            //busListForm.MdiParent = this;
            //busListForm.Text = "Otobüs Listesi";
            //busListForm.Show();
        }

        private void miRouteList_BS_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RouteListForm>("Rota Listesi");

            //RouteListForm routeListForm = new RouteListForm();
            //routeListForm.MdiParent = this;
            //routeListForm.Text = "Rota Listesi";
            //routeListForm.Show();
        }

        private void miTripList_BS_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TripListForm>("Sefer Listesi");

            //TripListForm tripListForm = new TripListForm();
            //tripListForm.MdiParent = this;
            //tripListForm.Text = "Sefer Listesi";
            //tripListForm.Show();
        }

        private void miHourList_BS_Click(object sender, EventArgs e)
        {
            OpenControlledForm<HourListForm>("Hareket Saatleri Listesi");

            //HourListForm hourListForm = new HourListForm();
            //hourListForm.MdiParent = this;
            //hourListForm.Text = "Hareket Saatleri Listesi";
            //hourListForm.Show();
        }

        private void miTicketList_BS_Click(object sender, EventArgs e)
        {
            OpenControlledForm<TicketListForm>("Bilet Listesi");

            //TicketListForm ticketListForm = new TicketListForm();
            //ticketListForm.MdiParent = this;
            //ticketListForm.Text = "Bilet Listesi";
            //ticketListForm.Show();
        }

        private void miRoleList_Click(object sender, EventArgs e)
        {
            OpenControlledForm<RoleListForm>("Pozisyon Listesi");

            //RoleListForm roleListForm = new RoleListForm();
            //roleListForm.MdiParent = this;
            //roleListForm.Text = "Pozisyon Listesi";
            //roleListForm.Show();
        }

        public Employee GetEmployee()
        {
            return _emp;
        }

        #region Kontrollü Form Açma
        public void OpenControlledForm<TForm>( string formText) where TForm : Form, new()
        {
            bool formOpened = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is TForm)
                {
                    formOpened = true;
                    break;
                }
            }
            if (!formOpened)
            {
                TForm form = new TForm();
                form.MdiParent = this;
                form.Text = formText;
                form.Show();
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
