using System.ComponentModel.DataAnnotations;

namespace EventHanteringUppgift.Models;

public class Event
{
    [Key]
    public Guid EventId { get; set; }
    public string Title { get; set; } = "";
    public DateTime StartDate { get; set; }
    public string Location { get; set; } = "";
    public string Description { get; set; } = "";

    public ICollection<MemberEvent> MemberEvents { get; set; }
}
