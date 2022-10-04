using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
            
        if (transform.position.x > 10 || transform.position.x < -10)
        {
            speed = speed * -1;
        }

    }
}
