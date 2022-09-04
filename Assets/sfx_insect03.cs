using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_insect03 : MonoBehaviour
{
    AudioManager audioManager;
    private float elapseTime;
    private float waitTime = 1.5f;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        elapseTime += Time.deltaTime;
        if (elapseTime > waitTime)
        {
            audioManager.Play_insect03();
            elapseTime = 0;
        }
    }
}
