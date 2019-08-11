using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace UnityAD
{
    public static class CoroutineToolMethods
    {
        public static IEnumerator AsyncLoadScene(string sceneName)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }
    }
}
