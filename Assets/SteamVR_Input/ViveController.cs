using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour
{

    GameObject playerCamera;

    [SteamVR_DefaultAction("Touchpad")]
    public SteamVR_Action_Vector2 touchPadAction;

    void Start()
    {
        playerCamera = GameObject.Find("VRCamera");
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 touchPadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);
        if (touchPadValue != Vector2.zero)
        {
            print(touchPadValue.x);
            print(touchPadValue.y);

            float h = touchPadValue.x;
            float v = touchPadValue.y;
            float yAngle = playerCamera.transform.eulerAngles.y;

            float gPAngle = 0;

            if (h == 0)
            {
                if (v > 0)
                {
                    gPAngle = 0;
                }
                else if (v < 0)
                {
                    gPAngle = 180;
                }
            }
            else
            {
                if (h < 0 && v >= 0)
                {
                    gPAngle = 360 + Mathf.Atan(h / v) * Mathf.Rad2Deg;
                }
                else if (v < 0)
                {
                    gPAngle = 180 + Mathf.Atan(h / v) * Mathf.Rad2Deg;
                }
                else
                {
                    gPAngle = Mathf.Atan(h / v) * Mathf.Rad2Deg;
                }
            }

            float totalAngle = gPAngle + yAngle;



            float speed = Mathf.Sqrt(h * h + v * v);
            float speedMultipler = 0.05f;

            if (h != 0 || v != 0)
            {
                transform.position += new Vector3(speed * speedMultipler * Mathf.Sin(totalAngle * Mathf.Deg2Rad), 0f, speed * speedMultipler * Mathf.Cos(totalAngle * Mathf.Deg2Rad));
            }
        }

    }
}
