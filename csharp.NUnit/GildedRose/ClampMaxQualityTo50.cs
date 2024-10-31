using System;

namespace GildedRoseKata;

public class ClampMaxQualityTo50 : IQualityClamper
{
    public int Clamp(int quality)
    {
        return Math.Min(50, quality);
    }
}