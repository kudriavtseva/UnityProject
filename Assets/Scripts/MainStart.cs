using System.Collections;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStart : MonoBehaviour
{

   // public UnityEvent signalOnClick = new UnityEvent();
    public void OnClick()
    {
        SceneManager.LoadScene("Level1");
    }
}