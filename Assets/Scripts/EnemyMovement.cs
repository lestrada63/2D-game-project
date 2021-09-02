﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    
    public bool MoveLeft;

    // Update is called once per frame
    void Update()
    {
        // if move right bool is true mean he will move to the right
        if (MoveLeft)
        {
            transform.Translate (-2 * Time.deltaTime * speed, 0,0);
            transform.localScale = new Vector2 (1,1);
        }
        else
        {
            transform.Translate (2 * Time.deltaTime * speed, 0,0);
            transform.localScale = new Vector2 (-1,1);
        }
    }

    void OnTriggerEnter2D (Collider2D trig)
    {
        if (trig.gameObject.CompareTag ("Turn"))
        {
            if (MoveLeft)
            {
                MoveLeft = false;
            }
            else
            {
                MoveLeft = true;
            }
        }
    }
}
