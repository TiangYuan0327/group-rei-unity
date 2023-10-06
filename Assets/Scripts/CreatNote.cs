using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatNote : MonoBehaviour
{
    public GameObject notePrefab; // 音符的预制体
    public Transform spawnPoint; // 音符生成的位置

    private float spawnTime = 2.0f; // 音符生成的时间间隔
    private float nextSpawnTime = 0.0f; // 下一个音符生成的时间

    private RectTransform canvasRect;

    private void Start()
    {
        canvasRect = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }
    void Update()
    {
        // 生成音符
        if (Time.time >= nextSpawnTime)
        {
            SpawnNote();
            nextSpawnTime = Time.time + spawnTime;
        }
    }

    void SpawnNote()
    {
        // 生成音符的逻辑，这里只是简单地实例化音符预制体并设置位置
        GameObject note = Instantiate(notePrefab, new Vector2(-450, 450), Quaternion.identity);
        note.transform.SetParent(canvasRect.transform, false);
    }
}
