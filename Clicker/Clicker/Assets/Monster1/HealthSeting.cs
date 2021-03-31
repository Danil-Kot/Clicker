using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSeting : MonoBehaviour
{
  public int maxHealth = 100;
  public int health = 100;  
  public int gold = 90;
  public  HealthBarcontroller healhBar;
    GameHelper _gameHelper;
   void Start() {
   healhBar.SetMaxHealth(maxHealth);
    _gameHelper = GameObject.FindObjectOfType<GameHelper>();
   }
 //Пролучение урона
  public void GetHit(int damage){
        
        int _health = health - damage;
        
        if (_health <= 0){
             //Выпадение голды
             _gameHelper.playerGold += gold;
             Destroy(gameObject);
        }

            health = _health;
            healhBar.SetHealth(health);

    }

 
  
}
