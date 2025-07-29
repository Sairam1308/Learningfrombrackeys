using UnityEngine;

public class MoveWithSwipe : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float turnSpeed = 10011f;

    private Vector2 touchStartPos;
    private bool isSwiping = false;

    void Update()
    {
        // Always move forward
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Handle swipe for left/right turn
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStartPos = touch.position;
                    isSwiping = true;
                    break;

                case TouchPhase.Ended:
                    if (isSwiping)
                    {
                        Vector2 touchEndPos = touch.position;
                        float deltaX = touchEndPos.x - touchStartPos.x;

                        if (Mathf.Abs(deltaX) > 50f) // adjust swipe sensitivity
                        {
                            if (deltaX > 0)
                            {
                                // Swipe Right
                                TurnRight();
                            }
                            else
                            {
                                // Swipe Left
                                TurnLeft();
                            }
                        }

                        isSwiping = false;
                    }
                    break;
            }
        }
    }

    void TurnLeft()
    {
        transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }
}
