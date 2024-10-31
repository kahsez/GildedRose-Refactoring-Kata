namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    public IQualityClamper Clamper { get; set; }

    public void UpdateQuality()
    {
        switch (Name)
        {
            case "Aged Brie":
                UpdateAgedBrie();
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePass();        
                break;
            case "Sulfuras, Hand of Ragnaros":
                UpdateSulfuras();
                break;
            default:
                UpdateNormalItem();
                break;
        }

        if (Clamper != null)
        {
            Quality = Clamper.Clamp(Quality);
        }
    }

    void UpdateNormalItem()
    {
        SellIn -= 1;

        if (SellIn < 0)
        {
            Quality -= 2;
        }
        else
        {
            Quality -= 1;
        }
    }

    void UpdateSulfuras()
    {
    }

    void UpdateBackstagePass()
    {
        switch (SellIn)
        {
            case < 6:
                Quality += 3;
                break;
            case < 11:
                Quality += 2;
                break;
            default:
                Quality += 1;
                break;
        }
        
        SellIn -= 1;

        if (SellIn < 0)
        {
            Quality = 0;
        }
    }

    void UpdateAgedBrie()
    {
        SellIn -= 1;

        if (SellIn < 0)
        {
            Quality += 2;
        }
        else
        {
            Quality += 1;
        }
    }
}