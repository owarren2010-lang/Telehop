using Unity.VisualScripting;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool _leverStatus;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (_leverStatus == false)
        {
            anim.SetTrigger("LeverUP");
            FindAnyObjectByType<DoorScript>().OpenDoor();
        }
    }
}    
    
    
            

  
