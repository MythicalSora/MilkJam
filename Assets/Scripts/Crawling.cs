using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using Random = UnityEngine.Random;

public class Crawling : MonoBehaviour
{
    public float speed;
    public float turnTime;
    public float turnSpeed;
    
    private float _timeLeft;
    private Vector2 _movementDirection;

    private void Update()
    {
        _timeLeft -= Time.deltaTime;
        if (_timeLeft <= 0)
        {
            _movementDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            _timeLeft += turnTime;
        }

        float inputMagnitute = Mathf.Clamp01(_movementDirection.magnitude);
        _movementDirection.Normalize();
        
        transform.Translate(_movementDirection * (speed * inputMagnitute * Time.deltaTime), Space.World);

        if (_movementDirection != Vector2.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(Vector3.forward, _movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, turnSpeed * Time.deltaTime);
        }
    }
}
