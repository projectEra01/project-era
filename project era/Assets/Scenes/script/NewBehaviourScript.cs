using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
   private void Uptade() {
    if (Input.GetKey(KeyCode.W)) {
        Debug.Log("Pressing!");
    } else {
        Debug.Log("-");
    }
   }
   
}
