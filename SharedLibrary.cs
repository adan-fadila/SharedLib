namespace SharedLibrary
{
    using System.Collections.Generic;

public class GameData
{
    PlayerData player1{get;set;}
   PlayerData player2{get;set;}
   
    public LocationData locationData1{ get; set; }
     public LocationData locationData2{ get; set; }
      public LocationData locationData3{ get; set; }

}
public class CardData
{

    public int id { get; set; }
    public string Name
    {
        get;
    }
    public string Desc
    {
        get;
    }
    public int Cost
    {
        get;
        set;
    }
    public int Power
    {
        get;
        set;
    }
}
public class PlayerData
{
    public string PlayeName { get; set; }
    public string PlayeId { get; set; }
    public List<CardData> HandCards { get; set; }

}
public class LocationData
{
    public string LoctaionName { get; set; }
    public string LoctaionDesc { get; set; }
    public List<CardData> PlayerZone { get; set; }
    public int Player1LocatinScore { get; set; }
    public List<CardData> OpponentZone { get; set; }
     public int Player2LocatinScore { get; set; }
}


}