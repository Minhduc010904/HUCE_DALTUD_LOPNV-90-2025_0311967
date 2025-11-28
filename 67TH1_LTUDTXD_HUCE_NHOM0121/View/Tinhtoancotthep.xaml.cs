using _67TH1_LTUDTXD_HUCE_NHOM0121.Model;
using _67TH1_LTUDTXD_HUCE_NHOM0121.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Interaction logic for Tinhtoancotthep.xaml
    /// </summary>
    public partial class Tinhtoancotthep : Page
    {
        public Tinhtoancotthep(MongDon mongDon, DuLieuDat duLieuDat, ChongDamThung chongDamThung)
        {
            InitializeComponent();
            var viewModel = new TinhToanCotThepViewModel(mongDon, duLieuDat, chongDamThung);
            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tinhToanCotThep = new TinhToanCotThep
            {
                Pong = float.Parse(txtPong.Text),
                Bng = float.Parse(txtBng.Text),
                Lng = float.Parse(txtLng.Text),
                Mlng = float.Parse(txtMlng.Text),
                FaYeuCauDai = float.Parse(txtFaYeuCauDai.Text),
                Mbng = float.Parse(txtMbng.Text),
                FaYeuCauNgan = float.Parse(txtFaYeuCauNgan.Text)

            };
            TinhToanCotThep.ThongTinCt = tinhToanCotThep;
        }
    }
}
