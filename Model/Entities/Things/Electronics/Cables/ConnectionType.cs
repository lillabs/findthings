namespace Model.Entities.Things.Electronics.Cables;

[Table("E_CONNECTION_TYPE")]
public class ConnectionType
{
    [Key]
    [StringLength(100)]
    [Column("VALUE")]
    public string Value { get; set; }
}