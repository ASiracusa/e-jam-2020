using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private int errorTol; //amount of errors to 
    private int totalCustomers;
    public List<Item> items;
    public CustomerManager current;
    private static CustomerManager instance = null;
    private static readonly object padlock = new object();

    public CustomerManager(){
        errorTol=1;
        totalCustomers=2;    
        NewCustomer();
        current=Instance;
        totalCustomers=2;
        current=Instance;
    }

    public void NewCustomer(){
        totalCustomers-=1;
        errorTol=1;
        item nextitems = Resources.LoadAll<GameObject>("Items");
        var rand = Random.range(0,nextitems.count-1);
        Item curItem = Instantiate(nextitems[rand], new Vector3(-20, 1, 0), Quaternion.identity);
        items.Add(curItem);

    }

    public void DeductPoint(){
        if(errorTol<=0){
            //remove points
        }
    }

    public void DidError(){
        errorTol-=1;
    }

        public static CustomerManager Instance{
        get{ 
            lock(padlock) {
                if (instance == null){
                    instance = new CustomerManager();
                }
                return instance;
            }
        }
    }
}
