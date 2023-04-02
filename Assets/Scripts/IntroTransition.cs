using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTransition : MonoBehaviour {
    public List<Sprite> sprites;
    public List<string> lines;
    [SerializeField] private int state = 0;

    private ChangeScene sceneChanger;
    private SpriteRenderer spriteRenderer;

    private void Start() {
        sceneChanger = GetComponent<ChangeScene>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            if (state == 0) DialogBox.Instance.SetMultipleTexts(lines);
            if (state < sprites.Count - 1) {
                state++;
                spriteRenderer.sprite = sprites[state];
                // DialogBox.Instance.SetText(lines[state]);
            } else {
                sceneChanger.MoveToScene(1);
            }

        }
    }
}
