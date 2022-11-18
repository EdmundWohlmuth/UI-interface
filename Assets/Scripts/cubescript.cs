using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    public float speed = 5;
    int health = 5; //TEMP

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
