using UnityEngine;

public class DraggableHandle : MonoBehaviour
{
    public GameObject lowerLimitHandle;
    public GameObject upperLimitHandle;
    public float minX = -280f;
    public float maxX = 280f;

    private float zCoordinate;
    private Vector3 offset;

    void OnMouseDown()
    {
        zCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoordinate;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = GetMouseWorldPos() + offset;
        newPosition.y = transform.position.y; // Keep y position constant

        // Clamping logic
        float leftBound = lowerLimitHandle ? lowerLimitHandle.transform.position.x : minX;
        float rightBound = upperLimitHandle ? upperLimitHandle.transform.position.x : maxX;

        newPosition.x = Mathf.Clamp(newPosition.x, leftBound, rightBound);
        transform.position = newPosition;
    }
}
