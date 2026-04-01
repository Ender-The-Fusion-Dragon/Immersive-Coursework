using UnityEngine;

public class CradleTrigger : MonoBehaviour{

    public bool fuseOne, fuseTwo, fuseThree, fuseFour, fuseFive = false;

    [SerializeField] GameObject fuse;


    private void OnTriggerEnter(Collider other){
        
        if(other.tag == "Fuse1"){
            if(other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseOneComplete();
            }
        }

        if (other.tag == "Fuse2"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseTwoComplete();
            }
        }

        if (other.tag == "Fuse3"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseThreeComplete();
            }
        }

        if (other.tag == "Fuse4"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseFourComplete();
            }
        }

        if (other.tag == "Fuse5"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseFiveComplete();
            }
        }

        //if (fuseOne && fuseTwo && fuseThree && fuseFour && fuseFive){
        //GameEvents.current.SetConsoleComplete();
        //}
    }

    //private void OnTriggerExit(Collider other){

        //if (other.tag == "Fuse1"){
            //GameEvents.current.SetConsoleIncomplete();
        //}
    //}
}
