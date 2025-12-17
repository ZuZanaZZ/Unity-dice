using UnityEngine;

public class DiceCollision : MonoBehaviour
{
    public Rigidbody Dice;
    void Update()
    {
        // if dice is no longer rolling, get number on the face
        if (Dice.linearVelocity == Vector3.zero){
            int resultNumber = GetNumber();
            Debug.Log(resultNumber);
        }
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
                // Debug.DrawRay(dicePosition, directions[i] * distance, Color.red, 0.5f);
                // return the number on the (opposite) top face
                return topFaces[i];
            }
        }

        // no ray hit the ground plane
        return -1; 
    }
}
