using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComlete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    private void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);

        GlobalCompleted.nextFloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", GlobalCompleted.nextFloor);
        PlayerPrefs.SetInt("LiveSave", GlobalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.handgumAmmo);


        yield return new WaitForSeconds(2f);
        completePanel.SetActive(true);

        yield return new WaitForSeconds(15);
        GlobalScore.scoreValue = 0;
        GlobalCompleted.enemyCount = 0;
        GlobalCompleted.treasureCount = 0;
        GlobalCompleted.nextFloor += 1;
        SceneManager.LoadScene(GlobalCompleted.nextFloor);

    }

}
