using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
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

 
        float moveAmount = move * moveSpeed * Time.deltaTime;

        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0,steerAmount);
       }
}
