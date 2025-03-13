using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject letter;
    public GameObject center;
    public GameObject hintButton;
    public GameObject pausedButton;
    public GameObject startGamePanel;
    public GameObject nextWordButton;
    public GameObject gamePanel;
    public GameObject hintPanel;
    public GameObject successPanel;
    public GameObject failPanel;
    public GameObject pausedPanel;


    public TMP_Text letterGuessed01;
    public TMP_Text letterGuessed02;
    public TMP_Text letterGuessed03;
    public TMP_Text guessesLeftText;
    public TMP_Text hintText;


    private string wordToGuess = "";
    private int lengthOfWordToGuess;
 
    public char [] lettersToGuess;
    public bool [] lettersGuessed;

    private string [] wordsToGuess = new string [] {"resume", "handshake","linkedin", "internship", "job shadowing", "business attire", "networking", "technical skills", "soft skills", "cover letter" };

    int randomNumber;
    int guessesLeft;
    int wordCounter = 0;


    bool word0Completed = false;
    bool word1Completed = false;
    bool word2Completed = false;
    bool word3Completed = false;
    bool word4Completed = false;
    bool word5Completed = false;
    bool word6Completed = false;
    bool word7Completed = false;
    bool word8Completed = false;
    bool word9Completed = false;


    // Start is called before the first frame update
    public void Start()
    {
        center = GameObject.Find ("CenterOfScreen");
        startGamePanel.SetActive(true);

        guessesLeft = 3;

        letterGuessed01.text = "";
        //letterGuessed02.text = "";
        //letterGuessed03.text = "";

        //InitGame();
        //InitLetters();
    }

    // Update is called once per frame
    public void Update()
    {
        //CheckKeyboard2 ();
        
        if (guessesLeft == 0)
        {
            hintButton.SetActive(false);
            failPanel.SetActive(true);
        }
        else if (guessesLeft == 1)
        {
            hintButton.SetActive(true);
        }
        else
        {
            hintButton.SetActive(false);
        }

        switch (randomNumber)
        {
            case 0:
                // "Resume"
                hintText.text = "Summarized document of professional career, usually 1-page.";
                break;
            case 1:
                // "Handshake"
                hintText.text = "Job search and career prep website promoted by many universities.";
                break;
            case 2:
                // "LinkedIn"
                hintText.text = "Social Media platform for Professionals.";
                break;
            case 3:
                // "Internship"
                hintText.text = "Opportunity to work and learn for a company during a preset amount of time, usually for pay.";
                break;
            case 4:
                // "Job Shadowing"
                hintText.text = "Opportunity to watch/observe professionals in their actual work space.";
                break;
            case 5:
                // "Business Attire"
                hintText.text = "Usually worn at professional/networking events and/or interviews.";
                break;
            case 6:
                // "Networking"
                hintText.text = "To build relationships with professionals within your career field.";
                break;
            case 7:
                // "Technical Skills"
                hintText.text = "Skills needed to do the job or be successful in a speciifc career.";
                break;
            case 8:
                // "Soft Skills"
                hintText.text = "Skills needed to be successful in a team or workplace environment.";
                break;
            case 9:
                // "Cover Letter"
                hintText.text = "Document used to express why you are qualified for a job position.";
                break;
        }

        guessesLeftText.text = "Guesses Left: " + guessesLeft;

        if (wordCounter < 9)
        {
            nextWordButton.SetActive(true);
        }
        else
        {
            nextWordButton.SetActive(false);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        //CheckKeyboard ();
        CheckKeyboard2 ();
    }

    public void InitGame()
    {
        //int randomNumber = Random.Range (0, wordsToGuess.Length - 1);
        //randomNumber = Random.Range (0, wordsToGuess.Length - 1);
        //wordToGuess = wordsToGuess [randomNumber];

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
                        else if (lettersToGuess [i] != letterPressed)
                        {
                            lettersGuessed [i] = false;
                            guessesLeft --;
                            letterGuessed01.text = letterPressed.ToString();
                        }
                    }
                    else if (lettersGuessed [i])
                    {
                        successPanel.SetActive(true);
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

    public void NextWord()
    {
        successPanel.SetActive(false);

        guessesLeft = 3;

        letterGuessed01.text = "";
        letterGuessed02.text = "";
        letterGuessed03.text = "";

        hintButton.SetActive(false);

        wordCounter++;

        ChooseWord01();
    }

    public void RepeatWord()
    {
        failPanel.SetActive(false);

        wordToGuess = wordsToGuess [randomNumber];

        guessesLeft = 3;

        letterGuessed01.text = "";
        letterGuessed02.text = "";
        letterGuessed03.text = "";

        hintButton.SetActive(false);

        InitGame();
        InitLetters();
    }

    public void ChooseWord01()
    {
        //int randomNumber = Random.Range (0, wordsToGuess.Length - 1);
        randomNumber = Random.Range (0, wordsToGuess.Length - 1);
        //wordToGuess = wordsToGuess [randomNumber];
        ChooseWord02();
    }

    public void ChooseWord02()
    {
        if (randomNumber == 0 && word0Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 1 && word1Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 2 && word2Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 3 && word3Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 4 && word4Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 5 && word5Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 6 && word6Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 7 && word7Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 8 && word8Completed == true)
        {
            ChooseWord01();
        }
        if (randomNumber == 9 && word9Completed == true)
        {
            ChooseWord01();
        }
        else
        {
            wordToGuess = wordsToGuess [randomNumber];
        }
        
        InitGame();
        InitLetters();
    }

    public void PausedGame()
    {
        pausedPanel.SetActive(true);
    }

    public void UnPausedGame()
    {
        pausedPanel.SetActive(false);
    }

    public void FreeHint()
    {
        hintPanel.SetActive(true);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
