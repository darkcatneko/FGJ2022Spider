using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladybugMove : MonoBehaviour
{
    Vector2 origin;
    float countdown;
    private void Awake()
    {
        origin = transform.position;
        countdown = 2;
    }

    
    void Update()
    {
        if(countdown <= 0)
        {
            transform.position = new Vector2(origin.x + Random.Range(-2f, 2f), origin.y + Random.Range(-2f, 2f));
            countdown = 2;
        }
        else
        {
            countdown -= Time.deltaTime; 
        }
    }
}
