using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text playerGoldUI;
    public int playerGold;
    public GameObject goldPrefab;

    public void TakeGold (int gold);
    {
        playerGold += gold;
    }

    
    void Update()
    {
        playerGoldUI.text = playerGold.ToString();
    }

   
        
}
