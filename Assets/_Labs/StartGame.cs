using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Start_Game : MonoBehaviour
{
    public void StartButton()
    {

        SceneManager.LoadScene("MainMenu");

    }
    public void ResetButton()
    {

        SceneManager.LoadScene("MainMenu");

    }
}
