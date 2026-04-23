using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ToggleLight : MonoBehaviour{

    [SerializeField] GameObject lightGroup;
    [SerializeField] GameObject activator;
    [SerializeField] GameObject audioClip;

    private bool active;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        active = false;
        lightGroup.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "LightActivator" && active == false) {
            if (other.gameObject.name == activator.gameObject.name) {
                LightToggle();
                activator.GetComponent<Rigidbody>().isKinematic = true;
                activator.GetComponent<Transform>().SetPositionAndRotation(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
            }
        }
    }

    private void LightToggle() { 
        lightGroup.SetActive(true);
        audioClip.SetActive(true);
    }
}
