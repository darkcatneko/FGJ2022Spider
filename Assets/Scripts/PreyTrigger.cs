using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyTrigger : MonoBehaviour
{
    public Insect This_insect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HitBox")&&this.CompareTag("Prey"))
        {
            Timer.instance.AddTime(This_insect);
            PlayerData.instance.AddCount(This_insect);
            Destroy(this.gameObject);
            Instantiate(PlayerData.instance.test,transform.position,Quaternion.identity);
        }
    }
}
