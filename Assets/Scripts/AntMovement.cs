using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AntMovement : MonoBehaviour
{
    //螞蟻，半徑內隨機快速移動

    public float speed;
    
    Rigidbody2D rig;
    public Vector2 origin;
    Vector3 NextPos;
    //Transform play;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        //nextPoint();
        //play = GameObject.FindWithTag("Player").transform;
    }

    private void Start()
    {
        //origin = transform.position;
    }

    public void 初始化(Vector2 初始位置)
    {
        origin = 初始位置;
        nextPoint();
    }

    void nextPoint()
    {
        float RandomDistance = Random.Range(1.5f, 3f);
        NextPos = new Vector2(origin.x + Random.Range(-RandomDistance, RandomDistance), (origin.y + Random.Range(-RandomDistance, RandomDistance)));
        //Debug.Log(NextPos);
    }

    bool 是否抵達指定位置(Vector3 自己, Vector3 目標位置)
    {
        return (Vector3.Distance(自己, 目標位置) <= 1);
    }

    void findTarget()
    {
        //rig.MovePosition(Target);
        Vector3 move = transform.position - NextPos;
        //rig.velocity = move.normalized * speed;
        float angle = -(Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 50);

        //this.transform.DORotateQuaternion(q, 0.5f);
    }

    private void Update()
    {
        //findTarget();
        if (!是否抵達指定位置(this.transform.position, NextPos))
        {
            //反方向轉向
            findTarget();
            //前進
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, NextPos, step);
        }
        else { 
            //設定新目標位置
            nextPoint(); 
        }
    }


}
