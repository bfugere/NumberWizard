using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI count;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    int guessCount;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (max != guess)
        {
            min = guess + 1;
            NextGuess();
        }
    }

    public void OnPressLower()
    {
        if (min != guess)
        {
            max = guess - 1;
            NextGuess();
        }
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

        guessCount++;
        count.text = guessCount.ToString();
    }
}
