// This code is for all the objects from which player will bumping. When player bump with any object with this code, the object color will change to red.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.tag == "Player")
      {
      GetComponent<MeshRenderer>().material.color = Color.red;
      gameObject.tag = "Hit";
      }
    }

}
