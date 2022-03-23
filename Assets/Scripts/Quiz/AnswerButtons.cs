using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackOpen;
    public GameObject answerAbackGreen;
    public GameObject answerAbackRed;

    public GameObject answerBbackOpen;
    public GameObject answerBbackGreen;
    public GameObject answerBbackRed;

    public GameObject answerCbackOpen;
    public GameObject answerCbackGreen;
    public GameObject answerCbackRed;

    public GameObject answerDbackOpen;
    public GameObject answerDbackGreen;
    public GameObject answerDbackRed;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "Score: " + scoreValue;
    }


    public void AnswerA()
    {
        if (QuestionGenorate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackOpen.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackOpen.SetActive(false);
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenorate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackOpen.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackOpen.SetActive(false);
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenorate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackOpen.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackOpen.SetActive(false);
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenorate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackOpen.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackOpen.SetActive(false);
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        }
        yield return new WaitForSeconds(1);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackOpen.SetActive(false);
        answerBbackOpen.SetActive(false);
        answerCbackOpen.SetActive(false);
        answerDbackOpen.SetActive(false);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        QuestionGenorate.displayingQuestion = false;

    }
}
