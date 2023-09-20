using System.ComponentModel.DataAnnotations;

namespace EventHanteringUppgift.Models;

public class MemberEvent
{
    public string EventId { get; set; } = "";
    public Event Event { get; set; }
    public string MemberId { get; set; } = "";
    public Member Member { get; set; }
}
