using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    [Header("Bounding Box")]
    [SerializeField] private Collider colliderBoundingBox;

    [Header("Testing")]
    [SerializeField] private GameObject sphere;
    private Camera mainCam;
    

    private void Awake()
    {
        mainCam = Camera.main;   
    }

    private void Update()
    {
        Vector3  mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 2.07f;
        sphere.transform.position = mousePos;
        if (colliderBoundingBox.bounds.Contains(mousePos))
        {
            Debug.Log("Clicked inside the box: " + mousePos);
        }
        
    }
}
