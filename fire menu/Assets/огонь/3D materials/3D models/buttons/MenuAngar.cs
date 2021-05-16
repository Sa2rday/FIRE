using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAngar : MonoBehaviour
{
   public void ButtonAngar()
    {
        SceneManagement.LoadScene(1);
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
