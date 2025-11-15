using UnityEngine;

public class ClueObject : MonoBehaviour
{
    public GoalSO associatedPuzzleStep;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Testing Action 
        //ClueController.onClueAnalyzed += OnEventTriggered;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Temp function to test action
    /*public void OnEventTriggered(ClueObject clue_)
    {
        Debug.Log("Clue analyzed!");
    }*/
}
