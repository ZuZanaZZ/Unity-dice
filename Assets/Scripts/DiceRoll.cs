using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class DiceRoll : MonoBehaviour
{
    public Rigidbody dice;
    private bool canRoll = true;
    public bool rolling = false;

    public void Roll(InputAction.CallbackContext context)
    {
        if (!canRoll) return;

        // if the dice is ready to roll aplly forces for rolling
        canRoll = false;
        rolling = true;

        // new input system tutorial: https://www.youtube.com/watch?v=qEtLamo_-_g
        float xForce = Random.Range(-300, 300);
        float yForce = Random.Range(2000 , 3000);
        float zForce = Random.Range(-300, 300);
        dice.AddForce(xForce, yForce, zForce);

        float Rotation = Random.Range(-300, 300);
        dice.AddTorque(Rotation, Rotation, Rotation);

        // wait to prevent the spamming of roll
        StartCoroutine(RollingDelay());
    }

    private IEnumerator RollingDelay()
    {
        yield return new WaitForSecondsRealtime(0.75f);
        canRoll = true;
    }

    void OnCollisionEnter()
    {
        rolling = false;
    }
}
