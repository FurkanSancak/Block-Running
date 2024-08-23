using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject tutorialList;

    public GameObject tutorialPrefab;
    public Sprite play;
    public Sprite locked;

    private bool tutorialListReady = false;

    List<GameObject> tutorials;

    public void OpenTutorialList()
    {
        menu.SetActive(false);
        tutorialList.SetActive(true);

        if (!tutorialListReady)
        {
            tutorials = new List<GameObject>();

            if (!File.Exists($"{Application.persistentDataPath}/tutorial.txt"))
            {
                FileStream tutorial = File.Create($"{Application.persistentDataPath}/tutorial.txt");
                tutorial.Write(new byte[8] { 1, 0, 0, 0, 0, 0, 0, 0 });
                tutorial.Close();
            }

            int x = -700;
            byte[] levels = File.ReadAllBytes($"{Application.persistentDataPath}/tutorial.txt");
            for (int i = 0; i < 8; i++)
            {
                GameObject _ = Instantiate(tutorialPrefab);
                tutorials.Add(_);
                if (levels[i] == 0)
                {
                    _.GetComponent<Image>().sprite = locked;
                }
                else
                {
                    _.GetComponent<Image>().sprite = play;

                    _.AddComponent<TutorialButton>();
                    _.GetComponent<TutorialButton>().Set(i + 1);

                    _.AddComponent<Button>();
                    _.GetComponent<Button>().onClick.AddListener(
                        () => _.GetComponent<TutorialButton>().OpenTutorial()
                        );
                }
                _.transform.SetParent(tutorialList.transform);
                _.transform.localPosition = new Vector3(x, 250, 0);
                x += 200;
            }
            tutorialListReady = true;
        }
    }

    public void CloseTutorialList()
    {
        menu.SetActive(true);
        tutorialList.SetActive(false);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
