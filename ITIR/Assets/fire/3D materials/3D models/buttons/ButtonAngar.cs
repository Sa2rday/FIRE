using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonAngar : MonoBehaviour
{
    public GameObject Automatic;
    public GameObject Rifles;
    public GameObject Pistols;
    public GameObject Play;
    public GameObject Options;
    public GameObject Angar;
    
    public void AutomaticButton()
    {
       Automatic.SetActive(true);     
        Angar.SetActive(false);     
    }
    public void AutomaticAngarButton()
    {
        Angar.SetActive(true);      
        Automatic.SetActive(false);      
    }
    public void RiflesButton()
    {
        Rifles.SetActive(true);
        Angar.SetActive(false);
    }
    public void RiflesAngarButton()
    {
        Angar.SetActive(true);
        Rifles.SetActive(false);
    }
    public void PistolsButton()
    {
        Pistols.SetActive(true);
        Angar.SetActive(false);
    }
    public void PistolsAngarButton()
    {
        Angar.SetActive(true);
       Pistols.SetActive(false);
    }
    public void ExitButton()
    {
        Application.Quit();         //Application.Quit() выключает приложение
    }
    public void OptionsButton()
    {
        Options.SetActive(true);
        Angar.SetActive(false);
    }
    public void OPtionsAngarButton()
    {
        Options.SetActive(false);
        Angar.SetActive(true);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
