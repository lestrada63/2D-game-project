using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public AudioClip playerDamaged;
    AudioSource playerAS;

    public float fullHealth;
    float currentHealth;
    
    public Image healthSlider;
    public Image damageIndicator;
    public string endText = "Victory!";
    public Image deathScreen;
    public CanvasGroup endCG;
    public Text endGameUIText;
    public SpriteRenderer spriteRenderer;
    public Color flashColor;
    
    //Use this for Initialization
    void Start ()
    {
        currentHealth = fullHealth;
        healthSlider.fillAmount = 0f;
        spriteRenderer = GetComponent<SpriteRenderer> ();
        playerAS = GetComponent<AudioSource> ();
    }

    public void addDamage(float damage)
    {
        if (damage <= 0)
            return;
        currentHealth -= damage;

        playerAS.PlayOneShot (playerDamaged);

        healthSlider.fillAmount = 1 - currentHealth / fullHealth;
        flashMethod ();
        if (currentHealth <= 0)
        {
            MakeDead ();
        }
    }
    public void flashMethod ()
    {
        Invoke ("flash", 0);
    }

    public IEnumerator flash()
    {
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds (0.5f);
        spriteRenderer.color = Color.white;
        yield return new WaitForSeconds (0.5f);
    }

    public void MakeDead()
    {
        endText = "Death";
        EndGame ();
        deathScreen.color = Color.red;
        // Destroy (gameObject);
    }

    public void EndGame()
    {
        endGameUIText.text = endText;
        endCG.alpha = 1;
        print (endText);
    }
}
