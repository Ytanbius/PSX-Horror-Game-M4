using Unity.Cinemachine;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{
    public GameObject areaCam;

    private GameObject curCam;
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
        curCam = other.GetComponent<CameraSystem>().curCam;
        areaCam.SetActive(true);
        curCam.SetActive(false);
        other.GetComponent<CameraSystem>().curCam = areaCam;
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
