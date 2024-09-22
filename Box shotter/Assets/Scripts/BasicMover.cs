using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public enum motionDirection {Spin,Horizontal,Vertical};
    public motionDirection direction = motionDirection.Horizontal;
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = false;


    // Update is called once per frame
    void Update()
    {
        switch(direction){
        case motionDirection.Spin:
            //spin in up direction
            gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime);
            break;
        
        case motionDirection.Horizontal:
            //motion in right direction
            gameObject.transform.Translate(Vector3.right*Mathf.Cos(Time.timeSinceLevelLoad)*motionMagnitude);

            if(doSpin){
               gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime); 
            }
            break;
 
        case motionDirection.Vertical:
            //motion in up direction
            gameObject.transform.Translate(Vector3.up*Mathf.Cos(Time.timeSinceLevelLoad)*motionMagnitude);
            
            if(doSpin){
               gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime); 
            }
            break;
        }
    }
    
}
