using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace asp_mvc_2.Models.ViewModel
{
    public class UserSignUpView
    {
        [Key]
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public string RoleName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
    public class UserLoginView
    {
        [Key]
        public int SYSUserID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
    public class UserProfileView
    {
        [Key]
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public string RoleName { get; set; }
        public bool? IsRoleActive { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
    public class LOOKUPAvailableRole
    {
        [Key]
        public int LOOKUPRoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }

    public class Gender
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class UserRoles
    {
        public int? SelectedRoleID { get; set; }
        public IEnumerable<LOOKUPAvailableRole> UserRoleList { get; set; }
    }

    public class UserGender
    {
        public string SelectedGender { get; set; }
        public IEnumerable<Gender> Gender { get; set; }
    }

    public class UserDataView
    {
        public IEnumerable<UserProfileView> UserProfile { get; set; }
        public UserRoles UserRoles { get; set; }
        public UserGender UserGender { get; set; }
    }
    public class AddBook
    {
        [Key]
        [Required(ErrorMessage = "* Isi ID Buku!")]
        [Display(Name = "ID Buku")]
        public int id_buku { get; set; }
        [Required(ErrorMessage = "* Isi Judul Buku!")]
        [Display(Name = "Judul Buku")]
        public string judul { get; set; }
        [Required(ErrorMessage = "* Isi ISBN")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "* Isi Nama Penulis!")]
        [Display(Name = "Penulis Buku")]
        public string penulis { get; set; }
        [Required(ErrorMessage = "* Isi Nama Penerbit!")]
        [Display(Name = "Penerbit Buku")]
        public string penerbit { get; set; }
        [Required(ErrorMessage = "* Isi Tahun Terbit")]
        [Display(Name = "Tahun Terbit")]
        public int tahun { get; set; }
        [Required(ErrorMessage = "* Isi Stok!")]
        [Display(Name = "Stok Buku")]
        public int stok { get; set; }
    }
    public class AddReport
    {
        [Key]
        [Required(ErrorMessage = "*")]
        [Display(Name = "ID Laporan")]
        public int id_laporan { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "ID Pelanggan")]
        public int id_pelanggan { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "ID Buku")]
        public int id_buku { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Tanggal Pinjam")]
        public string tgl_pinjam { get; set; }
        [Display(Name = "tgl_kembali")]
        public string tgl_kembali { get; set; }
    }
}