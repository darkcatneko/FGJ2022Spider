using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public float 地圖長, 地圖寬;
    public float 障礙物距離 = 10;
    public List<GameObject> 障礙物預製體;
    

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
                print("生成");
                var 新物件 = Instantiate(障礙物預製體[Random.RandomRange(0, 障礙物預製體.Count - 1)], transform.position, Quaternion.identity);
                新物件.transform.position = new Vector2(i * 障礙物距離 + Random.RandomRange(-2f,2f) - 地圖長/2, j * 障礙物距離 + Random.RandomRange(-2f, 2f) - 地圖寬/2);
                新物件.transform.parent = transform.GetChild(0);
            }
        }
        //transform.GetChild(0).transform.position = new Vector2(地圖長 * 2, 地圖寬 * 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
