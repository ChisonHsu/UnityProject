using UnityEngine;
using System.Collections;

public class CameraController2D : MonoBehaviour {

    public GameObject Player;
    private Vector3 Offset;
	void Start () 
	{
        Player = GameObject.FindWithTag("Player");
        Offset = transform.position - Player.transform.position;
	}
	
	void LateUpdate () 
	{
        transform.position = Player.transform.position + Offset;
	}
}