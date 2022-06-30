using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTurnSunScript : MonoBehaviour
{
    [SerializeField] GameObject pivotPoint;
    public float turnAroundSpeed;
   
    void Update()
    {
        PlanetTurneAroundSun();
    }
    
    //Planet orbiting the earth
    void PlanetTurneAroundSun()
    {
        transform.RotateAround(pivotPoint.transform.position, Vector3.down, turnAroundSpeed * Time.deltaTime);         
    }
}
