using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public CharacterController player;
    public GameObject TelePoint;
    public AudioClip teleSound;
    public AudioSource teleportSource;

    private void OnTriggerEnter(Collider other)
    {
        player.enabled = false;
        player.transform.position = TelePoint.transform.position;
        teleportSource.PlayOneShot(teleSound);
        player.enabled = true;
    }
}
