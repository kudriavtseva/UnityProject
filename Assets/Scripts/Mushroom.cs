using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Mushroom : Collectable
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void OnRabitHit(HeroRabit rabit)
    {
        this.CollectedHide();
        rabit.addHealth();
=======
public class Mushroom : Collectable
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void OnRabitHit(HeroRabit rabit)
    {
        this.CollectedHide();
        rabit.addHealth();
>>>>>>> c5ea4e8a60883b5d89ef8812e451511fab7d2c97
    }
}
