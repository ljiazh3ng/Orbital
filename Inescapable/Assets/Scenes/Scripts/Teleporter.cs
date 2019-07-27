using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour
{
	public Transform player;      // the Object the player is controlling
	public Vector3 spawnOrgin;     // this will be the bottom right corner of a square we will use as the spawn area
	public Vector3 maximum;        // max distance in the x, y, and z direction the enemy can spawn
	public float spawnRate;        // how often the enemy will respawn
	public float distanceToPlayer; // how close the enemy has to be to the player to play music

	private bool nearPlayer = false; // use this to stop the teleporting if near the player
	private float nextTeleport = 0.0f; // will keep track of when we to teleport next
	void Start()
	{
		nextTeleport = spawnRate;
	}
	void Update()
	{
		if (!nearPlayer)     // only teleport if we are not close to the player
		{
			if (Time.time > nextTeleport)   // only teleport if enough time has passed
			{
				transform.position = new Vector3(Random.Range(spawnOrgin.x, maximum.x), Random.Range(spawnOrgin.y, maximum.y), Random.Range(spawnOrgin.z, maximum.z));   // teleport
				nextTeleport += spawnRate;    // update the next time to teleport
			}
		}

		if (Vector3.Distance(transform.position, player.position) <= distanceToPlayer)
		{
			//if (GetComponent<AudioSource>() && GetComponent<AudioSource>().clip && !GetComponent<AudioSource>().isPlaying)     // play the audio if it isn't playing
			//	GetComponent<AudioSource>().Play();
			nearPlayer = true;
		}
		else
		{
			//if (GetComponent<AudioSource>())
			//	GetComponent<AudioSource>().Stop();
			nearPlayer = false;
		}
	}

}