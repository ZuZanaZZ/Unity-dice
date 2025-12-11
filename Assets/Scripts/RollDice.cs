using UnityEngine;


public class RollDice : MonoBehaviour
{

    public Rigidbody Dice;
    private static float RandomForce()
    {
        // source of random: https://stackoverflow.com/questions/69115335/cannot-create-an-instance-of-the-static-class-random
        return Random.Range(100, 200);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add a random force to the dice for realistic rolling
        Dice.AddForce(RandomForce(), RandomForce(), RandomForce());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
