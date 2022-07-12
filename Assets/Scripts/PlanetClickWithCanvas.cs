using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlanetClickWithCanvas : MonoBehaviour, IClickable , IPanelOpener
{
    [SerializeField]
    private Camera cam;
    [SerializeField] TMP_Text _text;
    [SerializeField] GameObject _panel;
    public Button closeButton;

    void Start ()
    {
        Button closeBtn = closeButton.GetComponent<Button>();
		closeBtn.onClick.AddListener(CloseOnClick);
    }    

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {  
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            Physics.Raycast(ray, out hit, 100.0f);    
            if(hit.transform != null)
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                clickable?.Click();
            }
            else
            {
                //_panel.gameObject.SetActive(false); 
            }
        }
        
    }

    private void CloseOnClick()
    {
        _panel.gameObject.SetActive(false); 
    }

    public void Click()
    {
        OpenText();     
    }

    public void OpenText()
    {
        if(_text != null)
        {
             _text.text = $"{gameObject.name}";
            _panel.gameObject.SetActive(true);           
        }
    }
}
