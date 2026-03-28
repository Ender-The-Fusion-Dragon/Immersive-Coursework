using UnityEngine;

public class CradleTrigger : MonoBehaviour{
    private void OnTriggerEnter(Collider other){
        
        if(other.tag == "Fuse1"){
            GameEvents.current.SetConsoleComplete();
        }
    }

    private void OnTriggerExit(Collider other){

        if (other.tag == "Fuse1"){
            GameEvents.current.SetConsoleIncomplete();
        }
    }
}
