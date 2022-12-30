using Model.Entities.Things;
using Model.Entities.Things.Electronics;
using Model.Entities.Things.Electronics.Cables;
using Model.Entities.Things.Electronics.Cables.Adapters;
using Model.Entities.Things.Electronics.Cables.AudioCables;
using Model.Entities.Things.Electronics.Cables.ChargingCables;
using Model.Entities.Things.Electronics.Cables.Hubs;
using Model.Entities.Things.Electronics.Cables.SpecialCables;
using Model.Entities.Things.Electronics.Cables.TrunkCables;
using Model.Entities.Things.Electronics.Cables.VideoCables;

namespace Model.Configuration;

public class ModelDbContext : DbContext {
    
    public DbSet<CableEnd> CableEnds { get; set; }
    public DbSet<CableHasEnds> CableHasEnds { get; set; }
    public DbSet<Cable> Cables { get; set; }
    public DbSet<ConnectionType> EConnectionTypes { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Thing> Things { get; set; }
    public DbSet<Adapter> Adapters { get; set; }
    public DbSet<ChargingCable> ChargingCables { get; set; }
    public DbSet<Hub> Hubs { get; set; }
    public DbSet<Electronic> Electronics { get; set; }
    public DbSet<TrunkCable> TrunkCables { get; set; }
    public DbSet<VideoCable> VideoCables { get; set; }
    public DbSet<AudioCable> AudioCables { get; set; }
    public DbSet<SpecialCable> SpecialCables { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleClaim> RoleClaims { get; set; }
    
    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        // UNIQUE

        builder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        builder.Entity<Role>()
            .HasIndex(r => r.Identifier)
            .IsUnique();

        // HAS KEY
        builder.Entity<RoleClaim>()
            .HasKey(rc => new { rc.UserId, rc.RoleId });

        builder.Entity<CableHasEnds>()
            .HasKey(che => new { che.CableId, che.CableEndId });
        
        // RELATIONSHIPS
        // 1:1
        // 1:N

        builder.Entity<Thing>()
            .HasOne(t => t.Place)
            .WithMany()
            .HasForeignKey(t => t.PlaceId);

        builder.Entity<CableEnd>()
            .HasOne(ce => ce.ConnectionType)
            .WithMany()
            .HasForeignKey(ce => ce.ConnectionTypeId);
        
        // N:M

        builder.Entity<RoleClaim>()
            .HasOne(rc => rc.Role)
            .WithMany(r => r.RoleClaims)
            .HasForeignKey(rc => rc.RoleId);

        builder.Entity<RoleClaim>()
            .HasOne(rc => rc.User)
            .WithMany(u => u.RoleClaims)
            .HasForeignKey(rc => rc.UserId);

        builder.Entity<CableHasEnds>()
            .HasOne(che => che.Cable)
            .WithMany()
            .HasForeignKey(che => che.CableId);

        builder.Entity<CableHasEnds>()
            .HasOne(che => che.CableEnd)
            .WithMany()
            .HasForeignKey(che => che.CableEndId);

        // OTHER
        // SEEDING
        builder.Entity<Role>()
            .HasData(new Role { Id = 1, Identifier = "Admin", Description = "Administrator" });
    }
}