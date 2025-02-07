using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPromptUI : MonoBehaviour
{
    private Camera _mainCam;
    [SerializeField] private GameObject _uiPanel;
    [SerializeField] private TextMeshProUGUI _promptText;
    [SerializeField] private TextMeshProUGUI _promptName;

    // Start is called before the first frame update
    void Start()
    {
        _mainCam = Camera.main;
        _uiPanel.SetActive(false);
    }

    private void LateUpdate(){
        var rotation = _mainCam.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }


    public bool IsDisplayed = false;

    public void SetUp(string promptText, string promptName){
        _promptText.text = promptText;
        _promptName.text = promptName;
        _uiPanel.SetActive(true);
        IsDisplayed = true;
    }

    public void Close(){
        _uiPanel.SetActive(false);
        IsDisplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
