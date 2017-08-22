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
    public partial class RouteListForm : Form
    {
        RouteBussiness _routeBuss;
        Route _route;
        int _routeId;
        Employee _emp;

        public RouteListForm()
        {
            InitializeComponent();
            MDIForms mainForm = this.MdiParent as MDIForms;
            _routeBuss = new RouteBussiness(_emp);
        }

        private void RouteListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            dgvRoute.DataSource = null;
            try
            {
                dgvRoute.DataSource = _routeBuss.GetAllBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvRoute_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _routeId = (int)dgvRoute.Rows[e.RowIndex].Cells["ID"].Value;
            bool formFound = false;
            #region RouteEditForm kontrollü açma
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is RouteEditForm)
                {
                    item.BringToFront();
                    MessageBox.Show("Aynı anda sadece bir tane güncelleme işlemi yapabilirsiniz.");
                    formFound = true;
                    break;
                }
            }
            if (!formFound)
            {
                RouteEditForm rEditForm = new RouteEditForm(_routeId);
                rEditForm.MdiParent = this.MdiParent;
                rEditForm.Show();
            } 
            #endregion
        }

        #region Silme İşlemi
        private void dgvRoute_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _routeId = (int)dgvRoute.Rows[e.RowIndex].Cells["ID"].Value;
                try
                {
                    _route = _routeBuss.GetBLL(_routeId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void miDeleteRoute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(_route.Name + " rotasını kaldırmak istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                bool bllResult = false;
                RouteCitiesBussiness rcBuss = new RouteCitiesBussiness(_emp);
                RouteCities routeCity = new RouteCities();
                routeCity.RouteID = _route.ID;
                try
                {
                    bllResult = _routeBuss.DeleteBLL(_route);
                    bllResult = rcBuss.DeleteBLL(routeCity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(bllResult ? "İşlem başarılı" : "İşlem başarısız.");
            }
        }
        #endregion

    }
}
