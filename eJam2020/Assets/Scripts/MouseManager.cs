using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public static MouseManager current;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        current = this;
    }

    private IEnumerator CursorEvents()
    {
        while (true)
        {
            RaycastHit hitGround;
            Ray rayGround = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayGround, out hitGround, 100, LayerMask.GetMask("Tangible")))
            {
                if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
                {
                    Click(Input.GetMouseButtonDown(0), hitGround);
                }
                else if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
                {
                    Release(Input.GetMouseButtonUp(0), hitGround);
                }
                else if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
                {
                    Hold(Input.GetMouseButton(0), hitGround);
                }
                else
                {
                    Hover(hitGround);
                }
            }

            yield return null;
        }
    }

    // EVENTS
    // Subscribe a function to the one you want!
    // Looks like:
    // CameraManager.onHover += FunctionYouWantToRun();
    
    public event Action<RaycastHit> onHover;
    public void Hover(RaycastHit hit)
    {
        onHover?.Invoke(hit);
    }

    public event Action<bool, RaycastHit> onClick;
    public void Click(bool left, RaycastHit hit)
    {
        onClick?.Invoke(left, hit);
    }

    public event Action<bool, RaycastHit> onHold;
    public void Hold(bool left, RaycastHit hit)
    {
        onHold?.Invoke(left, hit);
    }

    public event Action<bool, RaycastHit> onRelease;
    public void Release(bool left, RaycastHit hit)
    {
        onRelease?.Invoke(left, hit);
    }
}