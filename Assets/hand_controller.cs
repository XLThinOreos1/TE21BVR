using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class hand_controller : MonoBehaviour
{

    [SerializeField] //Gör så man kan använda den i Unity
    GameObject bulletPrefab;

    ActionBasedController controller;

    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTriggerPress;

    }

    void OnTriggerPress(InputAction.CallbackContext context)
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
