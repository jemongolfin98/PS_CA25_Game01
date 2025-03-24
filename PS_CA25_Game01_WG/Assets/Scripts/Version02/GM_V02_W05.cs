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

public class GM_V02_W05 : MonoBehaviour
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


    private string wordToGuess = "jobshadowing";
    private int lengthOfWordToGuess;
 
    public char [] lettersToGuess;
    public bool [] lettersGuessed;

    int randomNumber;
    int guessesLeft;
    int wordCounter = 0;
    //int i = 0;


    public int word01Done1;
    public int word02Done1;
    public int word03Done1;
    public int word04Done1;
    public int word05Done1;
    public int word06Done1;
    public int word07Done1;
    public int word08Done1;
    public int word09Done1;
    public int word10Done1;
    public int word11Done1;
    public int word12Done1;
    public int word13Done1;
    public int word14Done1;

    public int word15Done1;
    public int word16Done1;
    public int word17Done1;
    public int word18Done1;
    public int word19Done1;
    public int word20Done1;


    
    bool word01Completed = false;
    bool word02Completed = false;
    bool word03Completed = false;
    bool word04Completed = false;
    bool word05Completed = false;
    bool word06Completed = false;
    bool word07Completed = false;
    bool word08Completed = false;
    bool word09Completed = false;
    bool word10Completed = false;
    bool word11Completed = false;
    bool word12Completed = false;
    bool word13Completed = false;
    bool word14Completed = false;
    bool word15Completed = false;
    bool word16Completed = false;
    bool word17Completed = false;
    bool word18Completed = false;
    bool word19Completed = false;
    bool word20Completed = false;

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
        // GameObject script01 = GameObject.Find("GameManager");
        // GM_V02_W01 gameManager01 = script01.GetComponent<GM_V02_W01>();
        // word01Done1 = gameManager01.word01Done1;

        // GameObject script02 = GameObject.Find("GameManager");
        // GM_V02_W02 gameManager02 = script02.GetComponent<GM_V02_W02>();
        // word02Done1 = gameManager02.word02Done1;

        // GameObject script03 = GameObject.Find("GameManager");
        // GM_V02_W03 gameManager03 = script03.GetComponent<GM_V02_W03>();
        // word03Done1 = gameManager03.word03Done1;

        // GameObject script04 = GameObject.Find("GameManager");
        // GM_V02_W04 gameManager04 = script04.GetComponent<GM_V02_W04>();
        // word04Done1 = gameManager04.word04Done1;

        // GameObject script05 = GameObject.Find("GameManager");
        // GM_V02_W05 gameManager05 = script05.GetComponent<GM_V02_W05>();
        // word05Done1 = gameManager05.word05Done1;

        // GameObject script06 = GameObject.Find("GameManager");
        // GM_V02_W06 gameManager06 = script06.GetComponent<GM_V02_W06>();
        // word06Done1 = gameManager06.word06Done1;

        // GameObject script07 = GameObject.Find("GameManager");
        // GM_V02_W07 gameManager07 = script07.GetComponent<GM_V02_W07>();
        // word07Done1 = gameManager07.word07Done1;

        // GameObject script08 = GameObject.Find("GameManager");
        // GM_V02_W08 gameManager08 = script08.GetComponent<GM_V02_W08>();
        // word08Done1 = gameManager08.word08Done1;

        // GameObject script09 = GameObject.Find("GameManager");
        // GM_V02_W09 gameManager09 = script09.GetComponent<GM_V02_W09>();
        // word09Done1 = gameManager09.word09Done1;

        // GameObject script10 = GameObject.Find("GameManager");
        // GM_V02_W10 gameManager10 = script10.GetComponent<GM_V02_W10>();
        // word10Done1 = gameManager10.word10Done1;

        // GameObject script11 = GameObject.Find("GameManager");
        // GM_V02_W11 gameManager11 = script11.GetComponent<GM_V02_W11>();
        // word11Done1 = gameManager11.word11Done1;

        // GameObject script12 = GameObject.Find("GameManager");
        // GM_V02_W12 gameManager12 = script12.GetComponent<GM_V02_W12>();
        // word12Done1 = gameManager12.word12Done1;

        // GameObject script13 = GameObject.Find("GameManager");
        // GM_V02_W13 gameManager13 = script13.GetComponent<GM_V02_W13>();
        // word13Done1 = gameManager13.word13Done1;

        // GameObject script14 = GameObject.Find("GameManager");
        // GM_V02_W14 gameManager14 = script14.GetComponent<GM_V02_W14>();
        // word14Done1 = gameManager14.word14Done1;

        // GameObject script15 = GameObject.Find("GameManager");
        // GM_V02_W15 gameManager15 = script15.GetComponent<GM_V02_W15>();
        // word15Done1 = gameManager15.word15Done1;

        // GameObject script16 = GameObject.Find("GameManager");
        // GM_V02_W16 gameManager16 = script16.GetComponent<GM_V02_W16>();
        // word16Done1 = gameManager16.word16Done1;

        // GameObject script17 = GameObject.Find("GameManager");
        // GM_V02_W17 gameManager17 = script17.GetComponent<GM_V02_W17>();
        // word17Done1 = gameManager17.word17Done1;

        // GameObject script18 = GameObject.Find("GameManager");
        // GM_V02_W18 gameManager18 = script18.GetComponent<GM_V02_W18>();
        // word18Done1 = gameManager18.word18Done1;

        // GameObject script19 = GameObject.Find("GameManager");
        // GM_V02_W19 gameManager19 = script19.GetComponent<GM_V02_W19>();
        // word19Done1 = gameManager19.word19Done1;

        // GameObject script20 = GameObject.Find("GameManager");
        // GM_V02_W20 gameManager20 = script20.GetComponent<GM_V02_W20>();
        // word20Done1 = gameManager20.word20Done1;
        
        
        
        timeLeft = 60;
        Time.timeScale = 1.0f;
        center = GameObject.Find ("CenterOfScreen");
        //startGamePanel.SetActive(true);

        //guessesLeft = 3;

        letterGuessed01.text = "";
        //letterGuessed02.text = "";
        //letterGuessed03.text = "";

        //ChooseWord01();
        
        //WordChecker();
        InitGame();
        InitLetters();
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
            word05Done1 = 0;
            
        }

        hintText.text = "Opportunity to watch/observe professionals in their actual work space.";

        if (wordGuessed == true)
        {
            Time.timeScale = 0f;
            successPanel.SetActive(true);
            gamePanel.SetActive(false);
            word05Done1 = 1;
        }
        else
        {
            successPanel.SetActive(false);
        }
        
        // guessesLeftText.text = "Guesses Left: " + guessesLeft;

        // if (wordCounter < 9)
        // {
        //     nextWordButton.SetActive(true);
        // }
        // else
        // {
        //     nextWordButton.SetActive(false);
        // }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        
        //CheckKeyboard ();
        //CheckKeyboard2 ();
        //CheckKeyboard2a ();
        //CheckKeyboard2a1 ();
        //CheckKeyboard3 ();
        //CheckKeyboard3a ();
        CheckKeyboard3a1 ();
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

        // GameObject[] letters;
        // letters = GameObject.FindGameObjectsWithTag("Letter");
        // int a = letters.Length;
        // for (int i = 0; i < a; i++)
        // {
        //     Destroy(letters[i]);
        // }


        
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

    public void NextWord01()
    {
        SceneManager.LoadScene("V02_Word06");
    }
    
    public void NextWord02()
    {
        randomNumber = Random.Range (1, 20);

        PlayNextLevel();
    }

    public void PlayNextLevel()
    {
        //randomNumber = Random.Range (1, 20);

        if (randomNumber == 1 && word01Completed == false)
        {
            SceneManager.LoadScene("V02_Word01");
        }
        else if (randomNumber == 2 && word02Completed == false)
        {
            SceneManager.LoadScene("V02_Word02");
        }
        else if (randomNumber == 3 && word03Completed == false)
        {
            SceneManager.LoadScene("V02_Word03");
        }
        else if (randomNumber == 4 && word04Completed == false)
        {
            SceneManager.LoadScene("V02_Word04");
        }
        else if (randomNumber == 5 && word05Completed == false)
        {
            SceneManager.LoadScene("V02_Word05");
        }
        else if (randomNumber == 6 && word05Completed == false)
        {
            SceneManager.LoadScene("V02_Word06");
        }
        else if (randomNumber == 7 && word06Completed == false)
        {
            SceneManager.LoadScene("V02_Word07");
        }
        else if (randomNumber == 8 && word07Completed == false)
        {
            SceneManager.LoadScene("V02_Word08");
        }
        else if (randomNumber == 9 && word08Completed == false)
        {
            SceneManager.LoadScene("V02_Word09");
        }
        else if (randomNumber == 10 && word09Completed == false)
        {
            SceneManager.LoadScene("V02_Word10");
        }
        else
        {
            NextWord02();
        }
        // else if (randomNumber == 11 && word10Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word11");
        // }
        // else if (randomNumber == 12 && word11Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word12");
        // }
        // else if (randomNumber == 13 && word12Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word13");
        // }
        // else if (randomNumber == 14 && word13Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word14");
        // }
        // else if (randomNumber == 15 && word14Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word15");
        // }
        // else if (randomNumber == 16 && word15Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word16");
        // }
        // else if (randomNumber == 17 && word16Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word17");
        // }
        // else if (randomNumber == 18 && word17Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word18");
        // }
        // else if (randomNumber == 19 && word18Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word19");
        // }
        // else if (randomNumber == 20 && word19Completed == false)
        // {
        //     SceneManager.LoadScene("V02_Word20");
        // }
        // else
        // {
        //     NextWord02();
        // }
    }

    public void RepeatWord()
    {
        SceneManager.LoadScene("V02_Word05");
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
        SceneManager.LoadScene("MainMenuV02");
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
            Debug.Log("Time Left: " + timeLeft);
        }
    }

    public void WordChecker()
    {
        if (word01Done1 == 1)
        {
            word01Completed = true;
        }
        else
        {
            word01Completed =  false;
        }

        if (word02Done1 == 1)
        {
            word02Completed = true;
        }
        else
        {
            word02Completed =  false;
        }

        if (word03Done1 == 1)
        {
            word03Completed = true;
        }
        else
        {
            word03Completed =  false;
        }

        if (word04Done1 == 1)
        {
            word04Completed = true;
        }
        else
        {
            word04Completed =  false;
        }

        if (word05Done1 == 1)
        {
            word05Completed = true;
        }
        else
        {
            word05Completed =  false;
        }

        if (word06Done1 == 1)
        {
            word06Completed = true;
        }
        else
        {
            word06Completed =  false;
        }

        if (word07Done1 == 1)
        {
            word07Completed = true;
        }
        else
        {
            word07Completed =  false;
        }

        if (word08Done1 == 1)
        {
            word08Completed = true;
        }
        else
        {
            word08Completed =  false;
        }

        if (word09Done1 == 1)
        {
            word09Completed = true;
        }
        else
        {
            word09Completed =  false;
        }

        if (word10Done1 == 1)
        {
            word10Completed = true;
        }
        else
        {
            word10Completed =  false;
        }

        if (word11Done1 == 1)
        {
            word11Completed = true;
        }
        else
        {
            word11Completed =  false;
        }

        if (word12Done1 == 1)
        {
            word12Completed = true;
        }
        else
        {
            word12Completed =  false;
        }

        if (word13Done1 == 1)
        {
            word03Completed = true;
        }
        else
        {
            word13Completed =  false;
        }

        if (word14Done1 == 1)
        {
            word14Completed = true;
        }
        else
        {
            word14Completed =  false;
        }

        if (word15Done1 == 1)
        {
            word15Completed = true;
        }
        else
        {
            word15Completed =  false;
        }

        if (word16Done1 == 1)
        {
            word16Completed = true;
        }
        else
        {
            word16Completed =  false;
        }

        if (word17Done1 == 1)
        {
            word17Completed = true;
        }
        else
        {
            word17Completed =  false;
        }

        if (word18Done1 == 1)
        {
            word18Completed = true;
        }
        else
        {
            word18Completed =  false;
        }

        if (word19Done1 == 1)
        {
            word19Completed = true;
        }
        else
        {
            word19Completed =  false;
        }

        if (word20Done1 == 1)
        {
            word20Completed = true;
        }
        else
        {
            word20Completed =  false;
        }
    }
}
