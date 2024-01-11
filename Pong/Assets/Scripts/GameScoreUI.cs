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
    float endAnimationPosition;
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
        AnimateGoalText(1);
    }
    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
        //Animar texto de gol.
        AnimateGoalText(2);
    }

    void AnimateGoalText(int player)
    {
        float textInitialPosition = 0f;
        if (player == 1)
        {
            textInitialPosition = -textPosition;           
        }
        else
        {
            textInitialPosition = textPosition;
        }

        endAnimationPosition -= textInitialPosition;

        //Colocar en el lado del que ha marcado
        LeanTween.moveLocalX(textLabelGoal, textInitialPosition, 0.0f);
        //Colocarlo en el centro.
        LeanTween.moveLocalX(textLabelGoal, 0.0f, 0.15f).setOnComplete(EndAnimation);

    }

    void EndAnimation()
    {
        //Hacemos una "pausa"
        LeanTween.scale(textLabelGoal, Vector3.one, 0.3f).setOnComplete(()=> {
            //Escalamos a más grande
            LeanTween.scale(textLabelGoal, Vector3.one * 1.5f, 0.75f).setEaseInBounce().setOnComplete(() =>
            {
                //Se marcha
                LeanTween.moveLocalX(textLabelGoal, endAnimationPosition, 0.75f).setEaseInCirc();
                LeanTween.scale(textLabelGoal, Vector3.one, 0f);
            });
        });

    }
    //mosrtar
    void UpdateScoreText()
    {
        LeanTween.scale(scoreText.gameObject, Vector3.zero, 0.0f);
        LeanTween.scale(scoreText.gameObject, Vector3.one, animationTime).setEase(animationCurve);
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

}
