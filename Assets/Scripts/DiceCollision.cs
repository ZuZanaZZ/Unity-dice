using System.Collections;
using UnityEngine;

public class DiceCollision : MonoBehaviour
{
    public Rigidbody Dice;
    private bool isChecking = false;
    void OnCollisionEnter()
    {
        // if collision is already being checked, don't check again
        if (isChecking) return;
        isChecking = true;

        // on collision wait till the dice is settled
        StartCoroutine(StopRolling());
    }

    private IEnumerator StopRolling()
    {
        // wait until the dice has stopped rolling
        // waituntil from: https://stackoverflow.com/questions/30056471/how-to-make-the-script-wait-sleep-in-a-simple-way-in-unity
        yield return new WaitUntil(() => Dice.linearVelocity == Vector3.zero) ;

        // get the top face of the dice
        int resultNumber = GetNumber();
        Debug.Log(resultNumber);
        isChecking = false;
    }

    public int GetNumber()
    {
        // raycast explanation: https://www.youtube.com/watch?v=cUf7FnNqv7U
        Vector3 dicePosition = transform.position;
        float distance = 2f;
        RaycastHit hitInfo;
        Vector3[] faceNumbers =
        {
            transform.TransformDirection(Vector3.down),    // 6
            transform.TransformDirection(Vector3.forward), // 5
            transform.TransformDirection(Vector3.right),   // 4
            transform.TransformDirection(Vector3.left),    // 3
            transform.TransformDirection(Vector3.back),    // 2
            transform.TransformDirection(Vector3.up)       // 1
        };
        
        int[] topFaces = { 1, 2, 3, 4, 5, 6 };

        // cast ray in all face directions
        for (int i = 0; i < faceNumbers.Length; i++)
        {
            // if the ray hits the ground
            if (Physics.Raycast(dicePosition, faceNumbers[i], out hitInfo, distance))
            {
                // return the number on the (opposite) top face
                return topFaces[i];
            }
        }

        // no ray hit the ground plane
        return -1; 
    }
}
