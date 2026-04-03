using UnityEngine;

public class ToggleLight : MonoBehaviour{

    [SerializeField] GameObject lightGroup;
    [SerializeField] GameObject activator;

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
            }
        }
    }

    private void LightToggle() { 
        lightGroup.SetActive(true);
    }
}
