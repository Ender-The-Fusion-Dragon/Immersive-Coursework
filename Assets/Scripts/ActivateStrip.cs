using UnityEngine;

public class ActivateStrip : MonoBehaviour{

    [SerializeField] GameObject ActiveStrip;

    private void Start(){
        ActiveStrip.SetActive(false);
        GameEvents.current.eventConsoleComplete += Activate;
        GameEvents.current.eventConsoleIncomplete += Deactivate;
    }

    public void Activate()
    {
        ActiveStrip.SetActive(true);
    }

    public void Deactivate()
    {
        ActiveStrip.SetActive(false);
    }
}
