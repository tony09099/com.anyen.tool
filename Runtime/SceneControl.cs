using UnityEngine;
using UnityEngine.SceneManagement;

namespace anyen.tool
{
    /// <summary>
    /// 載入場景 離開遊戲
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">載入場景的名稱</param>
        public void LoadScene(string sceneName)
        {
            //場景管理器 載入場景
            SceneManager.LoadScene(sceneName);
        }
        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void QuitGame()
        {
            //關閉遊戲
            Application.Quit();
        }
    }
}
