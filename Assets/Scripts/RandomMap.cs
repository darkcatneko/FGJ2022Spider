using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public float �a�Ϫ�, �a�ϼe;
    public float ��ê���Z�� = 10;
    public List<GameObject> ��ê���w�s��;
    public List<GameObject> �y���w�s��;


    void Start()
    {
        �H����ê���ͦ��I();
    }

    void �H����ê���ͦ��I()
    {
        //var �ͦ��ƶq = (�a�Ϫ� / 5 + �a�ϼe / 5);
        for (int i = 0; i < �a�Ϫ� / ��ê���Z��; i++)
        {
            for (int j = 0; j < �a�ϼe / ��ê���Z��; j++)
            {
                if(i== �a�Ϫ� / ��ê���Z�� / 2 && j == �a�ϼe / ��ê���Z�� / 2)
                {
                    print(�a�Ϫ� / ��ê���Z�� / 2);
                    print(�a�ϼe / ��ê���Z�� / 2);
                }
                else
                {
                    �ͦ�(i,j);
                }
            }
        }
        //transform.GetChild(0).transform.position = new Vector2(�a�Ϫ� * 2, �a�ϼe * 2);
    }

    // Update is called once per frame
    void �ͦ�(int i , int j)
    {
        GameObject �ͦ���;
        int �ͦ����v = Random.Range(0, 3);
        if (�ͦ����v == 0)
        {
            �ͦ��� = ��ê���w�s��[Random.Range(0, ��ê���w�s��.Count - 1)];
        }
        else
        {
            �ͦ��� = �y���w�s��[Random.Range(0, �y���w�s��.Count - 1)];
        }
        var �s���� = Instantiate(�ͦ���, transform.position, Quaternion.identity);
        �s����.transform.position = new Vector2(i * ��ê���Z�� + Random.Range(-4f, 4f) - �a�Ϫ� / 2, j * ��ê���Z�� + Random.Range(-4f, 4f) - �a�ϼe / 2);
        �s����.transform.parent = transform.GetChild(0);
        if (�s����.TryGetComponent(out AntMovement antMovement))
        {
            antMovement.��l��(�s����.transform.position);
        }
    }
}
