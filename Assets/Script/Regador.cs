using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Regador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
          if(col.gameObject.tag=="pegada"){
            transform.SetParent(col.transform);
        }
    }
}