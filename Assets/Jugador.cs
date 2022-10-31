using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jugador : MonoBehaviour
{
   public float force = 150;
   Rigidbody rb;
   Vector3 movementInput;

   void Awake(){
    rb= GetComponent<Rigidbody>();
   }

   private void Update(){

    movementInput = Vector3.zero;
    if(Input.GetKey(KeyCode.W))
    {
        movementInput.z = 1;
    }
    else if(Input.GetKey(KeyCode.S))
    {
        movementInput.z = -1;
    }
    else if(Input.GetKey(KeyCode.D))
    {
        movementInput.x = 1;
    }
    else if(Input.GetKey(KeyCode.A))
    {
        movementInput.x = -1;
    }
    
   }

   protected void FixedUpdate()
   {
    Move(movementInput);
   }

   void Move(Vector3 direction)
   {
    rb.AddForce(direction.normalized * force , ForceMode.Acceleration);
   }
}
