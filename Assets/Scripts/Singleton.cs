using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    static Singleton Instance;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {          
            DontDestroyOnLoad(this);
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
