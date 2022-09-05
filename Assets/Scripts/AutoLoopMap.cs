using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLoopMap : MonoBehaviour
{
    Transform player;
    SpriteRenderer map;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.parent;
        map = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        map_move();
    }

    void map_move()
    {
        float move_x = transform.position.x - player.position.x;
        float move_y = transform.position.y - player.position.y;

        print("x" + move_x + ",y" + move_y);

        if (move_x > map.size.x * 2 * transform.localScale.x)
        {
            transform.position = new Vector2(transform.position.x - map.size.x * 3 * transform.localScale.x, transform.position.y);
        }
        if (move_x < -map.size.x * 2 * transform.localScale.x)
        {
            transform.position = new Vector2(transform.position.x + map.size.x * 3 * transform.localScale.x, transform.position.y);
        }
        if (move_y > map.size.y * 2 * transform.localScale.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - map.size.y * 3 * transform.localScale.y);
        }
        if (move_y < -map.size.y * 2 * transform.localScale.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + map.size.y * 3 * transform.localScale.y);
        }
    }
}
