using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTurnSelfScript : MonoBehaviour
{
    [SerializeField] float speedSelf;    
    void Update()
    {
        PlanetTurnSelfRotate();
    }

    //Planet revolves around itself
    void PlanetTurnSelfRotate()
    {
        transform.Rotate(Vector3.up * speedSelf * Time.deltaTime);
    }
}
