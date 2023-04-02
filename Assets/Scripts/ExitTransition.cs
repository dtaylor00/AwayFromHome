using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTransition : MonoBehaviour {
    public List<Sprite> sprites;
    [SerializeField] private int state = 0;

    private SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            if (state < sprites.Count - 1) {
                state++;
                spriteRenderer.sprite = sprites[state];
            } else {
                // sceneChanger.MoveToScene(1);
                DialogBox.Instance.SetText("Thank you for playing!\n\n<Press z to close>");
                DialogBox.Instance.QuitAfter();
            }

        }
    }
}
