using System;
using UnityEngine;

public class GameEvents : MonoBehaviour{

    [SerializeField] GameObject ConnectorOne;
    [SerializeField] GameObject ConnectorTwo;
    [SerializeField] GameObject ConnectorThree;
    [SerializeField] GameObject ConnectorFour;
    [SerializeField] GameObject ConnectorFive;

    public static GameEvents current;

    private bool fuse1 = false;
    private bool fuse2 = false;
    private bool fuse3 = false;
    private bool fuse4 = false;
    private bool fuse5 = false;

    private void Awake(){
        current = this;
    }

    public event Action eventConsoleComplete;
    public event Action eventConsoleIncomplete;

    public void fuseOneComplete(){
        fuse1 = true;
        Debug.Log("Fuse one used");
    }

    public void fuseTwoComplete(){
        fuse2 = true;
        Debug.Log("Fuse two used");
    }

    public void fuseThreeComplete(){
        fuse3 = true;
        Debug.Log("Fuse three used");
    }

    public void fuseFourComplete(){
        fuse4 = true;
        Debug.Log("Fuse four used");
    }

    public void fuseFiveComplete(){
        fuse5 = true;
        Debug.Log("Fuse five used");
        SetConsoleComplete();
    }

    public void SetConsoleComplete(){
        Debug.Log("Event function called");
        if (eventConsoleComplete != null){
            if (fuse1 && fuse2 && fuse3 && fuse4 && fuse5){
                eventConsoleComplete();
                Debug.Log("open event happened");
            }
        }
    }
}
