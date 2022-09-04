using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_insect02 : MonoBehaviour
{
    AudioManager audioManager;
    private float elapseTime;
    private float waitTime = 2.3f;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        elapseTime += Time.deltaTime;
        if (elapseTime > waitTime)
        {
            audioManager.Play_insect02();
            elapseTime = 0;
        }
    }
}
