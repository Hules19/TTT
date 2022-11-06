using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject Credits;
    [SerializeField] GameObject QuitPanel;

    void Start()
    {
        Menu.SetActive(true);
        Options.SetActive(false);
        Credits.SetActive(false);
        QuitPanel.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
