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
                activator.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
            }
        }
    }

    private void LightToggle() { 
        lightGroup.SetActive(true);
        audioClip.SetActive(true);
    }
}
