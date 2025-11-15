using UnityEngine;
using UnityEngine.Events;

public class DoorObject : MonoBehaviour
{
    //reference to doorSO for identifier
    public DoorSO doorData;
    //event in which door is unlocked
    public UnityEvent onDoorUnlocked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //instantiate event on Start
        if (onDoorUnlocked != null) onDoorUnlocked = new UnityEvent();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //test function in inspector called when onDoorUnlocked is invoked
    public void OnEventTriggered()
    {
        Debug.Log("door open!");
    }
}
