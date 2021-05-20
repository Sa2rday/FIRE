using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMenu : MonoBehaviour
{
    public GameObject Angar;        //обозначаю объекты между которыми буду переключаться
    public GameObject Menu;
    public GameObject Options;

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
}
