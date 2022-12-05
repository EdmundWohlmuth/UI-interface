using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AssaultRifle : MonoBehaviour
{
    public Camera playerCam;
    public AudioSource source;
    public AudioClip shootSound;
    public AudioClip shootSound2;
    public AudioClip noAmmo;
    
    public float range;

    public int ammo;
    public int ammoCount = 10;
    private int health = 50;

    public TextMeshProUGUI ammoText;
    public TextMeshProUGUI healthText;

    public FirstPersonController_Sam fpsControl;

    GameObject gameManager;
    GameManager GM;

    // Start is called before the first frame update
    void Start()
    {      
        setAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        if (fpsControl.canMove) ShootCheck();
    }

    void ShootCheck()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammoCount > 0)
        {
            // Debug.Log("shoot");
            ammoCount--;
            setAmmoText();
            Fire();

            int randomNum = Random.Range(1, 3);
            if (randomNum == 1)
            {
                source.PlayOneShot(shootSound);
            }
            else source.PlayOneShot(shootSound2);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && ammo <= 0)
        {
            // Debug.Log("click");
            source.PlayOneShot(noAmmo);
        }
    }

    void Fire()
    {
        //Debug.Log("Bang!");

        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
            GameObject Sphere;           
            Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            Sphere.transform.position = hit.point;
            Sphere.transform.parent = hit.transform;
            Sphere.tag = ("Gloo");

            if (hit.transform.tag == "Enemy")
            {
                if (hit.transform.gameObject.GetComponent<cubescript>().speed > 0)
                {
                    hit.transform.gameObject.GetComponent<cubescript>().speed--;
                    hit.transform.gameObject.GetComponent<cubescript>().health--;
                }               
            }
            if (hit.transform.tag == "Enemy" || hit.transform.tag == "Gloo")
            {
                Sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                Sphere.transform.LeanScale(new Vector3(1, 1, 1), 0.25f);
            }
        }
    }

    // ------------------------- Pickups ------------------------------------------
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AmmoPickup"))
        {
            //Debug.Log("Picked up ammo");
            ammoCount = ammoCount + 10;

            if (ammoCount >= 50) ammoCount = 50;
            else if (ammoCount <= 0) ammoCount = 0;
            setAmmoText();
        }

        if (other.gameObject.CompareTag("HealthPickup"))
        {
            //Debug.Log("Picked up health");
            health = health + 25;

            if (health >= 150) health = 150;
            else if (health <= 0) health = 0;
        }
    }

    public void incrimentAmmo()
    {
        Debug.Log("Picked up ammo");
        ammoCount = ammoCount + 10;

        if (ammoCount >= 50) ammoCount = 50;
        else if (ammoCount <= 0) ammoCount = 0;
        setAmmoText();
    }

    // ------------------------- set UI --------------------------------------
    void setAmmoText()
    {
        ammoText.text = ammoCount.ToString();
    }
}
