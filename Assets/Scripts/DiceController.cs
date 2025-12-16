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
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo1, 2f))
        {
            Debug.Log("1");
        }
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * 2f, Color.orange);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out RaycastHit hitInfo2, 2f))
        {
            Debug.Log("2");
        }
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 2f, Color.yellow);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out RaycastHit hitInfo3, 2f))
        {
            Debug.Log("3");
        }
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 2f, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out RaycastHit hitInfo4, 2f))
        {
            Debug.Log("4");
        }
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2f, Color.blue);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo5, 2f))
        {
            Debug.Log("5");
        }
        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 2f, Color.violet);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hitInfo6, 2f))
        {
            Debug.Log("6"); 
        }
    }
}
