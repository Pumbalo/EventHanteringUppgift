using EventHanteringUppgift.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHanteringUppgift.Data;

public class EventDbContext: DbContext
{
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Member> Members => Set<Member>();
    public DbSet<MemberEvent> MemberEvent => Set<MemberEvent>();
    public EventDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure EventId as the primary key with Guid type
        modelBuilder.Entity<Event>()
            .Property(e => e.EventId)
            .ValueGeneratedOnAdd()
            .IsRequired();

        // Sammansatt primärnyckel som består av EventId och MemberId...
        modelBuilder.Entity<MemberEvent>()
            .HasKey(sc => new{sc.EventId, sc.MemberId});
        
        // Förhållandet  för att en member kan vara anmäld på flera events...
        modelBuilder.Entity<MemberEvent>()
            .HasOne(sc => sc.Member)
            .WithMany(c => c.MemberEvents)
            .HasForeignKey(sc => sc.MemberId);

        // Förhållandet fär att ett event kan ha flera members...
        modelBuilder.Entity<MemberEvent>()
            .HasOne(sc => sc.Event)
            .WithMany(c => c.MemberEvents)
            .HasForeignKey(sc => sc.EventId);
    }
}
