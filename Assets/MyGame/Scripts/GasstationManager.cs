using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasstationManager : MonoBehaviour
{
    [SerializeField] PickManager pm;
    public int counter = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            if (pm.collected == true)
            {
                pm.collected = false;
                counter = counter + 1;
                Debug.Log(counter);
            }
        }


    }


}
