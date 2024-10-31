using System;

namespace GildedRoseKata;

public class ClampMinQualityToZero : IQualityClamper
{
    public int Clamp(int quality)
    {
        return Math.Max(0, quality);
    }
}