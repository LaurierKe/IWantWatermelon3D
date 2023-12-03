using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLookat : MonoBehaviour
{
    [SerializeField] Transform box;
    void Update()
    {
        transform.LookAt(box.transform);
    }
}
