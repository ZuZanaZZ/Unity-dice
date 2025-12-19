using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{

    public DiceCollision diceCollision;
    public DiceRoll diceRoll;
    public Vector3 offset;
    public TextMeshProUGUI uiText;

    // Update is called once per frame
    void Update()
    {
        if (diceCollision.resultNumber == -1)
        {
            uiText.text = $"Press spacebar or click to roll the dice!";
        }
        else if (diceCollision.isChecking || diceRoll.rolling)
        {
            uiText.text = $"Rolling...";
        }
        else
        {
            uiText.text = $"You rolled {diceCollision.resultNumber}!";
        }
    }
}
