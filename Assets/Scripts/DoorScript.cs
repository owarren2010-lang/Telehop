using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public bool Door = false;
    public GameObject Closed_Door, Open_Door;

    public void OpenDoor()
    {
        Open_Door.SetActive(true);
        Closed_Door.SetActive(false);
        Door = true;
    }
    
    public void ClosedDoor()
    {
        Closed_Door.SetActive(true);
        Open_Door.SetActive(false);
        Door = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Door == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
