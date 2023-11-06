using UnityEngine;

public class ModelRotation : MonoBehaviour
{
    private Vector2 touchStart;
    private Vector2 touchDelta;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStart = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                touchDelta = touch.position - touchStart;
                touchStart = touch.position;

                // Rotate the model based on touch movement
                transform.Rotate(Vector3.up, -touchDelta.x * 0.5f, Space.World);
            }
        }
    }
}
