using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed=100f;
    bool isStarted = false;
    public Transform Paddle;
    public GameManeger gm;
   
    void Start()
    {
      
        rb=GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        if (!isStarted)
        {
            transform.position = Paddle.position;
        }
        if (Input.GetKeyUp(KeyCode.Space)&& isStarted==false)
        {
            transform.parent = null;
            /*transform.SetParent(null);*/
            rb.isKinematic = false;
            rb.AddForce(new Vector2(speed,speed));
            isStarted = true;
          
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottom"))
        {
            Debug.Log("Trigger");
            rb.velocity=Vector2.zero;
            isStarted = false;
            gm.UpdateLives(-1);
        }
    }
}
