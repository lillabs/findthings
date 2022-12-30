namespace Model.Entities.Things.Electronics.Cables.ChargingCables;

[Table("CHARGING_CABLES")]
public class ChargingCable : Cable
{
    [Column("AMPERE")]
    public float? Ampere { get; set; }
    
    [Column("VOLTAGE")]
    public float? Voltage { get; set; }
    
    [Column("WATT")]
    public float? Watt { get; set; }
}