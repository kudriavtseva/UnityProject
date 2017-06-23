using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{

    [SerializeField]
    private UILabel FruitLabel;

    void Start()
    {
        LevelController.current.FruitCollectedAmountChanged += OnFruitAmountChanged;
        FruitLabel.text = 0 + "/10";
    }

    private void OnFruitAmountChanged(int amount)
    {
        FruitLabel.text = amount + "/10";
    }
}
