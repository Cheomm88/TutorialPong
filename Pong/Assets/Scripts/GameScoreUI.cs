using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScoreUI : MonoBehaviour
{
    //goles del jugador 1
    int goalsPlayerOne;
    //goles del jugador 2
    int goalsPlayerTwo;

    public TextMeshProUGUI scoreText;

    [SerializeField]
    float animationTime = 0.2f;
    [SerializeField]
    LeanTweenType animationCurve;

    //restear goles
    public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScoreText();
    }
    //añadir goles
    //Crear una funcion que aumente los goles de cada jugador
    public void GoalScoredPlayerOne()
    {
        goalsPlayerOne++;
        UpdateScoreText();
        //Animar texto de gol.
    }
    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
        //Animar texto de gol.
    }

    void AnimateGoalText(Vector3 initialPosition, Vector3 endPosition, float animationDuration)
    {


    }
    //mosrtar
    void UpdateScoreText()
    {
        LeanTween.scale(scoreText.gameObject, Vector3.zero, 0.0f);
        LeanTween.scale(scoreText.gameObject, Vector3.one, animationTime).setEase(animationCurve);
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

}
