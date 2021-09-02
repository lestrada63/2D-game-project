using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public Text GemText;

    int Gems = 0;

    void Start()
    {
        GemText.text = Gems.ToString ();
    }

    public void AddGems()
    {
        Gems++;
        GemText.text = Gems.ToString ();
        if (Gems >= 32)
        {
            GetComponent<PlayerHealth> ().EndGame ();
        }
//        print (Gems);
    }
}
