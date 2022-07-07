using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlanetInfoScript : MonoBehaviour
{
    float _rotationAngle;
    public MovedOnBezier _movedOnBezier;
    private int turnCount = 0;
    void Update()
    {
        WritePlanetTurn();
    }

    //One revolution around the sun
    void WritePlanetTurn()
    {                       
        _rotationAngle += _movedOnBezier._speedCoef * Time.deltaTime;         
        if(_rotationAngle >= 2)
        {
            turnCount++;
            Debug.Log($"{gameObject.name} turned a round! Turn count: " + turnCount);           
            _rotationAngle=0;
        }
    }

}
