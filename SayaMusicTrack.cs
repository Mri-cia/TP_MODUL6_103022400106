using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        if (string.IsNullOrEmpty(title)) Console.WriteLine("Title can't be empty \n");

        if (title.Length > 100)
        {
            Console.WriteLine("Title can't be more than 100 characters \n");
            return;
        }


        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
        {
            Console.WriteLine("Playcount is over than 10000000 \n");
            return;
        }

        
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