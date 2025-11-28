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
    /// <summary>
    /// Interaction logic for Botricotthep.xaml
    /// </summary>
    public partial class Botricotthep : Page
    {
        public Botricotthep(MongDon mongDon, DuLieuDat duLieuDat,TinhToanCotThep tinhToanCotThep,ChongDamThung chongDamThung)
        {
            InitializeComponent();
            var viewModel = new BoTriCotThepViewModel(mongDon, duLieuDat, tinhToanCotThep, chongDamThung);
            this.DataContext = viewModel;
        }
    }
}
                                                                                                                                                