using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public float �a�Ϫ�, �a�ϼe;
    public float ��ê���Z�� = 10;
    public List<GameObject> ��ê���w�s��;
    

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
                print("�ͦ�");
                var �s���� = Instantiate(��ê���w�s��[Random.RandomRange(0, ��ê���w�s��.Count - 1)], transform.position, Quaternion.identity);
                �s����.transform.position = new Vector2(i * ��ê���Z�� + Random.RandomRange(-2f,2f) - �a�Ϫ�/2, j * ��ê���Z�� + Random.RandomRange(-2f, 2f) - �a�ϼe/2);
                �s����.transform.parent = transform.GetChild(0);
            }
        }
        //transform.GetChild(0).transform.position = new Vector2(�a�Ϫ� * 2, �a�ϼe * 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
