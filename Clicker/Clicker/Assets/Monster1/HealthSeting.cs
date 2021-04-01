using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSeting : MonoBehaviour
{
  public int maxHealth = 100;
  public int health = 100;  
  public int gold = 90;
  GameHelper _gameHelper;
   GameHelper _healthBar;
   void Start() {
       
       
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();

        _gameHelper.healthBar.maxValue = maxHealth;
        _gameHelper.healthBar.value = maxHealth;
   }
 //Пролучение урона
  public void GetHit(int damage){
        
        int _health = health - damage;
        
        if (_health <= 0){
             //Выпадение голды
             _gameHelper.TakeGold(gold);
             Destroy(gameObject);
           
        }

            health = _health;
          _gameHelper.healthBar.value = health;

    }

 
  
}
