using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class DiceController : MonoBehaviour
{
    public Rigidbody Dice;
    public void Roll(InputAction.CallbackContext context)
    {
        // add a random force and spin to the dice for realistic rolling
        // new input system tutorial: https://www.youtube.com/watch?v=qEtLamo_-_g
        float xForce = Random.Range(-50, 50);
        float yForce = Random.Range(100 , 150);
        float zForce = Random.Range(-50, 50);
        Dice.AddForce(xForce, yForce, zForce);

        float Rotation = Random.Range(-30, 30);
        Dice.AddTorque(Rotation, Rotation, Rotation);
    }
}
