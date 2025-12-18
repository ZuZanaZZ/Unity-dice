using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class DiceRoll : MonoBehaviour
{
    public Rigidbody Dice;
    private bool canRoll = true;
    public void Roll(InputAction.CallbackContext context)
    {
        // if the dice is already in the air, don't roll again
        if (!canRoll) return;
        canRoll = false;
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
        // wait to prevent the dice flying of screen
        yield return new WaitForSecondsRealtime(0.3f);

        // reset flag
        canRoll = true;
    }
}
