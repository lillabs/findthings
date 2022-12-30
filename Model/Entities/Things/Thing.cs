namespace Model.Entities.Things;

[Table("THINGS")]
public class Thing
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("THING_ID")]
    public int Id { get; set; }
    
    [Column("PLACE_ID")]
    public int PlaceId { get; set; }
    public Place Place { get; set; }
    
    [NotMapped]
    public bool IsSelected { get; set; }
}