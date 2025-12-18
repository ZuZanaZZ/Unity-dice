using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{

    public DiceCollision dice;
    public Vector3 offset;
    public TextMeshProUGUI uiText;

    // Update is called once per frame
    void Update()
    {
        // transform.position = dice.transform.position + offset;
        if (dice.resultNumber == -1)
        {
            uiText.text = $"Press spacebar or click to roll the dice!";
        }
        else
        {
            uiText.text = $"You rolled {dice.resultNumber}!";
        }
    }
}
