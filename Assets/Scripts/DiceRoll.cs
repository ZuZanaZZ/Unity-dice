using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class DiceRoll : MonoBehaviour
{
    public Rigidbody Dice;
    private bool inAir = false;
    public void Roll(InputAction.CallbackContext context)
    {
        // if the dice is already in the air, don't roll again
        if (inAir) return;
        
        inAir = true;
        // add a random force and spin to the dice for realistic rolling
        // new input system tutorial: https://www.youtube.com/watch?v=qEtLamo_-_g
        float xForce = Random.Range(-50, 50);
        float yForce = Random.Range(100 , 150);
        float zForce = Random.Range(-50, 50);
        Dice.AddForce(xForce, yForce, zForce);

        float Rotation = Random.Range(-30, 30);
        Dice.AddTorque(Rotation, Rotation, Rotation);

        StartCoroutine(StopFlying());
    }

    private IEnumerator StopFlying()
    {
        // wait until the dice has stopped flying
        yield return new WaitUntil(() => Dice.linearVelocity == Vector3.zero) ;

        // reset flag
        inAir = false;
    }
}
