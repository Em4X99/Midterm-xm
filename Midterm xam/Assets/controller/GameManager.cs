using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector2 Startpos;
    
    // Start is called before the first frame update
    void Start()
    {
        Startpos = this.gameObject.transform.position;   
    }

    // Update is called once per frame
    void Update()

    { }
     private void OnCollisionEnter2D(Collision2D collision)
        {
            
            
               
                if(collision.transform.tag == "Death 1")
        {
            this.gameObject.transform.position = Startpos;
        }
            
        }

}
