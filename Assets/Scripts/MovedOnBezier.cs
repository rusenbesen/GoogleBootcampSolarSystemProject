using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedOnBezier : MonoBehaviour
{
    [SerializeField] Transform[] _bezierCurve;
    public float _speedCoef = 1;
    int _runningBezierCurve = 0;
    void Start()
    {
        StartCoroutine(MoveOnBezierRoute());
    }

    IEnumerator MoveOnBezierRoute()
    {
        Vector2 objectPositionToGo = transform.position;
        float t = 0f;
        while(t <= 1)
        {
            t += Time.deltaTime * _speedCoef;
            objectPositionToGo = BezierCurveEditor.GetBezierCurvePointByT(t, _bezierCurve[_runningBezierCurve].GetChild(0).position, _bezierCurve[_runningBezierCurve].GetChild(1).position, _bezierCurve[_runningBezierCurve].GetChild(2).position, _bezierCurve[_runningBezierCurve].GetChild(3).position);
            transform.position = objectPositionToGo;
            yield return new WaitForEndOfFrame();
        }

        _runningBezierCurve++;

        if(_runningBezierCurve >= _bezierCurve.Length)
        {
            _runningBezierCurve = 0;
        }

        StartCoroutine(MoveOnBezierRoute());
        yield break;
    }
}
