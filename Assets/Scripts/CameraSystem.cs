using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public GameObject triggerCam;
    public GameObject targetDestroy;
    public GameObject curCam;

    private void Update()
    {
        if (curCam == triggerCam)
        {

            targetDestroy.SetActive(false);

        }
    }
}
