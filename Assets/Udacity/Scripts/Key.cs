using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyPoofPrefab;
    public Door door;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.Rotate (0, 50.0f * Time.deltaTime, 0);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

		Vector3 positionOfKey = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.transform.position.z);
		Instantiate(KeyPoofPrefab, positionOfKey, Quaternion.Euler(-90, 0, 0));
		door.Unlock();
		Destroy(gameObject);


    }

}
