using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class aphidMove : MonoBehaviour
{
    //�H�ΡA�w�C���k�����a

    public float speed;

    Rigidbody2D rig;
    Transform play;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        play = GameObject.FindWithTag("Player").transform;
    }

    bool isSleep = false;
    private void Update()
    {
        if(�O�_��F���w��m(transform.position,play.position))
        {
            escapePlayer();
        }
        else
        {
            /*
            if (!isSleep)
            {
                rig.Sleep();
                isSleep = true;
            }
            */
            rig.velocity = Vector2.zero;
        }
    }

    void escapePlayer()
    {
        Vector3 move = transform.position - play.position;
        rig.velocity = move.normalized * speed;
        float angle = -(Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
        //transform.rotation = Quaternion.Lerp(, move, 0.01f);
        this.transform.DORotateQuaternion(q, 0.5f);
    }


    bool �O�_��F���w��m(Vector3 �ۤv, Vector3 �ؼЦ�m)
    {
        return (Vector3.Distance(�ۤv, �ؼЦ�m) <= 7);
    }
}
