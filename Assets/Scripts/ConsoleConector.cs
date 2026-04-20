using UnityEngine;

public class CradleTrigger : MonoBehaviour{

    public bool fuseOne, fuseTwo, fuseThree, fuseFour, fuseFive = false;

    [SerializeField] GameObject fuse;
    [SerializeField] GameObject audioClip;


    private void OnTriggerEnter(Collider other){
        
        if(other.tag == "Fuse1"){
            if(other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseOneComplete();
                fuse.GetComponent<Rigidbody>().isKinematic = true;
                fuse.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
                audioClip.SetActive(true);
            }
        }

        if (other.tag == "Fuse2"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseTwoComplete();
                fuse.GetComponent<Rigidbody>().isKinematic = true;
                fuse.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
                audioClip.SetActive(true);
            }
        }

        if (other.tag == "Fuse3"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseThreeComplete();
                fuse.GetComponent<Rigidbody>().isKinematic = true;
                fuse.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
                audioClip.SetActive(true);
            }
        }

        if (other.tag == "Fuse4"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseFourComplete();
                fuse.GetComponent<Rigidbody>().isKinematic = true;
                fuse.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
                audioClip.SetActive(true);
            }
        }

        if (other.tag == "Fuse5"){
            if (other.gameObject.name == fuse.gameObject.name){
                GameEvents.current.fuseFiveComplete();
                fuse.GetComponent<Rigidbody>().isKinematic = true;
                fuse.GetComponent<Transform>().SetPositionAndRotation(transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
                audioClip.SetActive(true);
            }
        }

        //if (fuseOne && fuseTwo && fuseThree && fuseFour && fuseFive){
        //GameEvents.current.SetConsoleComplete();
        //}
    }
}
