using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using Random = UnityEngine.Random;
using Unity.VisualScripting;
using JetBrains.Annotations;

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

    private string [] wordsToGuess = new string [] {"resume", "handshake","linkedin", "internship", "jobshadowing", "businessattire", "networking", "technicalskills", "softskills", "coverletter" };

    int randomNumber;
    int guessesLeft;
    int wordCounter = 0;
    //int i = 0;


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

    bool wrongLetterGuessed = false;

    //Timer
    public int timeLeft;
    public TMP_Text timeLeftText;
    float currCountdownValue;

    public bool wordGuessed;

    public int lettersCorrect;


    // Start is called before the first frame update
    public void Start()
    {
        center = GameObject.Find ("CenterOfScreen");
        startGamePanel.SetActive(true);

        //guessesLeft = 3;

        letterGuessed01.text = "";
        //letterGuessed02.text = "";
        //letterGuessed03.text = "";

        //ChooseWord01();
        
        //InitGame();
        //InitLetters();
    }

    // Update is called once per frame
    public void Update()
    {
        timeLeftText.text = "Time Left: " + timeLeft;
        
        // Time Left
        if (timeLeft > 30)
        {
            hintButton.SetActive(false);
            failPanel.SetActive(false);
        }
        else if (timeLeft <= 30 && timeLeft >= 1)
        {
            hintButton.SetActive(true);
            failPanel.SetActive(false);
        }
        else if (timeLeft == 0)
        {
            // GameObject letter;
            // int i = 0;
            // while (letter = GameObject.Find("letter" + (i+1)))
            // {
            //     Destroy(letter);
            //     //letter.SetActive(false);
            //     i++;
            // }

            // GameObject[] letters;
            // letters = GameObject.FindGameObjectsWithTag("Letter");
            // int a = letters.Length;
            // for (int i = 0; i < a; i++)
            // {
            //     Destroy(letters[i]);
            // }
            
            failPanel.SetActive(true);
            gamePanel.SetActive(false);
            Time.timeScale = 0f;
            
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

        if (wordGuessed == true)
        {
            Time.timeScale = 0f;
            //Destroy(letter);
            successPanel.SetActive(true);
            gamePanel.SetActive(false);

            // GameObject letter;
            // int i = 0;
            // while (letter = GameObject.Find("letter" + (i+1)))
            // {
            //     //Destroy(letter);
            //     letter.SetActive(false);
            //     i++;
            // }

            // GameObject[] letters;
            // letters = GameObject.FindGameObjectsWithTag("Letter");
            // int a = letters.Length;
            // for (int i = 0; i < a; i++)
            // {
            //     Destroy(letters[i]);
            // }
        }
        else
        {
            successPanel.SetActive(false);
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

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //CheckKeyboard ();
        //CheckKeyboard2 ();
        //CheckKeyboard2a ();
        CheckKeyboard2a1 ();
        //CheckKeyboard3 ();
        //CheckKeyboard3a ();
        //CheckKeyboard3a1 ();
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

        StartCoroutine(StartCountdown());
    }
    
    public void InitLetters()
    {
        // GameObject letter;
        // int i = 0;
        // while (letter = GameObject.Find("letter" + (i+1)))
        // {
        //     Destroy(letter);
        //     letter.SetActive(false);
        //     i++;
        // }

        GameObject[] letters;
        letters = GameObject.FindGameObjectsWithTag("Letter");
        int a = letters.Length;
        for (int i = 0; i < a; i++)
        {
            Destroy(letters[i]);
        }


        
        int nbletters = lengthOfWordToGuess;
    
        for (int i = 0; i < nbletters; i++) 
        {
            Vector3 newPosition;
            newPosition = new Vector3 (center.transform.position.x + ((i-nbletters/2.5f) *50), center.transform.position.y, center.transform.position.z);
            GameObject l = (GameObject)Instantiate (letter, newPosition, Quaternion.identity);
    
            l.name = "letter" + (i + 1);
            l.tag = "Letter";
            l.transform.SetParent(GameObject.Find ("Letters").transform);
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
                            wrongLetterGuessed = false;
                            GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                        }
                        else if (lettersToGuess [i] != letterPressed)
                        {
                            lettersGuessed [i] = false;
                            wrongLetterGuessed = true;
                            letterGuessed01.text = letterPressed.ToString();
                        }
                    }
                    // else
                    // {
                    //     //successPanel.SetActive(true);
                    //     wordGuessed = true;
                    // }
                    if (lettersToGuess.Length == 0)
                    {
                        wordGuessed = true;
                    }
                }
            }
        }
    }

    public void CheckKeyboard2a()
    {
        if (Input.anyKeyDown)
        {
            char letterPressed = Input.inputString.ToCharArray () [0];
            int letterPressedAsInt = System.Convert.ToInt32 (letterPressed);
 
            if (letterPressedAsInt >= 97 && letterPressedAsInt <= 122)
            {
                // Check for the letter inside the word
                letterPressed = System.Char.ToUpper(letterPressed);
                if (!wordToGuess.Contains(letterPressed, StringComparison.CurrentCultureIgnoreCase))
                {
                    wrongLetterGuessed = true;
                    letterGuessed01.text = letterPressed.ToString();
                }
                else
                {
                    for (int i=0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == letterPressed)
                        {
                            // reveal the letter, and increment lettersCorrect
                            GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                            lettersCorrect++;
                        }
                    }
                }

                // Now that's all done, let's see if the word is revealed
                if (lettersCorrect == wordToGuess.Length)
                {
                    wordGuessed = true;
                }
            }
        }
    }

    public void CheckKeyboard2a1()
    {
        if (Input.anyKeyDown)
        {
            char letterPressed = Input.inputString.ToCharArray () [0];
            int letterPressedAsInt = System.Convert.ToInt32 (letterPressed);
 
            if (letterPressedAsInt >= 97 && letterPressedAsInt <= 122)
            {
                // Check for the letter inside the word
                letterPressed = System.Char.ToUpper(letterPressed);
                if (!wordToGuess.Contains(letterPressed, StringComparison.CurrentCultureIgnoreCase))
                {
                    wrongLetterGuessed = true;
                    letterGuessed01.text = letterPressed.ToString();
                }
                else
                {
                    for (int i=0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == letterPressed)
                        {
                            if (letterPressed.ToString() != GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text)
                            {
                                // reveal the letter, and increment lettersCorrect
                                GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                                lettersCorrect++;
                            }
                            else
                            {
                                lettersCorrect += 0;
                            }
                        }
                    }
                }

                // Now that's all done, let's see if the word is revealed
                if (lettersCorrect == wordToGuess.Length)
                {
                    wordGuessed = true;
                }
            }
        }
    }

    public void CheckKeyboard3()
    {
        if (!string.IsNullOrEmpty(Input.inputString))
        {
            char letterPressed = Input.inputString[0];
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
                            wrongLetterGuessed = false;
                            GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                        }
                        else if (lettersToGuess [i] != letterPressed)
                        {
                            lettersGuessed [i] = false;
                            wrongLetterGuessed = true;
                            letterGuessed01.text = letterPressed.ToString();
                        }
                    }
                    // else
                    // {
                    //     //successPanel.SetActive(true);
                    //     wordGuessed = true;
                    // }
                    if (lettersToGuess == null && lettersToGuess.Length == 0)
                    {
                        wordGuessed = true;
                    }
                }
            }
        }
    }

    public void CheckKeyboard3a()
    {
        if (!string.IsNullOrEmpty(Input.inputString))
        {
            char letterPressed = Input.inputString[0];
            int letterPressedAsInt = System.Convert.ToInt32 (letterPressed);
 
            if (letterPressedAsInt >= 97 && letterPressedAsInt <= 122)
            {
                // Check for the letter inside the word
                letterPressed = System.Char.ToUpper(letterPressed);
                if (!wordToGuess.Contains(letterPressed, StringComparison.CurrentCultureIgnoreCase))
                {
                    wrongLetterGuessed = true;
                    letterGuessed01.text = letterPressed.ToString();
                }
                else
                {
                    for (int i=0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == letterPressed)
                        {
                            // reveal the letter, and increment lettersCorrect
                            GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                            lettersCorrect++;
                        }
                    }
                }

                // Now that's all done, let's see if the word is revealed
                if (lettersCorrect == wordToGuess.Length)
                {
                    wordGuessed = true;
                }
            }
        }
    }

    public void CheckKeyboard3a1()
    {
        if (!string.IsNullOrEmpty(Input.inputString))
        {
            char letterPressed = Input.inputString[0];
            int letterPressedAsInt = System.Convert.ToInt32 (letterPressed);
 
            if (letterPressedAsInt >= 97 && letterPressedAsInt <= 122)
            {
                // Check for the letter inside the word
                letterPressed = System.Char.ToUpper(letterPressed);
                if (!wordToGuess.Contains(letterPressed, StringComparison.CurrentCultureIgnoreCase))
                {
                    wrongLetterGuessed = true;
                    letterGuessed01.text = letterPressed.ToString();
                }
                else
                {
                    for (int i=0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == letterPressed)
                        {
                            if (letterPressed.ToString() != GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text)
                            {
                                // reveal the letter, and increment lettersCorrect
                                GameObject.Find("letter"+(i+1)).GetComponent<TMP_Text>().text = letterPressed.ToString();
                                lettersCorrect++;
                            }
                            else
                            {
                                lettersCorrect += 0;
                            }
                        }
                    }
                }

                // Now that's all done, let's see if the word is revealed
                if (lettersCorrect == wordToGuess.Length)
                {
                    wordGuessed = true;
                }
            }
        }
    }

    public void StartGame()
    {
        startGamePanel.SetActive(false);
        gamePanel.SetActive(true);

        ChooseWord01();
        //InitGame();
        //InitLetters();
    }

    public void NextWord()
    {
        successPanel.SetActive(false);
        gamePanel.SetActive(true);

        //wordToGuess = "";
        lengthOfWordToGuess = 0;

        //guessesLeft = 3;
        Time.timeScale = 1.0f;
        timeLeft = 60;

        letterGuessed01.text = "";
        //letterGuessed02.text = "";
        //letterGuessed03.text = "";

        hintButton.SetActive(false);
        hintPanel.SetActive(false);
        wordGuessed = false;

        wordCounter++;

        switch (randomNumber)
        {
            case 0:
                word0Completed = true;
                break;
            case 1:
                word1Completed = true;
                break;
            case 2:
                word2Completed = true;
                break;
            case 3:
                word3Completed = true;
                break;
            case 4:
                word4Completed = true;
                break;
            case 5:
                word5Completed = true;
                break;
            case 6:
                word6Completed = true;
                break;
            case 7:
                word7Completed = true;
                break;
            case 8:
                word8Completed = true;
                break;
            case 9:
                word9Completed = true;
                break;
        }

        ChooseWord01();
    }

    public void RepeatWord()
    {
        failPanel.SetActive(false);
        gamePanel.SetActive(true);

        lengthOfWordToGuess = 0;
        wordToGuess = wordsToGuess [randomNumber];

        //guessesLeft = 3;
        Time.timeScale = 1.0f;
        timeLeft = 60;

        letterGuessed01.text = "";
        //letterGuessed02.text = "";
        //letterGuessed03.text = "";

        hintButton.SetActive(false);
        hintPanel.SetActive(false);
        wordGuessed = false;

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
        Time.timeScale = 0f;
    }

    public void UnPausedGame()
    {
        pausedPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void FreeHint()
    {
        hintPanel.SetActive(true);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator StartCountdown(float countdownValue = 60)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            timeLeft = (int)currCountdownValue;
        }
    }
}
