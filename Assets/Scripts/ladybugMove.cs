using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladybugMove : MonoBehaviour
{
    //瓢蟲，每個一段時間閃現位置

    Vector2 origin;
    float countdown;
    private void Awake()
    {
        countdown = 2;
    }


    private void Start()
    {
        origin = transform.position;
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
