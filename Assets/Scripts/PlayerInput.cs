using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
     public Transform capsuleTransform;
     public float multiplier;
     public float maxX;
     public float minX;


     private void Update()
     {
         capsuleTransform.position+= Vector3.forward*2 * Time.deltaTime;
     }

     public void TestInput(InputAction.CallbackContext inputAction)
        {
            Vector2 deltaPos = inputAction.ReadValue<Vector2>();

            float horizantalValue = capsuleTransform.position.x + deltaPos.x * multiplier ;

            float ClampedValue = Mathf.Clamp(horizantalValue, minX, maxX);

            capsuleTransform.position =
                new Vector3(ClampedValue, capsuleTransform.position.y, capsuleTransform.position.z);
            
            //capsuleTransform.transform.position += new Vector3(deltaPos.x,deltaPos.y,0) * multiplier;
           
        }
        

}
