using _67TH1_LTUDTXD_HUCE_NHOM0121.Model;
using _67TH1_LTUDTXD_HUCE_NHOM0121.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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

namespace _67TH1_LTUDTXD_HUCE_NHOM0121.View
{
    /// <summary>
    /// Interaction logic for Thongsomong.xaml
    /// </summary>
    public partial class Thongsomong : Page
    {
        public Thongsomong()
        {
            InitializeComponent();
            DataContext = new ThongSoMongViewModel();

        }
        private void Thongsodat_Click(object sender, RoutedEventArgs e)
        {
            ThongsomongPage.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new Thongsodat());
            ClearNavigationHistory();
        }
        private void ClearNavigationHistory()
        {
            while (MainFrame.CanGoBack)
            {
                MainFrame.RemoveBackEntry();
            }
        }
        private void Luusolieu_Click(object sender, RoutedEventArgs e)
        {
            var mongdon = new MongDon
            {
                chieuDaiMong = float.Parse(txtChieuDaiMong.Text),
                chieuRongMong = float.Parse(txtChieuRongMong.Text),
                chieuCaoMong = float.Parse(txtChieuCaoMong.Text),
                N = float.Parse(txtTaiTrongN.Text),
                Q = float.Parse(txtTaiTrongQ.Text),
                Momen = float.Parse(txtMoMenM.Text),
                macBeTong = (cboMacBeTong.SelectedItem as ComboBoxItem)?.Content.ToString(),
                macThep = (cboLoaiThep.SelectedItem as ComboBoxItem)?.Content.ToString(),
                cuongDoBeTong = float.Parse(txtCuongDoBeTong.Text),
                cuongDoThep = float.Parse(txtCuongDoThep.Text),
                chieuRongCot = float.Parse(txtChieuRongCot.Text),
                chieuDaiCot = float.Parse(txtChieuDaiCot.Text),
                chieuSauChonMong = float.Parse(txtChieuSauChonMong.Text)

               
            };
            MongDon.ThongTinMong = mongdon;
            // Truyền dữ liệu về MainWindow
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.SolieuData = mongdon;

            }

            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo");

        }
    }
}
