using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartV02 : MonoBehaviour
{
    int randomNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("V02_Word01");
        
        // randomNumber = Random.Range (0, 19);

        // switch (randomNumber)
        // {
        //     case 0:
        //         SceneManager.LoadScene("V02_Word01");
        //         break;
        //     case 1:
        //         SceneManager.LoadScene("V02_Word02");
        //         break;
        //     case 2:
        //         SceneManager.LoadScene("V02_Word03");
        //         break;
        //     case 3:
        //         SceneManager.LoadScene("V02_Word04");
        //         break;
        //     case 4:
        //         SceneManager.LoadScene("V02_Word05");
        //         break;
        //     case 5:
        //         SceneManager.LoadScene("V02_Word06");
        //         break;
        //     case 6:
        //         SceneManager.LoadScene("V02_Word07");
        //         break;
        //     case 7:
        //         SceneManager.LoadScene("V02_Word08");
        //         break;
        //     case 8:
        //         SceneManager.LoadScene("V02_Word09");
        //         break;
        //     case 9:
        //         SceneManager.LoadScene("V02_Word10");
        //         break;
        //     case 10:
        //         SceneManager.LoadScene("V02_Word11");
        //         break;
        //     case 11:
        //         SceneManager.LoadScene("V02_Word11");
        //         break;
        //     case 12:
        //         SceneManager.LoadScene("V02_Word12");
        //         break;
        //     case 13:
        //         SceneManager.LoadScene("V02_Word13");
        //         break;
        //     case 14:
        //         SceneManager.LoadScene("V02_Word14");
        //         break;
        //     case 15:
        //         SceneManager.LoadScene("V02_Word15");
        //         break;
        //     case 16:
        //         SceneManager.LoadScene("V02_Word16");
        //         break;
        //     case 17:
        //         SceneManager.LoadScene("V02_Word17");
        //         break;
        //     case 18:
        //         SceneManager.LoadScene("V02_Word18");
        //         break;
        //     case 19:
        //         SceneManager.LoadScene("V02_Word19");
        //         break;
        // }
    }
}
