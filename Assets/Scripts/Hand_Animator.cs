using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Hand_Animator : MonoBehaviour
{

    [SerializeField] private NearFarInteractor nearFarInteractor;
    [SerializeField] private SkinnedMeshRenderer handMesh;

    private void Awake()
    {
        nearFarInteractor.selectEntered.AddListener(OnGrab);
        nearFarInteractor.selectExited.AddListener(OnRelease);
    }

    private void OnRelease(SelectExitEventArgs arg)
    {
        handMesh.enabled = true;
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        handMesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
