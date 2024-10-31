using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void TestGildedRose()
    {
        var a = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 50, Clamper = new ClampMaxQualityTo50()};
        a.UpdateQuality();
        Assert.That(a.Quality, Is.EqualTo(50));
    }
}