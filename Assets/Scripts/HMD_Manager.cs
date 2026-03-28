using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour{

    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        Debug.Log("Using device " + XRSettings.loadedDeviceName);

        if(XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "Open XR Display"){
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);
        }else{
            xrPlayer.SetActive(false);
            fpsPlayer.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update(){}
}
