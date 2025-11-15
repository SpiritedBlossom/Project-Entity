using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class LockController : MonoBehaviour
{
    [SerializeField]
    //door to be compared, handled by interaction manager
    public DoorObject targetDoor;
    //temporary key variable for testing
    //public KeyObject targetKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Testing if door event works using left click
        //if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Debug.Log("testing key!");
            //TryUnlock(targetKey, targetDoor);
        }
    }

    public void TryUnlock(KeyObject key_, DoorObject door_)
    {
        //if key identifier matches with door identifier, invoke unlocked event
        if (key_.keyData.identifier == door_.doorData.identifier)
        {
            door_.onDoorUnlocked.Invoke();
        }
        else
        {
            //if key identifier does NOT match with door identifier, return
            //Debug.Log("key no work");
            return;
        }
    }
}
