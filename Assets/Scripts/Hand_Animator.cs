using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Hand_Animator : MonoBehaviour
{

    [SerializeField] private NearFarInteractor nearFarInteractor;
    [SerializeField] private SkinnedMeshRenderer handMesh;
    [SerializeField] private InputActionReference selectAction;
    [SerializeField] private InputActionReference activateAction;
    [SerializeField] private Animator handAnimator;

    private static readonly int activateAnim = Animator.StringToHash("activate");
    private static readonly int selectAnim = Animator.StringToHash("select");

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
       handAnimator.SetFloat(activateAnim, activateAction.action.ReadValue<float>());
        handAnimator.SetFloat(selectAnim, selectAction.action.ReadValue<float>());
    }
}
