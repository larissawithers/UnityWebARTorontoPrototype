using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenorate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 12);
            if (questionNumber == 1)
            {

                QuestionDisplay.newQuestion = "Which movie filmed scenes at the historic castle, Casa Loma? ";
                QuestionDisplay.newA = "Harry Potter and the Deathly Hallows";
                QuestionDisplay.newB = "X - Men";
                QuestionDisplay.newC = "Beauty and the beast";
                QuestionDisplay.newD = "All of the above";
                actualAnswer = "D";

            }
            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "What is the longest street in Toronto?";
                QuestionDisplay.newA = "Yonge street";
                QuestionDisplay.newB = "Spadina Avenue";
                QuestionDisplay.newC = "Queen Street West";
                QuestionDisplay.newD = "Bathhurst Street";
                actualAnswer = "A";
            }
            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Which Baseball player hit his first home run in Toronto?";
                QuestionDisplay.newA = "MikeTrout";
                QuestionDisplay.newB = "Babe Ruth";
                QuestionDisplay.newC = "Barry Bonds";
                QuestionDisplay.newD = "Joey Votto";
                actualAnswer = "B";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Which fast food restaurant was founded in Etobicoke the same year the Toronto Maple Leaf’s won the Stanley Cup?";
                QuestionDisplay.newA = "Burger King";
                QuestionDisplay.newB = "Wendy's";
                QuestionDisplay.newC = "Pzza Pizza";
                QuestionDisplay.newD = "Havey's";
                actualAnswer = "C";
            }

            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "What year did the Toronto Maple Leaf’s win the Stanley Cup?";
                QuestionDisplay.newA = "1998";
                QuestionDisplay.newB = "1983";
                QuestionDisplay.newC = "1967";
                QuestionDisplay.newD = "1976";
                actualAnswer = "C";
            }

            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "How old is the oldest Red Oak Tree in Toronto?";
                QuestionDisplay.newA = "80";
                QuestionDisplay.newB = "100";
                QuestionDisplay.newC = "150";
                QuestionDisplay.newD = "300";
                actualAnswer = "D";
            }

            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "How many major league sports teams are in Toronto?";
                QuestionDisplay.newA = "7";
                QuestionDisplay.newB = "10";
                QuestionDisplay.newC = "4";
                QuestionDisplay.newD = "12";
                actualAnswer = "A";
            }

            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "How many subway stations are in Toronto?";
                QuestionDisplay.newA = "111";
                QuestionDisplay.newB = "75";
                QuestionDisplay.newC = "32";
                QuestionDisplay.newD = "89";
                actualAnswer = "B";
            }

            if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "How long was the CN Tower the tallest free standing structure in the world?";
                QuestionDisplay.newA = "32 years";
                QuestionDisplay.newB = "24 years";
                QuestionDisplay.newC = "38 years";
                QuestionDisplay.newD = "15 years";
                actualAnswer = "A";
            }

            if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "What is the name of Toronto’s Lacrosse team?";
                QuestionDisplay.newA = "The Toronto Hammers ";
                QuestionDisplay.newB = "The Toronto Hogs";
                QuestionDisplay.newC = "The Toronto Rock";
                QuestionDisplay.newD = "The Toronto Ice";
                actualAnswer = "C";
            }

            if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "What year did the Raptors Win the NBA Championship? ";
                QuestionDisplay.newA = "1999";
                QuestionDisplay.newB = "2004";
                QuestionDisplay.newC = "2015";
                QuestionDisplay.newD = "2019";
                actualAnswer = "D";
            }

            if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Downtown Toronto has the worlds largest underground shopping centre with 1200 retail stores and connects 70 building. What is it called?";
                QuestionDisplay.newA = "The Toronto Underground";
                QuestionDisplay.newB = "The Corridor";
                QuestionDisplay.newC = "The Path";
                QuestionDisplay.newD = "MUTS (the Metro Underground Tunnel System)";
                actualAnswer = "C";
            }


            QuestionDisplay.pleaseUpdate = false;
        }

    }
}
