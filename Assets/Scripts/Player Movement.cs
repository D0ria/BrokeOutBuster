using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public ControlMap1 inputActions;
    public float speed=5;
    public float maxX = 7.5f;
    float movementHorizontal;
    // Start is called before the first frame update

    public static PlayerMovement instance;
    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
        inputActions = new ControlMap1();
        inputActions.Player.Enable();
        inputActions.Player.Menu.performed += Menu_performed;
    }

    private void Menu_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Test");
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = inputActions.Player.move.ReadValue<Vector2>().x; ;
        if ((movementHorizontal > 0 && transform.position.x < maxX) || (movementHorizontal < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * movementHorizontal * speed * Time.deltaTime;
        }
    }
}
