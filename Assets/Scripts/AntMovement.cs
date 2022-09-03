using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AntMovement : MonoBehaviour
{
    public float speed;
    
    Rigidbody2D rig;
    Transform play;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        play = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        
    }

    void escapePlayer()
    {
        Vector3 move = transform.position - play.position;
        rig.velocity = move.normalized * speed;
        Debug.Log(move.normalized);
        float angle = -(Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
        //transform.rotation = Quaternion.Lerp(, move, 0.01f);
        this.transform.DORotateQuaternion(q, 0.5f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            escapePlayer();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            rig.velocity = Vector2.zero;
    }

}
