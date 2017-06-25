using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevelTrigger : MonoBehaviour
{
    public string LevelName;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<HeroRabit>() != null)
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
