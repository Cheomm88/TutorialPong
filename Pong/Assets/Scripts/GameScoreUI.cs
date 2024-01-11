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
    
    [Header("Animacion Texto Gol")]
    [SerializeField]
    float textPosition = 1300f;
    [SerializeField]
    GameObject textLabelGoal;
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
        AnimateGoalText(1, animationTime);
    }
    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
        //Animar texto de gol.
        AnimateGoalText(2, animationTime);
    }

    void AnimateGoalText(int player, float animationDuration)
    {
        float textInitialPosition = 0f;
        if (player == 1)
        {
            textInitialPosition = textPosition;
        }
        else
        {
            textInitialPosition = -textPosition;
        }

        LeanTween.moveLocalX(textLabelGoal, textInitialPosition, 0.0f);
        LeanTween.moveLocalX(textLabelGoal, 0.0f, 0.12f);

    }
    //mosrtar
    void UpdateScoreText()
    {
        LeanTween.scale(scoreText.gameObject, Vector3.zero, 0.0f);
        LeanTween.scale(scoreText.gameObject, Vector3.one, animationTime).setEase(animationCurve);
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

}
