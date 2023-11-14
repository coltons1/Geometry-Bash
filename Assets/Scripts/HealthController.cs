using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] Health health;
    private float currentHealth;
    [SerializeField] Slider healthbar;

    private void Start()
    {
        currentHealth = health.maxHealth;
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0f, health.maxHealth);
        healthbar.value = currentHealth;
    }

    public void healDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, health.maxHealth);
        healthbar.value = currentHealth;
    }

    public float getCurrentHealth()
    {
        return currentHealth;
    }

    public void isHealthZero(){
        if(currentHealth == 0)
        {
            Debug.Log("game over pal");
            Die();
        }
    }

    public void Die(){
        Destroy(gameObject);
    }
}
