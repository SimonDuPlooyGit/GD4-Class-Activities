using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    [Header("Actions (drag from your Input Actions asset)")]
    [SerializeField] private InputActionReference Movement;
    [SerializeField] private InputActionReference Movement2;

    [Header("Player")]
    [SerializeField] private Transform p1;
    [SerializeField] private Transform p2;

    [SerializeField] private float speed = 5f;

    private void OnEnable()
    {
        Movement.action.Enable();
        Movement2.action.Enable();
    }

    // Update is called once per frame
    private void OnDisable()
    {
        Movement.action.Disable();
        Movement2.action.Disable();
    }

    private void Update()
    {
        var m1 = Movement.action.ReadValue<Vector2>();
        var m2 = Movement2.action.ReadValue<Vector2>();

        if (p1) p1.position += new Vector3(m1.x, m1.y, 0f) * speed * Time.deltaTime;
        if (p2) p2.position += new Vector3(m2.x, m2.y, 0f) * speed * Time.deltaTime;
    }
}
