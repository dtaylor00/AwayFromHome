using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTrigger : DialogIteractable {
    private const int MAX_STATE = 4;

    [SerializeField] private int state = 0;

    public override void RunInteraction(GameObject obj) {
        if (DialogBox.Instance.gameObject.activeSelf) return;

        switch (state) {
            case 0: {
                DialogBox.Instance.SetText("Purple: ...");
            }
            break;
            case 1: {
                DialogBox.Instance.SetText("Purple: Damn this book is good.");
            }
            break;
            default: {
                DialogBox.Instance.SetText("Purple: I sure do love reading");
            }
            break;
        }

        if (state < MAX_STATE) state++;
        // Debug.Log(state);
    }

}
