namespace Model.Entities.Things.Electronics.Cables;

[Table("CABLES")]
public class Cable : Electronic
{
    [Required]
    [Column("LENGTH")]
    public int Length { get; set; }
}