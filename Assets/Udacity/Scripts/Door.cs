using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    public bool locked = true;
    public bool opening = false;
    public bool fullRasied = true;

    public AudioClip lockedDoor;
    public AudioClip openDoor;


    void Update() {
		// If the door is opening and it is not fully raised
        // Animate the door raising up


    	if (opening == true){
			if (gameObject.transform.position.y <= 24) {
				gameObject.transform.Translate (0, 10f * Time.deltaTime, 0);
				}
			}       
    }

    public void OnDoorClicked() {

		AudioSource doorAudio = gameObject.GetComponent<AudioSource> ();

        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked

            if(locked == false){
            opening = true;
            doorAudio.clip = openDoor;
            doorAudio.Play();

           } else {
            	doorAudio.clip = lockedDoor;
            	doorAudio.Play();

            }

    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}



