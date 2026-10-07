using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI text;
    public InputActionReference e;
    public InputActionReference d;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //make text says the game started (completely useless)
        text.text = "Game Started";
        //set the score to 0
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if score >= 0 have text say the score
        if (score >= 0)
        {
            text.text = "Score: " + score;
        }

        // or if score < 0 have text say game over
        else if (score < 0)
        {
            text.text = "Game Over";
        }

        // if e is pressed add 1 to score
        if (e.action.WasPressedThisFrame())
        {
            score++;
        }

        // or if d is pressed subtract 1 from score
        else if (d.action.WasPressedThisFrame())
        {
            score--;
        }

        // if score >= 10 change text color to khaki
        if (score >= 10)
        {
            text.color = Color.khaki;
        }

        // otherwise change text color to turquoise
        else
        {
            text.color = Color.turquoise;
        }
    }
}
