using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : DialogIteractable {

    public override void RunInteraction(GameObject obj) {
        PlayerController player;
        if (obj.TryGetComponent<PlayerController>(out player)) {
            switch (player.state) {
                case 1: {
                    var lines = new List<string>();
                    lines.Add("Me: Don't mind if I borrow this.");
                    lines.Add("Got the captain's key!");
                    DialogBox.Instance.SetMultipleTexts(lines);
                    player.state = 2;
                }
                break;
                case 2: {
                    DialogBox.Instance.SetText("Me: Already got the key. Best not to wake him.");
                }
                break;
                case 3: {
                    var lines = new List<string>();
                    lines.Add("Me: Actually, no need to return the key...");
                    lines.Add("Me: right?");
                    DialogBox.Instance.SetMultipleTexts(lines);
                }
                break;
                case 4: {
                    DialogBox.Instance.SetText("Me: Who's the captain now? >:)");
                }
                break;
                default: {
                    Debug.Log("how did we get here, state = " + player.state);
                }
                break;
            }
        }
    }
}
