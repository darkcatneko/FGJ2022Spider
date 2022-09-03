using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ant_move : MonoBehaviour
{
    Rigidbody2D rig;
    Transform play;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        play = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 move =  transform.position - play.position;
        rig.velocity = move.normalized * 3;
        Debug.Log(move.normalized);
        float angle = -(Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
        //transform.rotation = Quaternion.Lerp(, move, 0.01f);
        this.transform.DORotateQuaternion(q, 0.5f);

    }
}
