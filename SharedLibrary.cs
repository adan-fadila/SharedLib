namespace SharedLibrary
{
    using System.Collections.Generic;

public class GameData
{

    public CardData[] Playe1HandCards { get; set; }

    public List<CardData> Playe2HandCards { get; set; }
    public string Playe2Id { get; set; }
    public string Location1Name { get; set; }
    public string Location1Desc { get; set; }
    public string Location2Name { get; set; }
    public string Location2Desc { get; set; }
    public string Location3Name { get; set; }
    public string Location3Desc { get; set; }

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
    public int PlayerLocatinScore { get; set; }
    public List<CardData> OpponentZone { get; set; }
     public int OpponentLocatinScore { get; set; }
}


}