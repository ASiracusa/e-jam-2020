﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//EVERYTHING COMMENTED IS FOR LATER
public class Constansts{
/*
    readonly string[][] noBar= {
        {"Pasta1", "3.99"},
        {"ZBox", "354.99"},
        {"Ceral", "3.99"},
        };
*/
    readonly Dictionary<string, BarCode> yesBar = new Dictionary<string, BarCode>
{
    {"12345678", new BarCode("Chocolate", 22.11)},
    {"87654321", new BarCode("Pasta", 11.22)},
    {"23038589", new BarCode("Sour Candy", 222.11)}
};
/*
    public Constansts{
        yesBar = MakeDic();

    }

    public IReadOnlyDictionary<string, BarCode> MakeDic(){
        var Dictionary<string, BarCode> temp=new Dictionary<string,BarCode>();
        for(int i =0;i<noBar.Length;i++){
            temp.add();
        }
    }


    readonly IReadOnlyDictionary<string, BarCode> yesBar;
*/



}


public enum ClickMode
{
    Touching,
    Scanning
}