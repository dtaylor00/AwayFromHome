using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogIteractable : MonoBehaviour, IIteractable {
    [SerializeField] protected string source; // who is saying this? (if empty then system)
    [SerializeField] protected string line; // what are they say?
    [SerializeField] protected GameObject dialog; // ref to dialog canvas

    public virtual void RunInteraction(GameObject obj) {
        DialogBox.Instance.SetText(source + ": " + line);
    }

    void OnTriggerEnter2D(Collider2D other) {
        dialog.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) {
        dialog.SetActive(false);
    }
}