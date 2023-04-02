using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerTrigger : DialogIteractable {

    public override void RunInteraction(GameObject obj) {
        PlayerController player;
        if (obj.TryGetComponent<PlayerController>(out player)) {
            switch (player.state) {
                case 1: {
                    DialogBox.Instance.SetText("Darn, the captain's locker is locked :(");
                }
                break;
                case 2: {
                    var lines = new List<string>();
                    lines.Add("Me: ??? There's a riddle here:");
                    lines.Add("Me: \"I am hidden\nwhere you go,");
                    lines.Add("Me: To find something to eat,\"");
                    lines.Add("Me: \"Like mac n cheese, or some peas,");
                    lines.Add("Me: Or a tasty treat.\"");
                    DialogBox.Instance.SetMultipleTexts(lines);
                    player.state = 3;
                }
                break;
                case 3: {
                    var lines = new List<string>();
                    lines.Add("Me: What was that riddle again?");
                    lines.Add("Me: \"I am hidden\nwhere you go,");
                    lines.Add("Me: To find something to eat,\"");
                    lines.Add("Me: \"Like mac n cheese, or some peas,");
                    lines.Add("Me: Or a tasty treat.\"");
                    lines.Add("Me: Mmm yes I see.");
                    DialogBox.Instance.SetMultipleTexts(lines);
                }
                break;
                case 4: {
                    DialogBox.Instance.SetText("Me: Hmm... I already solved this. ez");
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
