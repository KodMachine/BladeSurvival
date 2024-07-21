using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    
    public Slider healthSlider;

    public float currentHealth, maxHealth;
    
    // Before start 
    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;

        healthSlider.maxValue = maxHealth;
        healthSlider.minValue = 0;
        healthSlider.value    = currentHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float recievedDamage) 
    {
       currentHealth = currentHealth - recievedDamage;

       if (currentHealth <= 0) 
       {
            gameObject.SetActive(false);
       }

       healthSlider.value = currentHealth;
    }
}
