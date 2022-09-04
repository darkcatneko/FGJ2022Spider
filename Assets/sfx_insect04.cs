using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_insect04 : MonoBehaviour
{
    AudioManager audioManager;
    private float elapseTime;
    private float waitTime = 2.6f;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        elapseTime += Time.deltaTime;
        if (elapseTime > waitTime)
        {
            audioManager.Play_insect04();
            elapseTime = 0;
        }
    }
}
