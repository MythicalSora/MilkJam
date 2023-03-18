using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private LampBehaviour lamp;
    [SerializeField] private char direction;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int increment = direction switch
            {
                'l' => -1,
                'r' => 1,
                _ => 0
            };

            var transform1 = lamp.transform;
            var position = transform1.position;
            position = new Vector3(position.x + increment, position.y, position.z);
            transform1.position = position;
        }
    }
}
