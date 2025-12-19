using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class DiceRoll : MonoBehaviour
{
    public Rigidbody Dice;
    private bool canRoll = true;
    public bool rolling = false;

    public void Roll(InputAction.CallbackContext context)
    {
        if (!canRoll) return;

        // if the dice is ready to roll aplly forces
        canRoll = false;
        rolling = true;

        // add a random force and spin to the dice for realistic rolling
        // new input system tutorial: https://www.youtube.com/watch?v=qEtLamo_-_g
        float xForce = Random.Range(-300, 300);
        float yForce = Random.Range(2000 , 3000);
        float zForce = Random.Range(-300, 300);
        Dice.AddForce(xForce, yForce, zForce);

        float Rotation = Random.Range(-300, 300);
        Dice.AddTorque(Rotation, Rotation, Rotation);

        StartCoroutine(RollingDelay());
    }

    private IEnumerator RollingDelay()
    {
        // wait to prevent spamming of roll
        yield return new WaitForSecondsRealtime(0.5f);

        // reset flag
        canRoll = true;
    }

    void OnCollisionEnter()
    {
        rolling = false;
    }
}
