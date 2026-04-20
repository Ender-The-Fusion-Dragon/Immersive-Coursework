using System.Net.Sockets;
using UnityEditor;
using UnityEngine;

public class Gate : MonoBehaviour{

    [SerializeField] GameObject doorL;
    [SerializeField] GameObject doorR;
    [SerializeField] GameObject handleL;
    [SerializeField] GameObject handleR;

    private bool locked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        locked = true;
        doorL.GetComponent<Rigidbody>().isKinematic = true;
        doorR.GetComponent<Rigidbody>().isKinematic = true;
        handleL.GetComponent<BoxCollider>().enabled = false;
        handleR.GetComponent<BoxCollider>().enabled = false;

        GameEvents.current.eventConsoleComplete += UnlockDoor;
    }

    private void UnlockDoor()
    {
        doorL.GetComponent<Rigidbody>().isKinematic = false;
        doorR.GetComponent<Rigidbody>().isKinematic = false;

        handleL.GetComponent<BoxCollider>().enabled = true;
        handleR.GetComponent<BoxCollider>().enabled = true;

        locked = false;

        Debug.Log("Door unlocked");
    }
}
