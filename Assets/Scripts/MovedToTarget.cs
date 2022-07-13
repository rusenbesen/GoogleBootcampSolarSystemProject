using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedToTarget : MonoBehaviour
{
    [SerializeField] Transform[] _targetObject;
    [SerializeField] float _speedCoef;
    Rigidbody rigidBody;
    Vector3 _distanceToTarget;
    int randomTargetObjectIndex;

    private void Awake() 
    {
      rigidBody = GetComponent<Rigidbody>();  
      randomTargetObjectIndex = Random.Range(0, 4);   
    }

    void Update()
    {
        OnMoveTarget();       
    }

    private void OnMoveTarget() 
    {
       _distanceToTarget = _targetObject[randomTargetObjectIndex].position - transform.position;
        _distanceToTarget.Normalize();
        rigidBody.AddForce(_distanceToTarget * _speedCoef);
    }
}
