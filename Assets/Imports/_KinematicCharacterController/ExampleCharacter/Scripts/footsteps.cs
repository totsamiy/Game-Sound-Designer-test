using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
	[FMODUnity.EventRef]
	public string inputsound;
	bool playerismoving = false;
	public float walkingspeed;
	
	void Update () 
		{
			
			
		}
	void CallFootsteps () 
	{
		if(Input.GetAxis("Horizontal") >= -0.001f && Input.GetAxis("Horizontal") <= 0.001f)
			{
			//debug.log player is moving
			playerismoving = false;
			}
			else {
			//debug.log player is not moving
			playerismoving = true;
			}
		if (playerismoving == true)
		{
			FMODUnity.RuntimeManager.PlayOneShot (inputsound);
		}
	}
	void Start (){
		InvokeRepeating ("CallFootsteps", 0, walkingspeed);
	}
	void OnDisable () {
		playerismoving = false;
	}
}
