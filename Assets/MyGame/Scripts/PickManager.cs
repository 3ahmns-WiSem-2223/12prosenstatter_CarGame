using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickManager : MonoBehaviour
{

    public bool collected = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PickUp")
        {
            if(collected == false)
            {
                collected = true;
                Debug.Log(collected);
                Destroy(other.gameObject);
            }

        }

        
    }


}
