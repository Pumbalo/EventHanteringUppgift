using System.ComponentModel.DataAnnotations;

namespace EventHanteringUppgift.Models;

public class MemberEvent
{
    public Guid EventId { get; set; }
    public Event Event { get; set; }
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
}
