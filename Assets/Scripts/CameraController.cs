using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float dragSpeed = 1f;
    private Vector3 dragOrigin;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
       
        Vector3 move = new Vector3(0, pos.x * dragSpeed, 0);

        if(Mathf.Abs(pos.y) > 0) transform.Translate(0, pos.y, 0);

        transform.Rotate(move, Space.World);
        
        
    }
}