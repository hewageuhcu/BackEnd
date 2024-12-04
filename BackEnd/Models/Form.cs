using System.ComponentModel.DataAnnotations;
using MimeKit.Cryptography;

// public class Form{
//     public int Id { get; set; }
//     [Required]
//     public string Name { get; set; }
//     [Required]
//     public String PhoneNumber { get; set; }
//     [Required]
//     public string Email { get; set; }
//     [Required]
//     public int quantity { get; set; }
//     [Required]
//     public string Address { get; set; }
// }

public class Form
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Form()
    {
        Name = "Default Name";
        PhoneNumber = "0000000000";
        Email = "example@example.com";
        Address = "Default Address";
    }
}
