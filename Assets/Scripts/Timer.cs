using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static Timer instance;

     public GameState state = GameState.Wait;

    float Total_Time;
    public float Last_Time = 60f;
    public float Ant_Time;
    public float Caterpillar_Time;
    public float Aphid_Time;
    public float LadyBug_Time;

    public Image UI_Fill;
    public GameObject Ending_Pic;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Total_Time = Last_Time;        
    }

    void Update()
    {        
        if (Last_Time>0&&(state == GameState.Start||state == GameState.Attack))
        {
            Last_Time -= Time.deltaTime;
        }
        else if (state == GameState.Start || state == GameState.Attack)
        {
            state = GameState.End;
        }
        if (state == GameState.End)
        {
            Ending_Pic.SetActive(true);
            Ending_Pic.GetComponentInChildren<Image>().sprite = PlayerData.instance.Ending();
        }
        UI_Fill.fillAmount = Last_Time / Total_Time;
    }
    public void AddTime(Insect insect)
    {
        switch((int)insect)
        {
            case 0:
                Last_Time += LadyBug_Time;
                Total_Time += LadyBug_Time;
                return;
            case 1:
                Last_Time += Caterpillar_Time;
                Total_Time += Caterpillar_Time;
                return;
            case 2:
                Last_Time += Aphid_Time;
                Total_Time += Aphid_Time;
                return;
            case 3:
                Last_Time += Ant_Time;
                Total_Time += Ant_Time;
                return;
        }
    }
    
}
public enum Insect
{
    LadyBug,
    Caterpillar,
    Aphid,
    Ant,
    Bruh,
}
public enum GameState
{
    Wait,
    Start,
    End,
    Attack,
}
