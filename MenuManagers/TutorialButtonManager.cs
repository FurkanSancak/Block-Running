using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    int i;

    public void Set(int _)
    {
        i = _;
    }

    public void OpenTutorial()
    {
        SceneManager.LoadScene(i);
    }
}
