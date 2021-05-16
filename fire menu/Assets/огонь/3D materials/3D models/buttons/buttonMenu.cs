using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMenu : MonoBehaviour
{
    public GameObject Angar;        //обозначаю объекты между которыми буду переключаться
    public GameObject Menu;
    public GameObject Options;
    public GameObject Play;
    public GameObject Rifles;
    public GameObject Automatic;
    public GameObject Pistols;

    public void AngarButton()       //public void создаёт функция, дальше её название
    {
        Angar.SetActive(true);      //включаю объект, SetActive() может выключать и включать объекты на сцене
        Menu.SetActive(false);      //при true объект включён при false выключен
    }
    public void ExitButton()
    {
        Application.Quit();         //Application.Quit() выключает приложение
    }
    public void OptionsButton()
    {
        Options.SetActive(true);
        Menu.SetActive(false);
    }
    public void AngarMenuButton()
    {
        Angar.SetActive(false);
        Menu.SetActive(true);
    }
    public void OPtionsMenuButton()
    {
        Options.SetActive(false);
        Menu.SetActive(true);
    }
    public void PlayButton()
    {
        //SceneManager.LoadScene();           //SceneManager.LoadScene(name) загружает сцену 
    }
    public void RiflesButton()
    {
        Rifles.SetActive(true);
        Angar.SetActive(false);
    }
    public void RiflesAngarButton()
    {
        Angar.SetActive(false);
        Menu.SetActive(true);
    }
    public void AutomaticButton()
    {
        Automatic.SetActive(true);
        Angar.SetActive(false);
    }
    public void AutomaticAngarButton()
    {
        Automatic.SetActive(false);
        Angar.SetActive(true);
    }
    public void PistolsButton()
    {
        Pistols.SetActive(true);
        Angar.SetActive(false);
    }
    public void PistolsAngarButton()
    {
        Pistols.SetActive(false);
        Angar.SetActive(true);
    }
    public void ButtonMenuAngar
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonBackAngar() 
    {
        SceneManager.LoadScene(0);
    }
}
