using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67TH1_LTUDTXD_HUCE_NHOM0121.Model
{
    public class MongDon
    {
        public float N { get; set; }
        public float Q { get; set; }
        public float Momen { get; set; }
        public float chieuRongCot { get; set; }
        public float chieuDaiCot { get; set; }
        public string macBeTong { get; set; }
        public string macThep { get; set; }
        public float cuongDoBeTong { get; set; }
        public float cuongDoThep { get; set; }
        public float chieuDaiMong { get; set; }
        public float chieuRongMong { get; set; }
        public float chieuCaoMong { get; set; }

        public float chieuSauChonMong { get; set; }
        ObservableCollection<DuLieuDat> DanhSachDat { get; set; }

        // Constructor
        public MongDon()
        {
            DanhSachDat = new ObservableCollection<DuLieuDat>();
        }
        public static MongDon ThongTinMong { get; set; }
    }
}
