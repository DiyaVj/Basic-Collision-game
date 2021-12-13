// This code is for player. If the player hits anything it will count number of times player bumped with any object.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
 int hits = 0;
 private void OnCollisionEnter(Collision other)
{   if(other.gameObject.tag != "Hit")
    {
    hits++;
    Debug.Log("Hit the wall" + hits);
    }
}
}
