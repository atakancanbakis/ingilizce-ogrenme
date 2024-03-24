using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IngilizceOgreniyorum.Models
{
    // base model ve database icin model

    public class UserModelBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate {  get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class UserModel : UserModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string HashedPassword { get; set; }

        public string SaltedPassword {  get; set; }
    }

    // Kullanici arayuzu ile etkilesime girecek modelleri barindiriyor

    public class UserLoginArgs
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class UserRegisterArgs : UserModelBase
    {
        public string Password { get; set; }
    }
}
