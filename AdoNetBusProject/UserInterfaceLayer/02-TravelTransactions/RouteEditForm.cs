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
    public partial class RouteEditForm : Form
    {
        Employee _emp;
        int _cmbSelectedIndex = -1;
        RouteCitiesBussiness _rcBussiness;
        RouteBussiness _routeBussiness;
        Route _route;
        List<City> _cityList;
        List<City> _secondCityList;
        RouteCities _firstRC;
        RouteCities _secondRC;
        public RouteEditForm()
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
            _route = new Route();
            _firstRC = new RouteCities();
            _secondRC = new RouteCities();
            this.Text = "Yeni Rota";
            lblID.Enabled = false;
            lblIDValue.Enabled = false;
            RefreshFirstComboBox();
        }
        public RouteEditForm(int routeId)
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _emp = mainForm.GetEmployee();
            _routeBussiness = new RouteBussiness(_emp);
            _rcBussiness = new RouteCitiesBussiness(_emp);
            CityBussiness cityBuss = new CityBussiness(_emp);
            RefreshFirstComboBox();
            try
            {
                _route = _routeBussiness.GetBLL(routeId);
                _firstRC = _rcBussiness.GetBLL(routeId);
                _secondRC = _rcBussiness.GetSecondCityBLL(routeId);
                cmbFirstCity.SelectedIndex = cmbFirstCity.FindStringExact(cityBuss.GetBLL(_firstRC.CityID).Name);
                cmbSecondCity.SelectedIndex = cmbSecondCity.FindStringExact(cityBuss.GetBLL(_secondRC.CityID).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtName.Text = _route.Name;
            nudPrice.Value = _route.Price;

            btnEdit.Text = "Güncelle";
            lblIDValue.Text = _route.ID.ToString();
            this.Text = "Rota Güncelleme";
        }

        private void RouteEditForm_Load(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            City firstCity = (City)cmbFirstCity.SelectedItem;
            City secondCity = (City)cmbSecondCity.SelectedItem;

            _firstRC.CityID = (int)firstCity.ID;
            _firstRC.SortIndex = 1;
            _secondRC.CityID = (int)secondCity.ID;
            _secondRC.SortIndex = 2;
            _route.Name = txtName.Text;
            _route.Price = nudPrice.Value;
            bool result = false;

            if (_route.ID == null)
            {
                try
                {
                    result = _routeBussiness.SaveBLL(_route);
                    result = _rcBussiness.SaveBLL(_firstRC);
                    result = _rcBussiness.SaveBLL(_secondRC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    result = _routeBussiness.UpdateBLL(_route);
                    result = _rcBussiness.DeleteBLL(_firstRC);
                    result = _rcBussiness.SaveBLL(_firstRC);
                    result = _rcBussiness.SaveBLL(_secondRC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show(result ? "İşlem Başarılı" : "İşlem Başarısız");

            #region RouteListForm u bulup listeyi güncellemek için
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is RouteListForm)
                {
                    ((RouteListForm)item).RefreshList();
                    break;
                }
            }
            #endregion

            this.Close();
        }

        #region Bağlı comboboxlar
        private void RefreshFirstComboBox()
        {
            cmbFirstCity.DataSource = null;
            CityBussiness cityBussiness = new CityBussiness(_emp);
            try
            {
                _cityList = cityBussiness.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbFirstCity.DataSource = _cityList;
            cmbFirstCity.DisplayMember = "Name";
        }

        private void cmbFirstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbSelectedIndex = ((ComboBox)sender).SelectedIndex;
            RefreshSecondComboBox();
        }
        private void RefreshSecondComboBox()
        {
            _secondCityList = new List<City>();
            int counter = 0;
            foreach (City item in _cityList)
            {
                if (_cmbSelectedIndex != counter)
                {
                    _secondCityList.Add(item);
                }
                counter++;
            }
            cmbSecondCity.DataSource = null;
            cmbSecondCity.DataSource = _secondCityList;
            cmbSecondCity.DisplayMember = "Name";
        }
        #endregion
    }
}
