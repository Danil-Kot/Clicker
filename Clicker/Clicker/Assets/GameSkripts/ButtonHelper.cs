using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    public Text DamageText;
    public Text PriceText;

    public int Damage = 10;
    public int Price = 100;

    GameHelper _gameHelper;
    HealthSeting _hit;
    // Start is called before the first frame update
    void Start()
    {
        _gameHelper = FindObjectOfType<GameHelper>();
        

        DamageText.text = Damage.ToString();
        PriceText.text = Price.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpClick()
    {
        if(_gameHelper.playerGold >= Price)
        {
            _gameHelper.playerGold -= Price;
            _gameHelper.PlayerDamage += Damage;

         //   Destroy(gameObject);

        }
    }
}
