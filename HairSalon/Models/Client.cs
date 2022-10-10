namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public int Phone { get; set; }
    public string ApptDate { get; set; }
    public string Service { get; set; }
    public string StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}