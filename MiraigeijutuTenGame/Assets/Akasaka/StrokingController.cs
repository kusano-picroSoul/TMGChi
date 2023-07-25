using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class StrokingController : PlayerPresenter
{
    private PlayerAnimation _playerAnimation;
    Animator _jump;
    HeartShop _heartShop;
    AddHeart _add;
    PlayerStatus _status;
    private void Start()
    {
        _jump = GetComponent<Animator>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _heartShop = GameObject.Find("System").GetComponent<HeartShop>();
        _add = GameObject.Find("Canvas/Heart").GetComponent<AddHeart>();
        _status = GetComponent<PlayerStatus>();
    }
    private void OnMouseDrag()
    {
        _playerAnimation.HappySprite();
    }
    private new void OnMouseUp()
    {
        _playerAnimation.NormalSprite();
        _jump.Play("JumpMotion");
        _status.Happy += 2;
        _add._heart += _heartShop._strokingAddHeart;
    }

}
