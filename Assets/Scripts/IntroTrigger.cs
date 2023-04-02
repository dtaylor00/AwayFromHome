using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTrigger : DialogIteractable {


    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public override void RunInteraction(GameObject obj) {
        DialogBox.Instance.SetText("Me: I need to take over the cockpit to return home!\n<Press z to continue>");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        RunInteraction(other.gameObject);
    }


}
