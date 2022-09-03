using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpiderController : MonoBehaviour
{
    public float Speed; 
    public bool Player_1_Pushed = false;
    public bool Player_2_Pushed = false;
    public bool Player_3_Pushed = false;
    public bool Player_4_Pushed = false;
    public int PressedCount = 0;
    public int RotationCount;
    public int[] Inputs = new int[4];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestUseInput();
        if (Player_1_Pushed == false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Inputs[PressedCount] = 1;
                PressedCount++;
                Player_1_Pushed = true;
            }
        }
        if (Player_2_Pushed == false)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                Inputs[PressedCount] = 2;
                PressedCount++;
                Player_2_Pushed = true;
            }
        }
        if (Player_3_Pushed == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Inputs[PressedCount] = 3;
                PressedCount++;
                Player_3_Pushed = true;
            }
        }
        if (Player_4_Pushed == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Inputs[PressedCount] = 4;
                PressedCount++;
                Player_4_Pushed = true;
            }
        }
        if (Player_1_Pushed == true && Player_2_Pushed == true && Player_3_Pushed == true&& Player_4_Pushed == true)
        {
            Debug.Log((Inputs[0] * 1000 + Inputs[1] * 100 + Inputs[2] * 10 + Inputs[3]));
            Code_To_Movement((Inputs[0] * 1000 + Inputs[1] * 100 + Inputs[2] * 10 + Inputs[3]));
            Player_1_Pushed = false;
            Player_2_Pushed = false;
            Player_3_Pushed = false;
            Player_4_Pushed = false;
            PressedCount = 0;
            for (int i = 0; i < Inputs.Length; i++)
            {
                Inputs[i] = 0;
            }
        }
    }
    public void TestUseInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Forward((int)transform.rotation.eulerAngles.x);
        }
    }
    public void Code_To_Movement(int Code)
    {
        switch(Code)
        {
            case 2413:
            case 2431:
            case 4213:
            case 4231:
                Forward(RotationCount);
                return;
            case 1324:
            case 3124:
            case 1342:
            case 3142:
                return;
            case 1234:
                transform.DORotate(transform.rotation.eulerAngles + new Vector3(0, 0, 45),0.5f);
                RotationCount += 45;
                if (RotationCount>=360)
                {
                    RotationCount = 0;
                }                
                return;
            case 4321:
                transform.DORotate(transform.rotation.eulerAngles + new Vector3(0, 0, -45), 0.5f);
                if (RotationCount<= -360)
                {
                    RotationCount = 0;
                }
                RotationCount -= 45;
                return;
            default:
                return;
        }
    }
    public void Forward(int Degree)
    {
        switch((Degree+360)%360)
        {
            case 0:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(0, 1, 0), 0.5f);
                return;
            case 315:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, 1, 0), 0.5f);
                return;
            case 270:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, 0, 0), 0.5f);
                return;
            case 225:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, -1, 0), 0.5f);
                return;
            case 180:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(0, -1, 0), 0.5f);
                return;
            case 135:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, -1, 0), 0.5f);
                return;
            case 90:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, 0, 0), 0.5f);
                return;
            case 45:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, 1, 0), 0.5f);
                return;
        }
    }
   
}
