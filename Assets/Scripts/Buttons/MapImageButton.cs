using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapImageButton : MonoBehaviour, IClickAble
{
    [SerializeField] private Sprite[] _sprites;
    private int _curSprite;
    public bool IsClickable { get; set; } = true;
    public virtual void OnClicked(InteractHand interactHand)
    {
        ChangeSprite();
    }
    private void ChangeSprite()
    {
        _curSprite++;
        if (_curSprite > _sprites.Length - 1)
            _curSprite = 0;              
        GetComponent<Image>().sprite = _sprites[_curSprite];
    }

}