using UnityEngine;
using UnityEngine.InputSystem;

public class DiceResetPosition : MonoBehaviour
{
    public Rigidbody dice;
    public Vector3 startPosition;
    private Quaternion startRotation =  Quaternion.identity;
    public Vector3 velocity;
    public void ResetPosition(InputAction.CallbackContext context)
    {
        dice.linearVelocity = Vector3.zero;
        dice.angularVelocity = Vector3.zero;
        
        dice.position = startPosition;
        dice.rotation = startRotation;
    }
}
