using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Bomb : Collectable
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
        rabit.removeHealth(1);
=======
public class Bomb : Collectable
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
        rabit.removeHealth(1);
>>>>>>> c5ea4e8a60883b5d89ef8812e451511fab7d2c97
    }
}