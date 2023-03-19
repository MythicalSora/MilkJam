using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearBehaviour : MonoBehaviour
{
    public GameObject[] snapPoints;
    private float _snapDistance = 1.0f;
    public GameObject selectedObject;
    Vector3 _offset;
    public int puzzleCounter = 0;
        void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                _offset = selectedObject.transform.position - mousePosition;
            }
        }
        if (selectedObject && selectedObject.CompareTag("Gear"))
        {
            selectedObject.transform.position = mousePosition + _offset;
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            for(int i=0; i < snapPoints.Length; i++)
            {
                if (Vector2.Distance(snapPoints[i].transform.position, selectedObject.transform.position) < _snapDistance)
                {
                    selectedObject.transform.position = new Vector2(snapPoints[i].transform.position.x,
                        snapPoints[i].transform.position.y);
                }
            }
            selectedObject = null;
        }
    }
}
