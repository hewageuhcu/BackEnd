using System.ComponentModel.DataAnnotations;
using MimeKit.Cryptography;
using Org.BouncyCastle.Utilities;

public class Form
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Email { get; set; }
    public required int Quantity { get; set; }   
    public required string Address { get; set; }

}
