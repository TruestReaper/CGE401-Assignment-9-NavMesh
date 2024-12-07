using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Button1()
    {
        SceneManager.LoadScene("Finished01");
    }

    public void Button2()
    {
        SceneManager.LoadScene("Finished02");
    }

    public void Button3()
    {
        SceneManager.LoadScene("Finished03");
    }

    public void Button4()
    {
        SceneManager.LoadScene("Finished04");
    }

    public void Button5()
    {
        SceneManager.LoadScene("Finished05");
    }

    public void Button6()
    {
        SceneManager.LoadScene("Finished06");
    }
}
