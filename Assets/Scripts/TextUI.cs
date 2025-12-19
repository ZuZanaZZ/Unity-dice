using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{

    public DiceCollision diceCollision;
    public DiceRoll diceRoll;
    public Vector3 offset;
    public TextMeshProUGUI uiText;

    void Update()
    {
        // before starting the game, display the instructions
        if (diceCollision.resultNumber == -1)
        {
            uiText.text = $"Press spacebar or click to roll the dice!";
        }
        // when the dice is rolling or the result being checked, display rolling...
        else if (diceRoll.rolling || diceCollision.isChecking)
        {
            uiText.text = $"Rolling...";
        }
        // display the result of the roll
        else
        {
            uiText.text = $"You rolled {diceCollision.resultNumber}!";
        }
    }
}
