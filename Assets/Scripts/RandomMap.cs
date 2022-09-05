using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public float 地圖長, 地圖寬;
    public float 障礙物距離 = 10;
    public List<GameObject> 障礙物預製體;
    public List<GameObject> 獵物預製體;


    void Start()
    {
        隨機障礙物生成點();
    }

    void 隨機障礙物生成點()
    {
        //var 生成數量 = (地圖長 / 5 + 地圖寬 / 5);
        for (int i = 0; i < 地圖長 / 障礙物距離; i++)
        {
            for (int j = 0; j < 地圖寬 / 障礙物距離; j++)
            {
                if(i== 地圖長 / 障礙物距離 / 2 && j == 地圖寬 / 障礙物距離 / 2)
                {
                    print(地圖長 / 障礙物距離 / 2);
                    print(地圖寬 / 障礙物距離 / 2);
                }
                else
                {
                    生成(i,j);
                }
            }
        }
        //transform.GetChild(0).transform.position = new Vector2(地圖長 * 2, 地圖寬 * 2);
    }

    // Update is called once per frame
    void 生成(int i , int j)
    {
        GameObject 生成物;
        int 生成機率 = Random.Range(0, 3);
        if (生成機率 == 0)
        {
            生成物 = 障礙物預製體[Random.Range(0, 障礙物預製體.Count - 1)];
        }
        else
        {
            生成物 = 獵物預製體[Random.Range(0, 獵物預製體.Count - 1)];
        }
        var 新物件 = Instantiate(生成物, transform.position, Quaternion.identity);
        新物件.transform.position = new Vector2(i * 障礙物距離 + Random.Range(-4f, 4f) - 地圖長 / 2, j * 障礙物距離 + Random.Range(-4f, 4f) - 地圖寬 / 2);
        新物件.transform.parent = transform.GetChild(0);
        if (新物件.TryGetComponent(out AntMovement antMovement))
        {
            antMovement.初始化(新物件.transform.position);
        }
    }
}
