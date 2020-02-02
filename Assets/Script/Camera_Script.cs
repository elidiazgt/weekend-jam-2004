using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //cam = Camera.main;
        //distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);

        //leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        //rightConstraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        //bottomConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
        //topConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distanceZ)).y;
        // set the desired aspect ratio (the values in this example are
        // hard-coded for 16:9, but you could make them into public
        // variables instead so you can set them at design time)
        float targetaspect = 16.0f / 9.0f;

        // determine the game window's current aspect ratio
        float windowaspect = (float)Screen.width / (float)Screen.height;

        // current viewport height should be scaled by this amount
        float scaleheight = windowaspect / targetaspect;

        // obtain camera component so we can modify its viewport
        Camera camera = GetComponent<Camera>();

        // if scaled height is less than current height, add letterbox
        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;

            camera.rect = rect;
        }
        else // add pillarbox
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }
    }

        void FixedUpdate()
        {
            //    if (transform.position.x < leftConstraint - buffer)
            //    {
            //        transform.position = new Vector3(rightConstraint + buffer, transform.position.y, transform.position.z);
            //    }
            //    if (transform.position.x > rightConstraint + buffer)
            //    {
            //        transform.position = new Vector3(leftConstraint - buffer, transform.position.y, transform.position.z);
            //    }
            //    if (transform.position.y < bottomConstraint - buffer)
            //    {
            //        transform.position = new Vector3(transform.position.x, topConstraint + buffer, transform.position.z);
            //    }
            //    if (transform.position.y > topConstraint + buffer)
            //    {
            //        transform.position = new Vector3(transform.position.x, bottomConstraint - buffer, transform.position.z);
            //    }
            //}
        }
 }
