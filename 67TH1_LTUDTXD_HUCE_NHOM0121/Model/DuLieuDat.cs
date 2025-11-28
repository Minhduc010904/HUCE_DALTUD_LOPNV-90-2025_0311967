using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67TH1_LTUDTXD_HUCE_NHOM0121.Model
{
    public class DuLieuDat
    {

        public int IdDat { get; set; }
        public string LoaiDat { get; set; }
        public string TrangThai { get; set; }
        public double GocMaSat { get; set; }
        public double ModunNenEp { get; set; }
        public double LucDinh { get; set; }
        public double DungTrong { get; set; }

        public double ChieuDay { get; set; }
        public static ObservableCollection<DuLieuDat> ThongTinDat { get; set; } = new ObservableCollection<DuLieuDat>();
        public static DuLieuDat LopDatDauTien => ThongTinDat.FirstOrDefault();
    }
}
