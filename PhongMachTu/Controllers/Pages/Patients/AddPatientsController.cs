using PhongMachTu.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhongMachTu.Controllers.Pages.Patients
{
    public partial class AddPatientsController :Page
    {
        PhongMach db = new PhongMach();
        public AddPatientsController()
        {
            InitializeComponent();
        }
        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.GoBack();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (/*string.IsNullOrWhiteSpace(txt_MaBN.Text) ||*/
                    string.IsNullOrWhiteSpace(txt_FullName.Text) ||
                    DatepickerEmployee.SelectedDate == null ||
                    string.IsNullOrWhiteSpace(cmbSex.Text) ||
                    string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txt_SDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
                    return;
                }

                // Tạo một đối tượng Employee mới
                var patient = new BenhNhan
                {
                    //MaBN = txt_MaBN.Text,
                    FullName = txt_FullName.Text,
                    Sex = cmbSex.Text,
                    Birthday = DatepickerEmployee.SelectedDate,
                    DiaChi = txt_DiaChi.Text,
                    SDT = txt_SDT.Text
                };

                // Thêm đối tượng Employee vào DbSet của DbContext
                DataProvider.Instance.DB.BenhNhan.Add(patient);

                // Lưu thay đổi vào cơ sở dữ liệu
                DataProvider.Instance.DB.SaveChanges();

                // Hiển thị thông báo khi thêm thành công
                MessageBox.Show("Đã thêm bệnh nhân mới");
                dashboard.fContainer.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void DatepickerEmployee_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
