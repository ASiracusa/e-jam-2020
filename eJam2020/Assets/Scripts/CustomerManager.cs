using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public CustomerManager current;

    private int errorTol; //amount of errors to 
    private int totalCustomers;
    public List<GameObject> items;

    void Start()
    {
        current = this;
        errorTol = 1;
        totalCustomers = 2;

        NewCustomer();
    }

    public void NewCustomer(){
        items = new List<GameObject>();
        totalCustomers -= 1;
        errorTol = 1;
        GameObject[] nextitems = Resources.LoadAll<GameObject>("Items");
        int rand = Random.Range(0,nextitems.Length - 1);
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
}
