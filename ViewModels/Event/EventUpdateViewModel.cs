using System.ComponentModel.DataAnnotations;

namespace EventHanteringUppgift.Controllers;

// Behövs denna?

public class EventUpdateViewModel
{
    [Required(ErrorMessage = "Titel måste finnas")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Startdatum måste finnas")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Plats måste finnas")]
    public string Location { get; set; }

    [Required(ErrorMessage = "Beskrivning måste finnas")]
    public string Description { get; set; }
}
