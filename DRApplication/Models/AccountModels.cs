using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


namespace DRApplication.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DRdb")
        {
        }

        public DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
    }

    [Table("EMPLOYEE")]
    public class UserProfile
    {
        [Key]
        public int EMP_ID { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "UserName")]
        public string UserName { get; set; } //Employee UserName

    }

    public class LocalPasswordModel
    {
        [Required]
        [StringLength(25, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Employee ID")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }


        public bool IsValid(string UserName, string Password)
        {
            var crypto = new SimpleCrypto.PBKDF2();

            bool isValid = false;

            using (var db = new JSO())
            {
                var user = db.EMPLOYEEs.FirstOrDefault(u => u.USERNAME == UserName);
                if (user != null)
                {
                    if (user.PASSWORD == crypto.Compute(Password, user.PASSWORD))
                    {
                        isValid = true;
                    }
                }
            }
            return isValid;
        }
    }
        


    public class RegisterModel
    {
        [Required]
        [Display(Name = "Employee ID")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}

