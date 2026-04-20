using UnityEngine;

public class Lock : MonoBehaviour
{

    [SerializeField] GameObject doorL;
    [SerializeField] GameObject doorR;
    [SerializeField] GameObject key;
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
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Key" && locked){
            if(other.gameObject.name == key.gameObject.name){
                UnlockDoor();
            }
        }
    }

    private void UnlockDoor(){
        doorL.GetComponent<Rigidbody>().isKinematic = false;
        doorR.GetComponent<Rigidbody>().isKinematic = false;

        handleL.GetComponent<BoxCollider>().enabled = true;
        handleR.GetComponent <BoxCollider>().enabled = true;

        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false;

        locked = false;
    }
}
