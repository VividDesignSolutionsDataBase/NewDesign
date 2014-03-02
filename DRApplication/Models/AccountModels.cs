using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;


namespace DRApplication.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(): base("JSOContext")
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
       
        public string Role { get; set; } //Employee Role

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

        public bool IsValid(string _username, string _pwd)
        {
            string _sql = "Select UserName From EMPLOYEE Where UserName='" + _username + "' And Password='" + _pwd + "'";
            SqlConnection cn = new SqlConnection("Data Source=HOMESERV;Initial Catalog=JSO;Integrated Security=True;MultipleActiveResultSets=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(_sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;

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

        [Required]
        [Display(Name = "Admin")]
        public Boolean Admin { get; set; }

        [Required]
        [Display(Name = "Officer")]
        public Boolean Officer { get; set; }

        [Required]
        [Display(Name = "Supervisor")]
        public Boolean Supervisor { get; set; }

        [Required]
        [Display(Name = "Chief")]
        public Boolean Chief { get; set; }

    }
}

