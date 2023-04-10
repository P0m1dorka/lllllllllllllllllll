using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteract : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    private void Start()
    {
        for(int i = 0; i< -_buttons.Length; i++)
        {
            _buttons[i].interactable = true;
        }
    }
}
