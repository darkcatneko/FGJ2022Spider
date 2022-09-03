using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //�o�̱ĥγ̨S�Ĳv�����k(��ҤƩҦ������A��K�ӧO�վ� ���q���j�p �������C)
    //�p�G�O�o�����|�binspect ���վ�n ���q���j�p �������C�� �i�J ���T�s��n�� ��X�վ�n�����ɡA����̦h�Ψ�2��3�� AudioSource �@�� �y�� �I�� ���� �T���n�D
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
