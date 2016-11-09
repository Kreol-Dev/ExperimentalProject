using UnityEngine;
using System.Collections;

public class BarsManager : MonoBehaviour
{

    public RectTransform RightBar;
    public RectTransform BottomBar;
    public RectTransform LeftBar;
    public RectTransform TopBar;
    UiObject uiTarget;
    public GameObject GetRightBar()
    {
        RightBar.gameObject.SetActive(true);
        var ui = RightBar.GetComponentInChildren<UiObject>();
        ui.ShowedObject = uiTarget.ShowedObject;
        return ui.gameObject;
    }

    public GameObject GetBottomBar()
    {
        BottomBar.gameObject.SetActive(true);
        var ui = BottomBar.GetComponentInChildren<UiObject>();
        ui.ShowedObject = uiTarget.ShowedObject;
        return ui.gameObject;
    }

    public GameObject GetLeftBar()
    {
        LeftBar.gameObject.SetActive(true);
        var ui = LeftBar.GetComponentInChildren<UiObject>();
        ui.ShowedObject = uiTarget.ShowedObject;
        Debug.Log(ui);
        return ui.gameObject;
    }

    public GameObject GetTopBar()
    {
        TopBar.gameObject.SetActive(true);
        var ui = TopBar.GetComponentInChildren<UiObject>();
        ui.ShowedObject = uiTarget.ShowedObject;
        return ui.gameObject;
    }

    void Start()
    {
        uiTarget = GetComponent<UiObject>();
        RightBar.gameObject.SetActive(false);
        BottomBar.gameObject.SetActive(false);
        LeftBar.gameObject.SetActive(false);
        TopBar.gameObject.SetActive(false);
    }
    void Update()
    {
        if(BottomBar.gameObject.activeSelf)
        {
            if (RightBar.gameObject.activeSelf)
                BottomBar.offsetMax = new Vector2(-RightBar.sizeDelta.x, BottomBar.offsetMax.y);
            else
                BottomBar.offsetMax = new Vector2(0, BottomBar.offsetMax.y);
            if (LeftBar.gameObject.activeSelf)
                BottomBar.offsetMin = new Vector2(LeftBar.sizeDelta.x, BottomBar.offsetMin.y);
            else
                BottomBar.offsetMin = new Vector2(0, BottomBar.offsetMin.y);
        }

        if (TopBar.gameObject.activeSelf)
        {
            if (RightBar.gameObject.activeSelf)
                TopBar.offsetMax = new Vector2(-RightBar.sizeDelta.x, TopBar.offsetMax.y);
            else
                TopBar.offsetMax = new Vector2(0, TopBar.offsetMax.y);
            if (LeftBar.gameObject.activeSelf)
                TopBar.offsetMin = new Vector2(LeftBar.sizeDelta.x, TopBar.offsetMin.y);
            else
                TopBar.offsetMin = new Vector2(0, TopBar.offsetMin.y);
        }
        if(uiTarget.ShowedObject == null)
        {
            RightBar.gameObject.SetActive(false);
            BottomBar.gameObject.SetActive(false);
            LeftBar.gameObject.SetActive(false);
            TopBar.gameObject.SetActive(false);
        }
        
    }
}
