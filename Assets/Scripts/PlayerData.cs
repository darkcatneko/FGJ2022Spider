using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public AudioManager audio;

    public GameObject test;

    public static PlayerData instance;

    public int RotationCount;

    int[] Insects_Count = new int[4];

    public Text[] Scores = new Text[4];

    public Sprite[] EndingCG = new Sprite[5];
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        Score_Update();
    }
    public void Score_Update()
    {

        for (int i = 0; i < Insects_Count.Length; i++)
        {
            Scores[i].text = Insects_Count[i].ToString();
        }
    }
    public Sprite Ending()
    {
        int Biggest = 0;
        int NowWinner = 0;
        bool Clear = true;
        for (int i = 0; i < 4; i++)
        {
            if (Insects_Count[i] >= Biggest)
            {
                Biggest = Insects_Count[i];
                NowWinner = i;
                
            }
        }
         if (Insects_Count[NowWinner]<3)
                    {
                        Clear = false;
                    }
                
        if (Clear == false)
        {
            return EndingCG[4];
        }
        else
        {
            return EndingCG[NowWinner];
        }
    }
    public void AddCount(Insect insect)
    {
        Insects_Count[(int)insect] += 1;
    }
}
