using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public GameObject waterUI;
    bool isInWater = false;

    // Start is called before the first frame update
    void Start()
    {
        waterUI = GameObject.Find("GameManager/UIManager/Canvas_Gameplay/Water");
        waterUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("sploosh");
        isInWater = true;
        CheckWaterEffect();
    }
    private void OnTriggerExit(Collider other)
    {
        isInWater = false;
        CheckWaterEffect();
    }

    public void CheckWaterEffect()
    {
        if (isInWater == false)
        {
            StartCoroutine(DisableWaterEffect());
        } 
        if (isInWater == true)
        {
            waterUI.SetActive(true);
        }
    }

    IEnumerator DisableWaterEffect()
    {
        yield return new WaitForSeconds(3f);
        waterUI.SetActive(false);
        isInWater = false;
    }
}
