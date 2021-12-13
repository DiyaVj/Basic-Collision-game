// This code is for final ramp. it simply changes the color of ramp (from green to yellow) when player reach the final position/ramp.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.tag == "Player")
      {
      GetComponent<MeshRenderer>().material.color = Color.yellow;
      gameObject.tag = "Hit";
      }
    }

}
