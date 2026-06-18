using RestaurantService.Domain.Common.Abstractions;
using RestaurantService.Domain.Enums;
using System.ComponentModel.DataAnnotations;
namespace RestaurantService.Domain.Identity;

public class User : ICreatable
{
    public static User Register(string firstName, string lastName, string phone, string nationalCode)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
            string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(nationalCode))
        {
            throw new Exception("invalid input");
        }

        return new User()
        {
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phone,
            NationalCode = nationalCode,

            Gender = Gender.NONE,
            IsDeleted = false,
            DeletedAt = null,
            UpdatedAt = null,
            CreatedAt = DateTime.Now,

            IsApproveByAdmin = false



        };
    }

    public void ApproveUser()
    {
        IsApproveByAdmin = true;
    }

    public void UpdateFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public int Id { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public string PhoneNumber { get; set; }

    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Gender Gender { get; set; }
    public bool IsApproveByAdmin { get; set; }

}
