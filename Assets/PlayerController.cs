using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public GameObject slider;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("GameManager/UIManager/Canvas_Gameplay/HealthBar");
        healthBar = slider.GetComponent<HealthBar>();

        currentHealth = maxHealth;

        healthBar.SetMaxValue(maxHealth);
        healthBar.SetCurrentValue(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(2);
            healthBar.SetCurrentValue(currentHealth);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHealth(2);
            healthBar.SetCurrentValue(currentHealth);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    void AddHealth(int healing)
    {
        currentHealth += healing;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
