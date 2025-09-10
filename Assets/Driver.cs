using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
// velocidad de movimiento
    [SerializeField] float moveSpeed = .03f;  
    [SerializeField] float steerSpeed = .5f;
    void Update()
    {
        float move = 0f;
        float steer = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }

           if (Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }

        else if (Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }



        transform.Translate(0, move * moveSpeed, 0);
        transform.Rotate(0, 0, steer * steerSpeed);
       }
}
