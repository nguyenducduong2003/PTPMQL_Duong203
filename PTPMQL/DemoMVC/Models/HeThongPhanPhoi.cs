using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMVC.Models; // Đảm bảo rằng bạn đã thêm namespace này nếu cần thiết

namespace DemoMVC.Models;

public class HeThongPhanPhoi
{
    // Mã hệ thống phân phối (Khóa chính)
    [Key]
    public string? MaHTPP { get; set; }

    // Tên hệ thống phân phối
    public string? TenHTPP { get; set; }

    // Danh sách các đại lý thuộc hệ thống phân phối này
    public List<DaiLy> DanhSachDaiLy { get; set; } = new List<DaiLy>();
}
