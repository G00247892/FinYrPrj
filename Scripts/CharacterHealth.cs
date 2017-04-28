using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour {
    public float CurrentHealth { get; set;}
    public float MaxHealth { get; set;}

    public Slider healthbar;

    // Use this for initialization
    void Start () {
        MaxHealth = 20f;
        //Reset health to full on game load/reload
        CurrentHealth = MaxHealth;

        healthbar.value = CalcHealth();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
            DealDamage(6);
	}

    void DealDamage(float damageValue)
    {
        //Test function, damage player's health
        CurrentHealth -= damageValue;
        healthbar.value = CalcHealth();
        //If player runs out of health kill player
        if (CurrentHealth <= 0)
            Die();
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        healthbar.value = CalcHealth();
        if (CurrentHealth <= 0)
            Die();
    }

    float CalcHealth()
    {
        return CurrentHealth / MaxHealth;
    }

    void Die() {
        CurrentHealth = 0;
        Debug.Log("You Died");
        Destroy(gameObject);
    }

}
