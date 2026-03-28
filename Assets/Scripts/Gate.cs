using UnityEngine;

public class Gate : MonoBehaviour{

    [SerializeField] Animator animator;
    [SerializeField] GameObject ActiveStrip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        ActiveStrip.SetActive(false);
        GameEvents.current.eventConsoleComplete += OpenGate;
        GameEvents.current.eventConsoleIncomplete += CloseGate;
    }

    private void OpenGate(){
        ActiveStrip.SetActive(true);
        animator.SetBool("Open", true);
    }

    private void CloseGate(){
        ActiveStrip.SetActive(false);
        animator.SetBool("Open", false);
    }
}
