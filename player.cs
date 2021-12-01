// This is player's code. It simply gives the controls for the player.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{    [SerializeField] float moveSpeed= 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintLine();
    }

    // Update is called once per frame
    void Update()
    { 
      Moving();
    }
    void PrintLine()
    {
      Debug.Log("Welcome to the game");
    }

void Moving()
{
  float xValue= Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
  float zValue= Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
  transform.Translate(xValue,0,zValue);
        
}
}
