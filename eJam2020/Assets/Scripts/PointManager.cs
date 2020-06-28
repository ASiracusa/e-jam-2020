using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public PointManager current;
    private static PointManager instance = null;
    private static readonly object padlock = new object();
    public int score;

    public PointManager(){
        score=10;
        current=Instance;
    }
    
    public static PointManager Instance{
        get{ 
            lock(padlock) {
                if (instance == null){
                    instance = new PointManager();
                }
                return instance;
            }
        }
    }
}
