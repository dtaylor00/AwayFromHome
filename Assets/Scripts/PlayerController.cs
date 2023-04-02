using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float movementSpeed = 5f;

    private new Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    private Vector2 movementDirection;
    private List<Collider2D> colliders = new List<Collider2D>();
    public int state = 0;
    // public bool Key { get; set; }
    // public bool Code { get; set; }

    // Start is called before the first frame update
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {

        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (movementDirection.x > 0) {
            spriteRenderer.flipX = true;
        } else if (movementDirection.x < 0) {
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Z)) {
            foreach (var col in colliders) {
                IIteractable obj;
                if (col.TryGetComponent<IIteractable>(out obj)) {
                    obj.RunInteraction(gameObject);
                }
            }
        }
    }

    private void FixedUpdate() {
        if (DialogBox.Instance.gameObject.activeSelf) {
            rigidbody.velocity = Vector2.zero;
        } else {
            rigidbody.velocity = movementDirection * movementSpeed;

        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        colliders.Add(other);
    }

    void OnTriggerExit2D(Collider2D other) {
        colliders.Remove(other);

    }
}
