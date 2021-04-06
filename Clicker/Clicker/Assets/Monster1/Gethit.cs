using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gethit : MonoBehaviour
{
    void OnMouseDown() {
        GetComponent<Animator>().SetTrigger("Hit");
        GetComponent<HealthSeting>().GetHit(200);
       
    }
}
