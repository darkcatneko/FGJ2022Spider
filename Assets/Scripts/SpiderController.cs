using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpiderController : MonoBehaviour
{
    bool Attacking = false;
    public bool Player_1_Pushed = false;
    public bool Player_2_Pushed = false;
    public bool Player_3_Pushed = false;
    public bool Player_4_Pushed = false;
    public int PressedCount = 0;
    public int RotationCount;
    public int[] Inputs = new int[4];
    public Animator[] SpiderAnimator = new Animator[8];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TestUseInput();
        if (Player_1_Pushed == false&&Attacking == false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Inputs[PressedCount] = 1;
                SpiderAnimator[0].SetBool("move", true);
                SpiderAnimator[6].SetBool("move", true);
                PressedCount++;
                Player_1_Pushed = true;
            }
        }
        if (Player_2_Pushed == false && Attacking == false)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                Inputs[PressedCount] = 2;
                SpiderAnimator[1].SetBool("move", true);
                SpiderAnimator[7].SetBool("move", true);
                PressedCount++;
                Player_2_Pushed = true;
            }
        }
        if (Player_3_Pushed == false && Attacking == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Inputs[PressedCount] = 3;
                SpiderAnimator[2].SetBool("move", true);
                SpiderAnimator[4].SetBool("move", true);
                PressedCount++;
                Player_3_Pushed = true;
            }
        }
        if (Player_4_Pushed == false && Attacking == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Inputs[PressedCount] = 4;
                SpiderAnimator[3].SetBool("move", true);
                SpiderAnimator[5].SetBool("move", true);
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
            Invoke("AnimationLag", 0.25f);
            PressedCount = 0;
            for (int i = 0; i < Inputs.Length; i++)
            {
                Inputs[i] = 0;
            }
        }
    }
    //public void TestUseInput()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        Forward((int)transform.rotation.eulerAngles.z,0.5f);
    //    }
    //}
    public void AnimationLag()
    {
        for (int i = 0; i < SpiderAnimator.Length; i++)
        {
            SpiderAnimator[i].SetBool("move", false);
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
                Forward(RotationCount,0.5f,1f);
                return;
            case 1324:
            case 3124:
            case 1342:
            case 3142:
                if (Attacking ==false)
                {
                    StartCoroutine("SpiderAttack");
                }
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
    public void Forward(int Degree,float Speed,float Distance)
    {
        switch((Degree+360)%360)
        {
            case 0:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(0, 1, 0)*Distance, Speed);
                return;
            case 315:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, 1, 0) * Distance, Speed);
                return;
            case 270:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, 0, 0) * Distance, Speed);
                return;
            case 225:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(1, -1, 0) * Distance, Speed);
                return;
            case 180:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(0, -1, 0) * Distance, Speed);
                return;
            case 135:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, -1, 0) * Distance, Speed);
                return;
            case 90:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, 0, 0) * Distance, Speed);
                return;
            case 45:
                this.GetComponent<Rigidbody2D>().DOMove(transform.position + new Vector3(-1, 1, 0) * Distance, Speed);
                return;
        }
    }
   public IEnumerator SpiderAttack()
    {
        Attacking = true;
        Debug.Log(1);
        Vector3 Past = transform.position;        
        Forward(RotationCount,0.2f, 2f);
        yield return new WaitForSeconds(0.4f);
        this.GetComponent<Rigidbody2D>().DOMove(Past, 1.5f);
        yield return new WaitForSeconds(1.5f);
        Attacking = false;
    }
}
