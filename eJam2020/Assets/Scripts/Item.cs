using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ItemName;
    public BarCode code;

    public Item(string n){
        ItemName=n;
    }

    public bool CheckBar(){
        return name.Equals(code.BarName);
    }

}
