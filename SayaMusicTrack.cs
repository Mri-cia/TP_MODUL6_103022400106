using System;
using System.Collections.Generic;
using System.Text;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title) 
    {
        id = Random.Shared.Next(1, 99999);
        playCount = "0";
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    { 
        playCount = (int.Parse(playCount) + count).ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"""
            Title: {title} 
            ID: {id} 
            Playcount: {playCount}
            """);
    }
}