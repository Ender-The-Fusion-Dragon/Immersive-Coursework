using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class DoorUnlock : MonoBehaviour{

    [SerializeField] GameObject doorL;
    [SerializeField] GameObject doorR;
    [SerializeField] GameObject handleL;
    [SerializeField] GameObject handleR;

    int[] checkedValues = { 1, 2, 3, 4 };
    List<int> valuesInputed = new List <int>();
    int valueToAdd;


    private bool locked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
        doorL.GetComponent<Rigidbody>().isKinematic = true;
        doorR.GetComponent<Rigidbody>().isKinematic = true;
        handleL.GetComponent<BoxCollider>().enabled = false;
        handleR.GetComponent<BoxCollider>().enabled = false;
    }

    public void addOne(){
        valueToAdd = 1;
        valuesInputed.Add(valueToAdd);
    }

    public void addTwo(){
        valueToAdd = 2;
        valuesInputed.Add(valueToAdd);
    }

    public void addThree(){
        valueToAdd = 3;
        valuesInputed.Add(valueToAdd);
    }

    public void addFour(){
        valueToAdd = 4;
        valuesInputed.Add(valueToAdd);
    }

    public void addFive(){
        valueToAdd = 5;
        valuesInputed.Add(valueToAdd);
    }

    public void addSix(){
        valueToAdd = 6;
        valuesInputed.Add(valueToAdd);
    }

    public void addSeven(){
        valueToAdd = 7;
        valuesInputed.Add(valueToAdd);
    }

    public void addEight(){
        valueToAdd = 8;
        valuesInputed.Add(valueToAdd);
    }

    public void addNine(){
        valueToAdd = 9;
        valuesInputed.Add(valueToAdd);
    }

    public void addZero(){
        valueToAdd = 0;
        valuesInputed.Add(valueToAdd);
    }


    public void checkPassword(){
        int[] checkArray = valuesInputed.ToArray();

        if (checkArray.Length == 4){
            if (checkArray == checkedValues) {
                UnlockDoor();
            }
        }
    }

    private void UnlockDoor()
    {
        doorL.GetComponent<Rigidbody>().isKinematic = false;
        doorR.GetComponent<Rigidbody>().isKinematic = false;

        handleL.GetComponent<BoxCollider>().enabled = true;
        handleR.GetComponent<BoxCollider>().enabled = true;

        locked = false;
    }

}
