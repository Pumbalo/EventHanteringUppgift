using System.ComponentModel.DataAnnotations;

namespace EventHanteringUppgift.Models;

public class Member
{
    [Key]
    public Guid MemberId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public string UserName { get; set; } = ""; //Email

    public ICollection<MemberEvent> MemberEvents { get; set; }
}
