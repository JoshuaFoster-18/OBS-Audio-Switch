using UnityEngine;
using UnityEngine.EventSystems;

public class HandlesController : MonoBehaviour, IDragHandler
{
    public RectTransform Handle1;
    public RectTransform Handle2;
    public RectTransform Handle3;
    
    private float minX = -280f;
    private float maxX = 280f;

    public void OnDrag(PointerEventData eventData)
    {
        if (!RectTransformUtility.ScreenPointToWorldPointInRectangle(transform as RectTransform, eventData.position, eventData.pressEventCamera, out Vector3 globalMousePos))
        {
            return;
        }

        // Set boundaries for each handle
        float leftLimit = minX, rightLimit = maxX;
        if (gameObject == Handle1.gameObject)
        {
            rightLimit = Handle2.anchoredPosition.x;
        }
        else if (gameObject == Handle2.gameObject)
        {
            leftLimit = Handle1.anchoredPosition.x;
            rightLimit = Handle3.anchoredPosition.x;
        }
        else if (gameObject == Handle3.gameObject)
        {
            leftLimit = Handle2.anchoredPosition.x;
        }

        // Calculate new position within limits
        Vector3 newPos = transform.position;
        newPos.x = Mathf.Clamp(globalMousePos.x, leftLimit, rightLimit);
        transform.position = newPos;

        // Optional: Update handle's anchored position based on new position
        Vector2 anchoredPos = (transform as RectTransform).anchoredPosition;
        anchoredPos.x = Mathf.Clamp(anchoredPos.x, leftLimit, rightLimit);
        (transform as RectTransform).anchoredPosition = anchoredPos;
    }
}
