using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private int errorTol; //amount of errors to 
    private int totalCustomers;
    public List<Item> items;

    public CustomerManager(){
        errorTol=1;
        totalCustomers=2;
        //random items
    }
    public void NewCustomer(){
        totalCustomers-=1;
        errorTol=1;
        //random items
    }
    public void DeductPoint(){
        if(errorTol<=0){
            //remove points
        }
    }
    public void DidError(){
        errorTol-=1;
    }
}
