using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Collectable : MonoBehaviour
{
    protected virtual void OnRabitHit(HeroRabit rabit)
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
            HeroRabit rabit = collider.GetComponent<HeroRabit>();
            if (rabit != null)
            {
                this.OnRabitHit(rabit);
            }
        
    }
    public void CollectedHide()
    {
        Destroy(this.gameObject);
    }
=======
public class Collectable : MonoBehaviour
{
    protected virtual void OnRabitHit(HeroRabit rabit)
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
            HeroRabit rabit = collider.GetComponent<HeroRabit>();
            if (rabit != null)
            {
                this.OnRabitHit(rabit);
            }
        
    }
    public void CollectedHide()
    {
        Destroy(this.gameObject);
    }
>>>>>>> c5ea4e8a60883b5d89ef8812e451511fab7d2c97
}
