using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    public GameObject reward;

    public AudioSource audioSource;
    public AudioClip GemPickup;

    bool collected = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !collected)
        { 
            Instantiate (reward, transform.position, Quaternion.identity);
            other.gameObject.GetComponent<PlayerInventory> ().AddGems ();
            Destroy (gameObject.transform.root.gameObject, 0.2f);
            audioSource.PlayOneShot (GemPickup, 0.5f);
            collected = true;
        }
    }
}
