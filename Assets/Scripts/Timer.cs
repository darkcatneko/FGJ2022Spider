using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Last_Time = 60f;
    public float Ant_time;
    public float Caterpillar_Time;
    public float Aphid_Time;
    public float Ant_Time;
    void Start()
    {
        
    }

    void Update()
    {        
        if (Last_Time>0)
        {
            Last_Time -= Time.deltaTime;
        }
        else
        {
            Debug.Log("§A¦n»¹");
        }
    }
    public void AddTime(Insect insect)
    {
        switch((int)insect)
        {
            case 0:                
                return;
            case 1:
                return;
            case 2:
                return;
            case 3:
                return;
        }
    }
}
public enum Insect
{
    LadyBug,
    Caterpillar,
    Aphid,
    Ant,
}
