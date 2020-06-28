using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager current;

    private GameObject cam;
    private Vector3 camTargetPos;

    private ClickMode clickMode;

    void Start()
    {
        current = this;

        cam = GameObject.Find("Camera");
        camTargetPos = GameObject.Find("Camera").transform.localPosition;

        StartCoroutine(Strafe());
    }

    // Controls moving left and right
    private IEnumerator Strafe()
    {
        while (true)
        {
            // Sets new target position based on input
            if (Input.GetKey(KeyCode.A))
            {
                camTargetPos += new Vector3(-0.3f, 0, 0);
                if (camTargetPos.x < -25)
                {
                    camTargetPos.x = -25;
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                camTargetPos += new Vector3(0.3f, 0, 0);
                if (camTargetPos.x > 25)
                {
                    camTargetPos.x = 25;
                }
            }

            // Slowly moves toward the target position
            cam.transform.localPosition = Vector3.Lerp(cam.transform.localPosition, camTargetPos, 0.25f);
            yield return true;
        }
    }

    public void SetClickMode(ClickMode _clickMode)
    {
        clickMode = _clickMode;
    }
}
