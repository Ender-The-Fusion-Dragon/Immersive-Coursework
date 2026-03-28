using UnityEngine;

public class Lock : MonoBehaviour
{

    [SerializeField] GameObject door;
    [SerializeField] GameObject key;
    [SerializeField] GameObject handle;

    private bool locked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "key" && locked){
            if(other.gameObject.name == key.gameObject.name){
                UnlockDoor();
            }
        }
    }

    private void UnlockDoor(){
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false;
        locked = false;
    }
}
