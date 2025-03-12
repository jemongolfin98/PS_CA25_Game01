using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject letter;
    public GameObject center;
    public GameObject startGamePanel;
    public GameObject gamePanel;

    private string wordToGuess = "";
    private int lengthOfWordToGuess;
 
    char [] lettersToGuess;
    bool [] lettersGuessed;

    private string [] wordsToGuess = new string [] {"resume", "handshake","linkedin", "internship", "job shadowing", "business attire" };
    
    // Start is called before the first frame update
    public void Start()
    {
        center = GameObject.Find ("CenterOfScreen");
        //InitGame();
        //InitLetters();
    }

    // Update is called once per frame
    public void Update()
    {
        //CheckKeyboard ();
        CheckKeyboard2 ();

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void InitGame()
 
    {
        int randomNumber = Random.Range (0, wordsToGuess.Length - 1);
        wordToGuess = wordsToGuess [randomNumber];

        lengthOfWordToGuess = wordToGuess.Length;
        wordToGuess = wordToGuess.ToUpper ();
        lettersToGuess = new char[lengthOfWordToGuess];
        lettersGuessed = new bool [lengthOfWordToGuess];   
        lettersToGuess = wordToGuess.ToCharArray ();
    }
    
    public void InitLetters()
    {
        int nbletters = lengthOfWordToGuess;
    
        for (int i = 0; i < nbletters; i++) 
        {
            Vector3 newPosition;
            newPosition = new Vector3 (center.transform.position.x + ((i-nbletters/2.5f) *50), center.transform.position.y, center.transform.position.z);
            GameObject l = (GameObject)Instantiate (letter, newPosition, Quaternion.identity);
    
            l.name = "letter" + (i + 1);
            l.transform.SetParent(GameObject.Find ("Canvas").transform);
        } 
    }

    public void CheckKeyboard()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i=0; i < lengthOfWordToGuess; i++)
            {
                if (!lettersGuessed [i])
                {
                    if (lettersToGuess [i] == 'A')
                    {
                        lettersGuessed [i] = true;
                        GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = "A";
                    }
                }
            }
        }
    }

    public void CheckKeyboard2()
    {
        if (Input.anyKeyDown)
        {
            char letterPressed = Input.inputString.ToCharArray () [0];
            int letterPressedAsInt = System.Convert.ToInt32 (letterPressed);
 
            if (letterPressedAsInt >= 97 && letterPressed <= 122)
            {
                for (int i=0; i < lengthOfWordToGuess; i++)
                {
                    if (!lettersGuessed [i])
                    {
                        letterPressed = System.Char.ToUpper (letterPressed);
 
                        if (lettersToGuess [i] == letterPressed)
                        {
                            lettersGuessed [i] = true;
                            GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                        }
                    }
                }
            }
        }
    }

    public void StartGame()
    {
        startGamePanel.SetActive(false);
        gamePanel.SetActive(true);

        InitGame();
        InitLetters();
    }
}
