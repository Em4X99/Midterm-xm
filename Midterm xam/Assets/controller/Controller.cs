using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            gameObject.transform.Rotate(0, 0, -1 * speed);

         }
        
        if(Input.GetKey(KeyCode.LeftArrow)) 
        { gameObject.transform.Rotate(0, 0, 1 * speed); }
    }
}
