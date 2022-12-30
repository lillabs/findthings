namespace Model.Entities.Things;

[Table("PLACES")]
public class Place
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("PLACE_ID")]
    public int Id { get; set; }
    
    [DataType(DataType.Text)]
    [Column("DESCRIPTION")]
    public string? Description { get; set; }
    
    [StringLength(100)]
    [Column("ROOM")]
    public string? Room { get; set; }
    
    [StringLength(50)]
    [Column("PLACE_COLUMN")]
    public string? PlaceColumn { get; set; }
    
    [StringLength(50)]
    [Column("PLACE_ROW")]
    public string? PlaceRow { get; set; }
}