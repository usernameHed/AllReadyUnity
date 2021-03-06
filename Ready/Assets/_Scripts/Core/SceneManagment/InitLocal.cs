﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitLocal : SingletonMono<InitLocal>
{
    public virtual void InitScene()
    {
        Debug.Log("init local");
        //GameManager.Instance.Init
    }

    public void Play()
    {
        SceneManagerLocal.Instance.PlayNext();
    }

    public void Previous()
    {
        SceneManagerLocal.Instance.PlayPrevious();
    }

    public void PlayIndex(int index)
    {
        SceneManagerLocal.Instance.PlayIndex(index);
    }

    public void Quit()
    {
        SceneManagerLocal.Instance.Quit();
    }
}
