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

namespace UserInterfaceLayer._04_GeneralOperations
{
    public partial class CityEditForm : Form
    {
        City city;
        CityBussiness _cityBLL;
        Employee _employee = new Employee();

        private int cityId;

        public CityEditForm()
        {
            InitializeComponent();
            city = new City();
            _cityBLL = new CityBussiness(_employee);
        }

        public CityEditForm(int cityId)
        {
            InitializeComponent();
            this.cityId = cityId;

            _cityBLL = new CityBussiness(_employee);
            city = _cityBLL.GetBLL(cityId);

            txtCityName.Text = city.Name;
            btnApply.Text = "Güncelle";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            _employee = mainForm.GetEmployee();
            city.Name = txtCityName.Text;
            try
            {
                bool result;
                if (city.ID == null)
                {
                    _cityBLL = new CityBussiness(_employee);
                    result = _cityBLL.SaveBLL(city);
                }
                else
                {
                    _cityBLL = new CityBussiness(_employee);
                    result = _cityBLL.UpdateBLL(city);
                }
                if (result)
                {
                    MessageBox.Show("İşlem başarılı..");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CityListForm listForm = new CityListForm();
            listForm.MdiParent = this.MdiParent;
            listForm.Show();
            this.Close();
        }
    }
}
