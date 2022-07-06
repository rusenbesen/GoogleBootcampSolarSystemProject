using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlanetInfoScript : MonoBehaviour
{
    float _rotationAngle;
    public PlanetTurnSunScript _planetTurnSelfScript;
    private int turnCount = 0;
    void Update()
    {
        WritePlanetTurn();
    }

    //One revolution around the sun
    void WritePlanetTurn()
    {                       
        _rotationAngle += _planetTurnSelfScript.turnAroundSpeed  * Time.deltaTime;
        
        if(_rotationAngle >= 360)
        {
             turnCount++;
            Debug.Log($"{gameObject.name} turned a round! Turn count: " + turnCount);           
            _rotationAngle=0;
        }
    }

}
