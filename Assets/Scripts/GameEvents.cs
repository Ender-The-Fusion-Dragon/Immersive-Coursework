using System;
using UnityEngine;

public class GameEvents : MonoBehaviour{

    public static GameEvents current;

    private void Awake(){
        current = this;
    }

    public event Action eventConsoleComplete;
    public event Action eventConsoleIncomplete;

    public void SetConsoleComplete(){
        Debug.Log("Event function called");
        if (eventConsoleComplete != null){
            eventConsoleComplete();
            Debug.Log("open event happened");
        }
    }

    public void SetConsoleIncomplete()
    {
        if (eventConsoleIncomplete != null){
            eventConsoleIncomplete();
        }
    }
}
