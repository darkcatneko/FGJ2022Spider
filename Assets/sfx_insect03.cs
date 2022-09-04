using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_insect03 : MonoBehaviour
{
    AudioManager audioManager;
    public bool playSfx = true;
    public float waitToPlaySfxTime = 2f;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        InvokeRepeating(nameof(audioManager.Play_insect03), 0, waitToPlaySfxTime);
    }
    private void Update()
    {
        if (!playSfx)
        {
            CancelInvoke(nameof(audioManager.Play_insect03));
        }
    }
}