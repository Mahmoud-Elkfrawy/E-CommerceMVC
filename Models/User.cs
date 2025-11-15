using System.ComponentModel.DataAnnotations;

namespace E_CommerceMVC.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string ImgIsVaid { get; set; }


    }
}
