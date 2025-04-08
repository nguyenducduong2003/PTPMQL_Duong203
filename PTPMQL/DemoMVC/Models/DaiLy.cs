using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMVC.Models; // Đảm bảo rằng bạn đã thêm namespace này nếu cần thiết

namespace DemoMVC.Models;

public class DaiLy
{
    // Mã đại lý (Khóa chính)
    [Key]
    public string? MaDaiLy { get; set; }

    // Tên đại lý
    public string? TenDaiLy { get; set; }

    // Địa chỉ của đại lý
    public string? DiaChi { get; set; }

    // Người đại diện của đại lý
    public string? NguoiDaiDien { get; set; }

    // Số điện thoại của đại lý
    public string? DienThoai { get; set; }

    // Mã hệ thống phân phối liên kết (Khóa ngoại)
    [ForeignKey("HeThongPhanPhoi")]
    public string? MaHTPP { get; set; }

    // Tham chiếu đến đối tượng HeThongPhanPhoi (navigation property)
    public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
}
