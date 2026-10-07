using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  public void ChangeScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
  }

  public void GotoStart()
  {
    SceneManager.LoadScene("Start");
  }
}