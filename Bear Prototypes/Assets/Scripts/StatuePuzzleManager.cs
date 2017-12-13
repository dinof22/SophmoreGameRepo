using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StatuePuzzleManager : MonoBehaviour {


    public GameObject leftPlatform, CenterPlatform, RightPlatform;

    public float[] statues, answerSheet;
    private bool puzzleComplete;
    public static Action ActionPuzzleComplete;

	// Use this for initialization
	void Start () {
        RotateStatue.StatueRotated += CheckStatue;
	}

    void CheckStatue(int _statue, float _rotValue) {
        print(_statue + "statue");
        statues[_statue] = _rotValue;
        for (int i = 0; i < statues.Length; i++) {
            puzzleComplete = true;
            if (statues[i] != answerSheet[i]) {
                puzzleComplete = false;
                break;
            }
        }
        if (puzzleComplete) {
            print(puzzleComplete);
            if (ActionPuzzleComplete != null)
            {
                ActionPuzzleComplete();
                leftPlatform.SetActive(false);
                CenterPlatform.SetActive(false);
                RightPlatform.SetActive(false);
            }
        }
    }

}
