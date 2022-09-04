using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AntMovement : MonoBehaviour
{
    //���ơA�b�|���H���ֳt����

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

    public void ��l��(Vector2 ��l��m)
    {
        origin = ��l��m;
        nextPoint();
    }

    void nextPoint()
    {
        float RandomDistance = Random.Range(1.5f, 3f);
        NextPos = new Vector2(origin.x + Random.Range(-RandomDistance, RandomDistance), (origin.y + Random.Range(-RandomDistance, RandomDistance)));
        //Debug.Log(NextPos);
    }

    bool �O�_��F���w��m(Vector3 �ۤv, Vector3 �ؼЦ�m)
    {
        return (Vector3.Distance(�ۤv, �ؼЦ�m) <= 1);
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
        if (!�O�_��F���w��m(this.transform.position, NextPos))
        {
            //�Ϥ�V��V
            findTarget();
            //�e�i
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, NextPos, step);
        }
        else { 
            //�]�w�s�ؼЦ�m
            nextPoint(); 
        }
    }


}
