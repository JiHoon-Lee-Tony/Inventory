using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButton : UIPopup
{
    enum Buttons
    {
        ImageButton
    }
    enum Images
    {
        ItemIcon
    }
    public override void Init()
    {
        base.Init();

        Bind<Button>(typeof(Buttons));
        Bind<Image>(typeof(Images));

        // GetButton((int)Buttons.PointButton).gameObject.BindEvent(OnButtonClicked);
    }

    public void OnButtonClicked(PointerEventData data)
    {

    }
}
