using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUpOnEnter : MonoBehaviour
{    
    public GameObject meteorObject;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(meteorObject); 
        }
    }
}
