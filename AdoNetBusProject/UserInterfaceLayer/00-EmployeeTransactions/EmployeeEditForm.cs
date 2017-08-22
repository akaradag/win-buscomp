using BusCompanyClassLibrary;
using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer._00_EmployeeTransactions
{
    public partial class EmployeeEditForm : Form
    {
        Employee _employee;
        Employee useremployee;
        EmployeeBussiness _empBLL;
        EmployeeBussiness userEmpBLL;
        

        private int employeeId;

        public EmployeeEditForm()
        {
            InitializeComponent();
            _employee = new Employee();
            _empBLL = new EmployeeBussiness(_employee);
            
        }

        // Listeden düzenle butonuna tıklanınca çalışacak olan ctor.
        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            
            this.employeeId = employeeId;

            _empBLL = new EmployeeBussiness(_employee);
            _employee = _empBLL.GetBLL(employeeId);
            

            // id ye göre personel bilgileri formun kontrollerine ekleniyor.

            lblID.Text = _employee.ID.ToString();
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            cmbGender.SelectedValue = _employee.GenderID;
            dtpBirthDate.Text = _employee.BirthDate.ToString();
            txtPhone.Text = _employee.Phone;
            txtAddress.Text = _employee.Address;
            cmbCity.SelectedValue = _employee.CityID;
            cmbRole.SelectedValue = _employee.RoleID;
            dtpHireDate.Text = _employee.HireDate.ToString();
            txtMail.Text = _employee.Mail;
            txtPassword.Text = _employee.Password;
            chbIsAvaliable.Checked = _employee.IsAvaliable;

            btnApply.Text = "Güncelle";

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            useremployee = mainForm.GetEmployee();

            userEmpBLL = new EmployeeBussiness(useremployee);

            try
            {
                bool result;
                if (_employee.ID == null)
                {
                    

                    _employee.FirstName = txtFirstName.Text;
                    _employee.LastName = txtLastName.Text;
                    _employee.GenderID = (int)cmbGender.SelectedValue;
                    _employee.BirthDate = Convert.ToDateTime(dtpBirthDate.Text);
                    _employee.Phone = txtPhone.Text;
                    _employee.Address = txtAddress.Text;
                    _employee.CityID = (int)cmbCity.SelectedValue;
                    _employee.RoleID = (int)cmbRole.SelectedValue;
                    _employee.HireDate = Convert.ToDateTime(dtpHireDate.Text);
                    _employee.Mail = txtMail.Text;
                    _employee.Password = txtPassword.Text;
                    _employee.IsAvaliable = chbIsAvaliable.Checked;

                    result = _empBLL.SaveBLL(_employee);
                }
                else
                {
                   

                    _employee.FirstName = txtFirstName.Text;
                    _employee.LastName = txtLastName.Text;
                    _employee.GenderID = (int)cmbGender.SelectedValue;
                    _employee.BirthDate = Convert.ToDateTime(dtpBirthDate.Text);
                    _employee.Phone = txtPhone.Text;
                    _employee.Address = txtAddress.Text;
                    _employee.CityID = (int)cmbCity.SelectedValue;
                    _employee.RoleID = (int)cmbRole.SelectedValue;
                    _employee.HireDate = Convert.ToDateTime(dtpHireDate.Text);
                    _employee.Mail = txtMail.Text;
                    _employee.Password = txtPassword.Text;
                    _employee.IsAvaliable = chbIsAvaliable.Checked;

                    result = _empBLL.UpdateBLL(_employee);
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
            EmployeeListForm listForm = new EmployeeListForm();
            listForm.MdiParent = this.MdiParent;
            listForm.Show();
            this.Close();
        }


        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            MDIForms mainForm = this.MdiParent as MDIForms;
            useremployee = mainForm.GetEmployee();

            // Cinsiyet combobox'ı veri tabanından çekilen bilgilerle dolduruldu.

            GenderBussiness genBLL = new GenderBussiness();

            cmbGender.DataSource = null;
            cmbGender.DataSource = genBLL.GetAllBLL();
            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "ID";

            // Şehir combobox'ı veri tabanından çekilen bilgilerle dolduruldu.

            CityBussiness cityBLL = new CityBussiness(useremployee);

            cmbCity.DataSource = null;
            cmbCity.DataSource = cityBLL.GetAllBLL();
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "ID";

            // Pozisyon combobox'ı veri tabanından çekilen bilgilerle dolduruldu.

            RoleBussiness roleBLL = new RoleBussiness(useremployee);

            cmbRole.DataSource = null;
            cmbRole.DataSource = roleBLL.GetAllBLL();
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "ID";
        }
    }
}
