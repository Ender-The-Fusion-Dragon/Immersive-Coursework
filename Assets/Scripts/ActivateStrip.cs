using UnityEngine;

public class ActivateStrip : MonoBehaviour{

    [SerializeField] GameObject ActiveStrip;

    private void Start(){
        ActiveStrip.SetActive(false);
        GameEvents.current.eventConsoleComplete += Activate;
    }

    public void Activate()
    {
        ActiveStrip.SetActive(true);
    }
}
