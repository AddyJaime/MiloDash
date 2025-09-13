using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("oh shit you hit me homebody");
    }

  void OnTriggerEnter2D(Collider2D collision)
  {
        Debug.Log(" shit was that a car that just passed by, jesus");
  }
}
