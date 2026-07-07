using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
  public int health;
 
    public Slider PlayerHP;
  
    public void Take_Damage(int damage)
    {

        PlayerHP.value = health;
        health -= damage;
        Debug.Log("Damaged");

        if(health <= 0)
        {
        this .enabled = false;
     
        PlayerHP.gameObject.SetActive(false);
        gameObject.SetActive(false);
        SceneManager.LoadScene("Game Over For Hunter");
        }
    }
    public void Health(int heal)
    {
        health += heal;
        PlayerHP.value = health;
    }
}
