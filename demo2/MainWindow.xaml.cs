using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool checkAge(int year)
        {
            bool ageChecked = true;
            if(int.Parse(DateTime.Today.Year.ToString()) - year < 18)
            {
                MessageBox.Show("Tuổi của nv phải >= 18!");
                ageChecked = false;
            }
            return ageChecked;
        }

        public bool checkTextInput(string gioitinh)
        {
            bool textInputChecked = true;
            if(this.txtManv.Text == "" && this.txtName.Text == "" && this.txtBirthDay.Text == "" && 
                gioitinh == "" && this.cbApartment.Text == "" && this.txtHS.Text == "")
            {
                MessageBox.Show("Phải nhập dữ liệu cho tất cả các trường!");
                textInputChecked = false;
            }
            return textInputChecked;
        }

        private void btn_Input(object sender, RoutedEventArgs e)
        {

            // get data from form
            string manv = txtManv.Text;
            string hoten = this.txtName.Text;
            string handleString = this.txtBirthDay.Text;
            string gioitinh = "";
            if(this.rdMale.IsChecked == true)
            {
                gioitinh = "Nam";
            } else if(this.rdFemale.IsChecked == true)
            {
                gioitinh = "Nữ";
            }
            string phongban = this.cbApartment.Text;


            // Check requirement
            if(checkTextInput(gioitinh))
            {
                String[] array = handleString.Split("-");
                DateTime ngaysinh = DateTime.Parse(array[2] + "-" + array[1] + "-" + array[0]);
                if (checkAge(int.Parse(array[2]))) {
                    double hs = Convert.ToDouble(this.txtHS.Text);
                    if (hs <= 0)
                    {
                        MessageBox.Show("Hệ số lương phải > 0");
                    }else
                    {
                        NhanVien nv = new NhanVien(manv, hoten, ngaysinh, gioitinh, phongban, hs);
                        this.dtGrid.Items.Add(nv);
                    }
                }
            }
        }

        private void showCurrentTime(object sender, RoutedEventArgs e)
        {
            DateTime currentTime = DateTime.Today;
            this.txtBirthDay.Text = currentTime.ToString("dd-MM-yyyy");
        }
    }
}
