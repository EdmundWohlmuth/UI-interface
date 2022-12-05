using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water : MonoBehaviour
{
    public GameObject waterUI;
    bool isInWater = false;

    Color transparent = new Color(1, 1, 1, 0);
    Color opaque = new Color(1, 1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        waterUI = GameObject.Find("GameManager/UIManager/Canvas_Gameplay/Water");
        waterUI.GetComponent<Image>().color = transparent;
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
            waterUI.GetComponent<Image>().color = opaque;
        }
    }

    IEnumerator DisableWaterEffect()
    {
        yield return new WaitForSeconds(3f);
        LeanTween.alpha(waterUI.GetComponent<RectTransform>(), 0f, 1f);
        isInWater = false;
    }
}
