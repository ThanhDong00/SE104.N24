using PhongMachTu.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhongMachTu.Controllers.Pages.Employees
{
    public partial class NewEmployeeController :Page
    {
        PhongMach db = new PhongMach();
        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        DateTime dateTimeBirth = DateTime.Now;
        public NewEmployeeController()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.GoBack();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    DatepickerEmployee.SelectedDate == null ||
                    string.IsNullOrWhiteSpace(cmbJob.Text) ||
                    string.IsNullOrWhiteSpace(cmbSex.Text) ||
                    string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
                    return;
                }
                using (var phongmach = new PhongMach())
                {
                    // Tạo một đối tượng Employee mới
                    var employee = new NhanVien
                    {
                        TenNV = txtName.Text,
                        SDT = txtPhone.Text,
                        Birthday = DatepickerEmployee.SelectedDate,
                        ChucVu = cmbJob.Text,
                        Sex = cmbSex.Text,
                        UserName = txtUserName.Text,
                        DiaChi = txtAddress.Text,
                        Password = txtPass.Text
                    };

                    // Thêm đối tượng Employee vào DbSet của DbContext
                    phongmach.NhanVien.Add(employee);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    phongmach.SaveChanges();

                    // Hiển thị thông báo khi thêm thành công
                    MessageBox.Show("Thêm nhân viên thành công!");
                    dashboard.fContainer.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên : " + ex);
            }
        }

        private void DatepickerEmployee_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Kiểm tra ký tự nhập vào có phải là số hay không
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                // Nếu không phải số, hủy bỏ sự kiện để ngăn người dùng nhập chữ
                e.Handled = true;
            }
        }
    }
}
