using UnityEngine;
using UnityEngine.InputSystem;


public class DiceController : MonoBehaviour
{
    public Rigidbody Dice;
    public void Roll(InputAction.CallbackContext context)
    {
        // Add a random force and spin to the dice for realistic rolling
        // new input system tutorial: https://www.youtube.com/watch?v=qEtLamo_-_g
        float xForce = Random.Range(-50, 50);
        float yForce = Random.Range(100 , 150);
        float zForce = Random.Range(-50, 50);
        Dice.AddForce(xForce, yForce, zForce);

        float Rotation = Random.Range(-30, 30);
        Dice.AddTorque(Rotation, Rotation, Rotation);
    }

    void Update()
    {
        // Raycast explanation: https://www.youtube.com/watch?v=cUf7FnNqv7U
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 2f))
        {
            Debug.Log("Hit :D");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2f, Color.green);
        }
        else
        {
            Debug.Log("NOOOO Hit D:"); 
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2f, Color.red);
        }
    }
}
