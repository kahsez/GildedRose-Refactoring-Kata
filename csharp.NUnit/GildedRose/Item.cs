namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateQuality()
    {
        switch (Name)
        {
            case "Aged Brie":
                UpdateAgedBrie();
                return;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePass();
                return;
            case "Sulfuras, Hand of Ragnaros":
                UpdateSulfuras();
                return;
            default:
                UpdateNormalItem();
                break;
        }
    }

    void UpdateNormalItem()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }

        SellIn = SellIn - 1;

        if (SellIn < 0 && Quality > 0)
        {
            Quality = Quality - 1;
        }
    }

    void UpdateSulfuras()
    {
    }

    void UpdateBackstagePass()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;

            if (SellIn < 11 && Quality < 50)
            {
                Quality = Quality + 1;
            }

            if (SellIn < 6 && Quality < 50)
            {
                Quality = Quality + 1;
            }
        }

        SellIn = SellIn - 1;

        if (SellIn < 0)
        {
            Quality = Quality - Quality;
        }
    }

    void UpdateAgedBrie()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;
        }

        SellIn = SellIn - 1;

        if (SellIn < 0 && Quality < 50)
        {
            Quality = Quality + 1;
        }
    }
}