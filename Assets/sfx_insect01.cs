using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_insect01 : MonoBehaviour
{
    AudioManager audioManager;
    private float elapseTime;
    private float waitTime = 2f;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        playSound();
    }

    void playSound() 
    {
        elapseTime += Time.deltaTime;
        if (elapseTime > waitTime)
        {
            audioManager.Play_insect01();
            elapseTime = 0;
        }
    }
}
