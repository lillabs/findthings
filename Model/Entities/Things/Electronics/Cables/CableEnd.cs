namespace Model.Entities.Things.Electronics.Cables;

[Table("CABLE_ENDS")]
public class CableEnd
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CABLE_END_ID")]
    public int Id { get; set; }
    
    [Column("IS_MALE", TypeName = "TINYINT")]
    public bool IsMale { get; set; }
    
    [Column("CONNECTION_TYPE")]
    public string ConnectionTypeId { get; set; }
    public ConnectionType ConnectionType { get; set; }
}