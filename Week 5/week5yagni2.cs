public class CollectibleDot
{
    public string itemName = "Dot";
    public int pointValue = 10;
    public void Collect(Player player)
    {
        {
            player.AddScore(pointValue);
            Debug.Log(itemName + " collected! It is ");
        }
    }
}

