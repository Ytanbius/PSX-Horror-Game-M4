using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{
    public GameObject areaCam;
    private GameObject curCam;

    public MonoBehaviour cameraSystem;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");
        curCam = cameraSystem.GetComponent<CameraSystem>().curCam;
        if (curCam != areaCam)
        {
            areaCam.SetActive(true);
            curCam.SetActive(false);
            cameraSystem.GetComponent<CameraSystem>().curCam = areaCam;
            Debug.Log("if");
        }
    }
}
