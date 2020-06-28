using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    private int errorTol; //amount of errors to 
    private int totalCustomers;
    public List<GameObject> items;
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
        items = new List<GameObject>();
        totalCustomers-=1;
        errorTol=1;
        GameObject[] nextitems = Resources.LoadAll<GameObject>("Items");
        var rand = Random.Range(0,nextitems.Length-1);
        GameObject curItem = Instantiate(nextitems[rand], new Vector3(-20, 1, 0), Quaternion.identity);
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
