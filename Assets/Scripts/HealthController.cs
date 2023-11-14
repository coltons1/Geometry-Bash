using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Health health;
    private float currentHealth;
    public Slider healthbar;

    private void Start()
    {
        currentHealth = health.maxHP;
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0f, health.maxHP);
        //healthbar.value = currentHealth;
        Debug.Log(currentHealth);
    }

    public void healDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, health.maxHP);
        healthbar.value = currentHealth;
    }

    public float getCurrentHealth()
    {
        return currentHealth;
    }

}
