using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //這裡採用最沒效率的做法(實例化所有音源，方便個別調整 音量的大小 音階高低)
    //如果是發布版會在inspect 中調整好 音量的大小 音階高低後 進入 音訊編輯軟體 輸出調整好的音檔，之後最多用到2或3個 AudioSource 作為 語音 背景 音效 三個聲道
    public AudioSource startGame;
    public AudioSource btnClick;
    public AudioSource btnHover;
    public AudioSource bgmMenu;
    public AudioSource bgmGame;
    public AudioSource tip;
    public AudioSource spider_step1;
    public AudioSource spider_step2;
    public AudioSource spider_sound;
    public AudioSource spider_jump;
    public AudioSource spider_land;
    public AudioSource spider_attack;
    public AudioSource spider_eat;
    public AudioSource getTime;
    public AudioSource countDown;
    public AudioSource score;
    public AudioSource alert;
    public AudioSource error;
    public AudioSource outTime;
    public AudioSource insect01;
    public AudioSource insect02;
    public AudioSource insect03;
    public AudioSource insect04;

    public void Play_startGame()
    {
        startGame.Play();
    }
    public void Play_btnClick()
    {
        btnClick.Play();
    }
    public void Play_btnHover()
    {
        btnHover.Play();
    }
    public void Play_bgmMenu()
    {
        bgmMenu.Play();
    }
    public void Play_bgmGame()
    {
        bgmGame.Play();
    }
    public void Play_tip()
    {
        tip.Play();
    }
    public void Play_spider_step1()
    {
        spider_step1.Play();
    }

    public void Play_spider_step2()
    {
        spider_step2.Play();
    }
    public void Play_spider_sound()
    {
        spider_sound.Play();
    }
    public void Play_spider_jump()
    {
        spider_jump.Play();
    }
    public void Play_spider_land()
    {
        spider_land.Play();
    }
    public void Play_spider_attack()
    {
        spider_attack.Play();
    }
    public void Play_spider_eat()
    {
        spider_eat.Play();
    }
    public void Play_getTime()
    {
        getTime.Play();
    }
    public void Play_countDown()
    {
        countDown.Play();
    }
    public void Play_score()
    {
        score.Play();
    }
    public void Play_alert()
    {
        alert.Play();
    }
    public void Play_error()
    {
        error.Play();
    }
    public void Play_outTime()
    {
        outTime.Play();
    }
    public void Play_insect01()
    {
        insect01.Play();
    }
    public void Play_insect02()
    {
        insect02.Play();
    }
    public void Play_insect03()
    {
        insect03.Play();
    }
    public void Play_insect04()
    {
        insect04.Play();
    }

}
