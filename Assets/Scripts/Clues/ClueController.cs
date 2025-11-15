using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClueController : MonoBehaviour
{
    public static event Action<ClueObject> onClueAnalyzed;
    [SerializeField]
    public ClueObject currentClue;
    //Temporary bool to test enumerator
    public bool analyzingClue = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Testing clue analysis
        //InitializeClueAnalysis(currentClue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InitializeClueAnalysis(ClueObject clue_)
    {
        //calls coroutine to analyze clues
        StartCoroutine(ClueAnalysis());
        //set clue
        currentClue = clue_;
    }
    private IEnumerator ClueAnalysis()
    {
        //while the clue is being analyzed, execute some functionality
        while(analyzingClue)
        {
            //Debug.Log("analyzing clue");
            //some functionality here (rotating a 3D model?)
            /*
             */
            //temporarily run and exit the coroutine
            analyzingClue = false;
        }
        //after exiting, invoke Action onClueAnalyzed(currentClue)
        if (onClueAnalyzed != null)
        {
            onClueAnalyzed(currentClue);
        }
        yield return null;
    }
}
