using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSeting : MonoBehaviour
{
  int maxHealth = 100;
    int health = 100;  

    public  HealthBarcontroller healhBar;
   void Start() {
   healhBar.SetMaxHealth(maxHealth);
   }
  public void GetHit(int damage){
        
        int _health = health - damage;
        
        if (_health <= 0){
             Destroy(gameObject);
        }

            health = _health;
            healhBar.SetHealth(health);

    }
}
