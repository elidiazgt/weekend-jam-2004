using UnityEngine;
using System.Collections;
 
 public class FollowPath : MonoBehaviour
 {
    public AnimationCurve ac;
    private bool spinning = false;
    private Transform startAngle;
 
     void doSpin(float time, float maxAngle)
      {
          spinning = true;
          float timer = 0.0f;
          float startAngle = transform.eulerAngles.z;
 
         while(timer < time)
         {
             float angle = ac.Evaluate(timer / time) * maxAngle;
             transform.eulerAngles = new Vector3(0.0f, 0.0f, angle + startAngle);
             timer += Time.deltaTime;
            
         }
 
         transform.eulerAngles = new Vector3(0.0f, 0.0f, maxAngle + startAngle);
               spinning = false;
      }
  
  
  void  Update ()
  {
      if (Input.GetKeyDown(KeyCode.Space) && !spinning) 
      {
          doSpin(3.0f, 270.0f);
      }
  }
 }
