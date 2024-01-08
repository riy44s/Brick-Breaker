
using System.Collections;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameManeger ui;
    
    public Transform explosion;
    public AudioSource audioSource;
   
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ui=GameObject.FindWithTag("Ui").GetComponent<GameManeger>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            audioSource.Play();
            ui.IncrementScore();
            Transform newExplosion =  Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(newExplosion.gameObject, 2.5f);

         
            Destroy(gameObject);
          
           
        }
       
    }

  
}
