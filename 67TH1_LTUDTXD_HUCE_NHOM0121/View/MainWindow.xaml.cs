using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _67TH1_LTUDTXD_HUCE_NHOM0121.Model;
using _67TH1_LTUDTXD_HUCE_NHOM0121.View;
using _67TH1_LTUDTXD_HUCE_NHOM0121.ViewModel;

namespace _67TH1_LTUDTXD_HUCE_NHOM0121
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isCheckMenuVisible = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {

            isCheckMenuVisible = !isCheckMenuVisible;


            CheckMenu.Visibility = isCheckMenuVisible ? Visibility.Visible : Visibility.Collapsed;
        }

      
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Visible;
            tieude.Visibility = Visibility.Visible;
            login.Visibility = Visibility.Visible;
            ClearNavigationHistory();
        }
        private void Nhapsolieu_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new Thongsomong());
            ClearNavigationHistory();
        }


        private void SucchiutaiButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            var mongDon = MongDon.ThongTinMong;
            var duLieuDat = DuLieuDat.ThongTinDat.FirstOrDefault();
            MainFrame.Navigate(new Succhiutai(mongDon, duLieuDat));
            ClearNavigationHistory();
        }


        private void DolunButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new Dolun());
            ClearNavigationHistory();
        }


        private void ChongdamthungButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            var mongDon = MongDon.ThongTinMong;
            var duLieuDat = DuLieuDat.ThongTinDat.FirstOrDefault();
            MainFrame.Navigate(new Chongdamthung(mongDon, duLieuDat));
            ClearNavigationHistory();
        }

        private void TinhtoanButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            var mongDon = MongDon.ThongTinMong;
            var duLieuDat = DuLieuDat.ThongTinDat.FirstOrDefault();
            var chongDamThung = ChongDamThung.ThongTinCdt;
            MainFrame.Navigate(new Tinhtoancotthep(mongDon,duLieuDat,chongDamThung));
            ClearNavigationHistory();
        }


        private void BotriButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;

            var mongDon = MongDon.ThongTinMong;
            var duLieuDat = DuLieuDat.ThongTinDat.FirstOrDefault();
            var tinhToanCotThep = TinhToanCotThep.ThongTinCt;
            var chongDamThung = ChongDamThung.ThongTinCdt;
            MainFrame.Navigate(new Botricotthep(mongDon, duLieuDat,tinhToanCotThep ,chongDamThung));
            ClearNavigationHistory();
        }
        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            anhnen.Visibility = Visibility.Collapsed;
            tieude.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new Xuatketqua());
            ClearNavigationHistory();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ClearNavigationHistory()
        {
            while (MainFrame.CanGoBack)
            {
                MainFrame.RemoveBackEntry();
            }
        }
        public MongDon SolieuData { get; set; }
        public ObservableCollection<DuLieuDat> DanhSachDat { get; set; }
        public MainWindow(ObservableCollection<DuLieuDat> danhSachDat, MongDon solieuData)
        {
            DanhSachDat = danhSachDat;
            SolieuData = solieuData;
        }
        private void RunCalculationButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new MainWindow(DanhSachDat, SolieuData);


            var solieuWindow = new SolieuWindow
            {
                DataContext = viewModel
            };

            solieuWindow.Show();
        }
    }

}
