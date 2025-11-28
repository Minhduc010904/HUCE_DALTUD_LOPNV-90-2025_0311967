using _67TH1_LTUDTXD_HUCE_NHOM0121.Model;
using _67TH1_LTUDTXD_HUCE_NHOM0121.ViewModel;
using System;
using System.Collections.Generic;
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

    public partial class Chongdamthung : Page
    {
        public Chongdamthung(MongDon mongDon, DuLieuDat duLieuDat)
        {
            InitializeComponent();
            var viewModel = new ChongDamThungViewModel(mongDon, duLieuDat);
            this.DataContext = viewModel;
        }


        private void Luusolieucdt_Click(object sender, RoutedEventArgs e)
        {
            var chongDamThung = new ChongDamThung
            {
                ChieuDayLopBaoVe = float.Parse(txtChieuDayLopBaoVe.Text),
                h0 = float.Parse(txth0.Text),
                Pomax = float.Parse(txtPomax.Text),
                Pomin = float.Parse(txtPomin.Text),
                Pot = float.Parse(txtPot.Text),
                Pdt = float.Parse(txtPdt.Text),
                Pcdt = float.Parse(txtPcdt.Text),

            };
            ChongDamThung.ThongTinCdt = chongDamThung;
        }
    }
}
