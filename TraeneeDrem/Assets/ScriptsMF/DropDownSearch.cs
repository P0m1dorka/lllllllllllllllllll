using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropDownSearch : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Dropdown _dropdown;
    [SerializeField] private Button _buttonSearch;
    [SerializeField]private string[] _scenesNames;
    private void Update()
    {
        _buttonSearch.onClick.AddListener(SceneSearch);
    }
    private void SceneSearch()
    {
        SceneManager.LoadScene(_scenesNames[_dropdown.value]);
    }
}
