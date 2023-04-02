using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : DialogIteractable {

    public override void RunInteraction(GameObject obj) {
        PlayerController player;
        if (obj.TryGetComponent<PlayerController>(out player)) {
            switch (player.state) {
                case 1: {
                    DialogBox.Instance.SetText("Me: Hmmm... interesting");
                }
                break;
                case 2: {
                    DialogBox.Instance.SetText("Me: Hmmm... interesting");
                }
                break;
                case 3: {
                    var lines = new List<string>();
                    lines.Add("Me: Ohhh that what the riddle means.");
                    lines.Add("Me: Heyo? The cockpit's code in here!");
                    lines.Add("Me: Time to take over the ship! >:)");
                    DialogBox.Instance.SetMultipleTexts(lines);
                    player.state = 4;
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
