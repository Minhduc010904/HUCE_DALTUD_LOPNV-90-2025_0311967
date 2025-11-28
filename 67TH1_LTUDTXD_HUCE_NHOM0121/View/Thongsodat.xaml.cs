using _67TH1_LTUDTXD_HUCE_NHOM0121.Model;
using _67TH1_LTUDTXD_HUCE_NHOM0121.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Thongsodat.xaml
    /// </summary>
    public partial class Thongsodat : Page
    {
        public Thongsodat()
        {
            InitializeComponent();
            this.DataContext = new ThongSoDatViewModel();
        }
        private void Thongsomong_Click(object sender, RoutedEventArgs e)
        {
            ThongsodatPage.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new Thongsomong());
            ClearNavigationHistory();
        }
        private void ClearNavigationHistory()
        {
            while (MainFrame.CanGoBack)
            {
                MainFrame.RemoveBackEntry();
            }
        }

        private void Luusolieu2_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as ThongSoDatViewModel;
            if (viewModel == null) return;

            // Lấy dữ liệu từ DataGrid (DanhSachDat trong ViewModel)
            var danhSachDaCopy = new ObservableCollection<DuLieuDat>(viewModel.DanhSachDat);

            // Lưu dữ liệu vào MainWindow
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.DanhSachDat = danhSachDaCopy; // Gán vào thuộc tính DanhSachDat của MainWindow
            }
            DuLieuDat.ThongTinDat = danhSachDaCopy;
            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo");
        }
    }
}
