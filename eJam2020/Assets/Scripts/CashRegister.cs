using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashRegister : MonoBehaviour
{
    public CashRegister current;
    public string messageBox;
    public float totalPrice;
    private static CashRegister instance = null;
    private static readonly object padlock = new object();


    // Start is called before the first frame update
    void Start()
    {
     current=Instance;
     ResetTotal();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToRegister(string itemName, float price){
        messageBox+=itemName + "|" + price + "\n";
        AdjustTotal(price);
    }

    public void AdjustTotal(float price){
        totalPrice+=price;
    }

    public void ResetTotal(){
        totalPrice=0;
        messageBox="";
    }

    //Thread Safe Singleton
    public static CashRegister Instance{
        get{ 
            lock(padlock) {
                if (instance == null){
                    instance = new CashRegister();
                }
                return instance;
            }
        }
    }
}