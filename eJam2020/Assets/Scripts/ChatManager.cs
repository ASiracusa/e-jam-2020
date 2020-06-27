using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    public ChatManager current;
    private static ChatManager instance = null;
    private static readonly object padlock = new object();
    // Start is called before the first frame update
    void Start()
    {
        current = Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Thread Safe Singleton
    public static ChatManager Instance{
        get{ 
            lock(padlock) {
                if (instance == null){
                    instance = new ChatManager();
                }
                return instance;
            }
        }
    }
}
