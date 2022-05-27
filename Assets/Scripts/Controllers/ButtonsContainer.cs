using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsContainer : MonoBehaviour
{
    public static ButtonsContainer Instance;
    private List<BaseObject> _buttons = new List<BaseObject>();
    private ButtonsContainer() { }
  
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void AddButton(BaseObject button)
    {
        _buttons.Add(button);
    }
    public void HideButtons()
    {
        foreach (var button in _buttons)
        {
            button.DisableObject();
        }
    }
}
