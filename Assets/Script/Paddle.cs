using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    public float speed;
    public float maxX;
    public GameManeger gm;
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
       float x=  Input.GetAxis("Horizontal");
        /*        if (x > 0)
                {
                    MoveRight();
                }
                if (x < 0)
                {
                    MoveLeft();
                }
                if (x == 0)
                {
                    NotMove();
                }*/

        transform.position += new Vector3(x * speed * Time.deltaTime, 0f, 0f);


        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
       
    }

/*    void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);               
    }
    void MoveLeft()
    {
        rb.velocity = new Vector2 (-speed, 0);
    }
    void NotMove()
    {
        rb.velocity= Vector2.zero;
    }*/
    
}
