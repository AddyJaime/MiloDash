using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = .5f;
    [SerializeField] float moveSpeed = .03f;  
    void Update()
    {

        if (Keyboard.current.upArrowKey.isPressed)
        {
            Debug.Log("I am going forward");
        }

         else  if (Keyboard.current.leftArrowKey.isPressed)
        {
            Debug.Log("I am pressing the left key");    
        }

           if (Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log("I am pressing the right key right now");
        }

        else if (Keyboard.current.downArrowKey.isPressed)
        {
            Debug.Log("I  am going backwards");
        }



        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
       }
}
