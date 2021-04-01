using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text playerGoldUI;
    public int playerGold;
    public GameObject goldPrefab;
    public GameObject[] monsterPrefabs;
    public Transform startPosition;
    public Slider healthBar;

    void Start()
    {
        SpawnMonster();
    }

    void Update()
    {
        playerGoldUI.text = playerGold.ToString();
    }  

   public void TakeGold(int gold)
    {
        playerGold += gold;
       GameObject obj =  Instantiate(goldPrefab) as GameObject;
       Destroy(obj,2);
       SpawnMonster();
    }
   
    public  void SpawnMonster()
    {   

        int index = Random.Range(0, monsterPrefabs.Length);
        GameObject monsterObj = Instantiate(monsterPrefabs[index]) as GameObject;
        monsterObj.transform.position = startPosition.position;
      
    }
}
