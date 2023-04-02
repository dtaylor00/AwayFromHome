using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockpitTrigger : DialogIteractable {
    public GameObject barrier;
    private ChangeScene sceneChanger;

    private void Start() {
        sceneChanger = GetComponent<ChangeScene>();
    }

    public override void RunInteraction(GameObject obj) {
        PlayerController player;
        if (obj.TryGetComponent<PlayerController>(out player)) {
            switch (player.state) {
                case 0: {
                    var lines = new List<string>();
                    lines.Add("Me: What? A passcode? I don't have that!");
                    lines.Add("Me: Guess I have to look around.");
                    DialogBox.Instance.SetMultipleTexts(lines);
                    Destroy(barrier);
                    player.state = 1;
                }
                break;
                case 1: {
                    DialogBox.Instance.SetText("We need to get the code.");
                }
                break;
                case 2: {
                    DialogBox.Instance.SetText("We got the captain's key, but no code :(");
                }
                break;
                case 3: {
                    DialogBox.Instance.SetText("That locker had the interesting riddle...");
                }
                break;
                case 4: {
                    // DialogBox.Instance.SetText("END GAME!");
                    sceneChanger.MoveToScene(2);
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
