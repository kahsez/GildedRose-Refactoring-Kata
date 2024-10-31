using System;

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
                Quality = ClampMaxTo50(Quality);
                return;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePass();        
                Quality = ClampMaxTo50(Quality);
                return;
            case "Sulfuras, Hand of Ragnaros":
                UpdateSulfuras();
                return;
            default:
                UpdateNormalItem();
                Quality = ClampMinToZero(Quality);
                break;
        }
    }

    int ClampMinToZero(int quality)
    {
        return Math.Max(0, quality);
    }

    int ClampMaxTo50(int quality)
    {
        return Math.Min(50, quality);
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