/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/

using UnityEngine;
using System.Collections;

public class BackgroundTextureAppManager : AppManager 
{
    public NegativeGrayscaleEffect m_Effect;
    private bool mCameraView;
    
    public override void InitManager ()
    {
        base.InitManager ();
        m_Effect.InitEffect();
    }
    
    public override void Draw()
    {
        base.Draw();
        switch(mActiveViewType)
        {
            case ViewType.SPLASHVIEW:
                mCameraView = false;
                break;
            case ViewType.ABOUTVIEW:
                mCameraView = false;
                break;
            case ViewType.UIVIEW:
                mCameraView = false;
                break;
            case ViewType.ARCAMERAVIEW:
                mCameraView = true; 
                break;
        }
    }

    public override void UpdateManager ()
    {
        base.UpdateManager();
        if(mCameraView) {
            m_Effect.UpdateEffect();
        }
    }
}
