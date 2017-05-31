
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

    }
}