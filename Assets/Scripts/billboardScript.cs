using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboardScript : MonoBehaviour
{
    public Transform cam;
    public GameObject uiToHide;
    public bool isDistanceBased;

    private void Start()
    {
        
    }

    void LateUpdate()
    {
        if (isDistanceBased) DistanceCheck();

        transform.LookAt(transform.position + cam.forward);
    }

    void DistanceCheck()
    {
        if (Vector3.Distance(cam.transform.position, transform.position) < 3f) gameObject.SetActive(true);
        //else uiToHide.SetActive(false);
        //Debug.Log(Vector3.Distance(cam.transform.position, transform.position));
    }

}
