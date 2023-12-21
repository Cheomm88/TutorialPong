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
    }
    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
    }

    //mosrtar
    void UpdateScoreText()
    {
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

}
