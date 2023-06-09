using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public int TotalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;

    private void Awake()
    {
        stageCountText.text = "/ "+ TotalItemCount;
    }


    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player" )
        {
            SceneManager.LoadScene(stage);
        }
    }
}
