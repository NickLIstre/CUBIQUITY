using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed;


    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)

        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
