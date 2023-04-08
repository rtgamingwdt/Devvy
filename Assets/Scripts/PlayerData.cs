using System;

[System.Serializable]
public class PlayerData
{
    public Ideas ideas;
    public Features features;
    public Bugs bugs;
}

public class Ideas
{
    public int ideas;
    public double power;
    public double progress;
    public double maxProgress;
}

public class Features
{
    public int features;
    public int baseQuality;
    public double power;
    public double progress;
    public double maxProgress;
    public Boolean available;
}

public class Bugs
{
    public int bugs;
    public int qualityMulti;
    public double power;
    public double progress;
    public double maxProgress;
    public Boolean available;
}