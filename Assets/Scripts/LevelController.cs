using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelController : MonoBehaviour
{
    public Action<int> FruitCollectedAmountChanged;
    public static LevelController current;
    private int _fruitAmount;
    HeroRabit rabit;

    Vector3 startingPosition;
    void Awake()
    {


        current = this;
    }
    public void setStartPosition(Vector3 pos)
    {
        this.startingPosition = pos;
    }
    public void onRabitDeath(HeroRabit rabit)
    {
        if (rabit.lifes >0)
        {
            rabit.resetHealth();
            rabit.transform.position = this.startingPosition;
            rabit.lifes--;
        }else
        {
            rabit.lifes = 3;
            SceneManager.LoadScene("ChooseLevel");
           
        }

    }
    public void CollectFruit()
    {
        _fruitAmount++;
        if (FruitCollectedAmountChanged != null)
        {
            FruitCollectedAmountChanged(_fruitAmount);
        }
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

}