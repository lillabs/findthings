namespace Model.Entities.Things.Electronics.Cables;

[Table("CABLE_HAS_ENDS_JT")]
public class CableHasEnds
{
    [Column("CABLE_ID")]
    public int CableId { get; set; }
    public Cable Cable { get; set; }
    
    [Column("END_ID")]
    public int CableEndId { get; set; }
    public CableEnd CableEnd { get; set; }
}