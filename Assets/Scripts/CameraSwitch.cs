using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{
    public GameObject areaCam;
    private GameObject curCam;

    public MonoBehaviour cameraSystem;

    private void Start()
    {
        //camera2.SetActive(true);
        //camera1.SetActive(false);
        //camera3.SetActive(false);
        //curCam = camera2;
    }

    private void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    SwitchCam1();
        //}

        //else if (Input.GetKeyDown(KeyCode.P))
        //{
        //    SwitchCam2();
        //}
    }

    private void OnTriggerEnter(Collider other)
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

    //void SwitchCam1()
    //{
    //    camera1.SetActive(true);
    //    curCam.SetActive(false);
    //    curCam = camera1;
    //}

    //void SwitchCam2()
    //{
    //    camera2.SetActive(true);
    //    curCam.SetActive(false);
    //    curCam = camera2;
    //}
}
