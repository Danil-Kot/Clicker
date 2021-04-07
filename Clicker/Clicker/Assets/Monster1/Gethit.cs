using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gethit : MonoBehaviour
{
     GameHelper  _gameHelper;
    private void Start()
    {
        _gameHelper = FindObjectOfType<GameHelper>();
    }
    void OnMouseDown() {
        GetComponent<Animator>().SetTrigger("Hit");
        GetComponent<HealthSeting>().GetHit(_gameHelper.PlayerDamage);
       
    }
}
