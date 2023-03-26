namespace DataLayer.Entities;


public class Stats
{
    public int Id { get; set; }
    public int GoalsScored { get; set; }
    public int Assists { get; set; }
    public int Appearances { get; set; }
    public int YellowCards { get; set; }
    public int RedCards { get; set; }
    public Tournament Tournament { get; set; }
    public int PlayerId { get; set; }
    public Player Player { get; set; }
    

}
