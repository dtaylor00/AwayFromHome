using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogBox : MonoBehaviour {
    private static DialogBox _instance;

    public static DialogBox Instance { get { return _instance; } }

    private List<string> lines = new List<string>();
    private int index = 0;
    private bool quit = false;

    public TextMeshProUGUI textMeshPro;

    private void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }


    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            if (index >= lines.Count) {
                gameObject.SetActive(false);
                if (quit) Application.Quit(0);
            } else {
                textMeshPro.SetText(lines[index]);
                index++;
            }
        }
    }

    public void SetText(string text) {
        if (gameObject.activeSelf) return;
        lines = new List<string>();

        index = 1;
        textMeshPro.SetText(text);
        gameObject.SetActive(true);
    }


    public void SetMultipleTexts(List<string> texts) {
        // textMeshPro.SetText(texts);
        lines = texts;

        if (gameObject.activeSelf) return;
        index = 1;
        textMeshPro.SetText(texts[0]);
        gameObject.SetActive(true);
    }

    public void QuitAfter() {
        quit = true;
    }
}
