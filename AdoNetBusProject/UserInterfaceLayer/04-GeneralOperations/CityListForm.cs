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
    public partial class CityListForm : Form
    {
        CityBussiness _cityBLL;
        Employee _employee;
        City _city = new City();

        public CityListForm()
        {
            InitializeComponent();
            _cityBLL = new CityBussiness(_employee);
        }

        private void CityListForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCityList.DataSource = _cityBLL.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvCityList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cityId = (int)dgvCityList.Rows[e.RowIndex].Cells["ID"].Value;

            CityEditForm editForm = new CityEditForm(cityId);
            editForm.MdiParent = this.MdiParent;
            editForm.Text = "Şehir Güncelleme";
            editForm.Show();
            this.Close();
        }
    }
}
