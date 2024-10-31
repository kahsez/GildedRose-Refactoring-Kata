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
                ClampMaxQualityTo50();
                return;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePass();        
                ClampMaxQualityTo50();
                return;
            case "Sulfuras, Hand of Ragnaros":
                UpdateSulfuras();
                return;
            default:
                UpdateNormalItem();
                ClampMinQualityToZero();
                break;
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

    void ClampMinQualityToZero()
    {
        Quality = Math.Max(0, Quality);
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

    void ClampMaxQualityTo50()
    {
        Quality = Math.Min(50, Quality);
    }
}