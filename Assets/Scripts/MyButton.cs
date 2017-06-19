using System.Collections;
using UnityEngine.Events;
using UnityEngine;
public class MyButton : MonoBehaviour
{
    public MyButton playButton;
    void Start()
    {
        playButton.signalOnClick.AddListener(this.onPlay);
    }
    void onPlay()
    {
        //Do something
    }
    public UnityEvent signalOnClick = new UnityEvent();
    public void _onClick()
    {
        this.signalOnClick.Invoke();
    }
}
