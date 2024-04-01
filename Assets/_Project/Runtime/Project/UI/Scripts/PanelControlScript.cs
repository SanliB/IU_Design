using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using DG.DOTweenEditor.UI;
using DG.Tweening;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class PanelControlScript : MonoBehaviour
{
    public Button Inventory;
    public CanvasGroup SceneOne;
    public RectTransform Head;
    public RectTransform RightBody;
    public RectTransform LeftBody;
    public RectTransform Foot;
    public GameObject SceneTwo;
    public GameObject Foot1;
    public GameObject SceneThree;
    public GameObject Select;
    public RectTransform SelectBorder;
    public GameObject SceneFour;
    public GameObject Ellips;
    public GameObject Info;
    public Image Potion;


    public void OnClickInventory()
    {
        Head.DOAnchorPosY(430, 0.3f);
        RightBody.DOAnchorPosX(300, 0.3f);
        LeftBody.DOAnchorPosX(-300, 0.3f);
        Foot.DOAnchorPosY(-300, 0.3f).OnComplete((() =>
        {
            SceneTwo.SetActive(true);
            
        }));
        
    }

    public void OnClickPotion()
    {
        Foot1.SetActive(false);
        Select.SetActive(true);
        SelectBorder.DOScale(1.1f, 0.5f).SetLoops(-1, LoopType.Yoyo);
        SceneThree.SetActive(true);
        Potion.enabled = true;
    }

    public void OnClickCraft()
    {
        SceneFour.SetActive(true);
        Ellips.SetActive(false);
        Info.SetActive(false);
    }

}
