using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{

    public DiceCollision diceCollision;
    public DiceRoll diceRoll;
    public Vector3 offset;
    public Transform diceTransform;
    public TextMeshProUGUI uiText;
    [SerializeField] private Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    void LateUpdate()
    {
        transform.position = diceTransform.position + offset;

        // when the dice is rolling or the result being checked, display rolling...
        if (diceRoll.rolling || diceCollision.isChecking)
        {
            uiText.text = $"Rolling...";
        }
        // before starting the game, display the instructions
        else if (diceCollision.resultNumber == -1)
        {
            uiText.text = $"Press space or click to roll! Press x for reset.";
        }
        // display the result of the roll
        else
        {
            uiText.text = $"You rolled {diceCollision.resultNumber}!";
        }
    }
}
