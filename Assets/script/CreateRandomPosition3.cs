
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateRandomPosition3 : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    public static int dead = 0;
    private float time;
    private float frame;

    void start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく

        frame = frame + Time.deltaTime;
        if (frame > 1.0f)
        {
            time = time + 1;
            frame = 0f;
        }

        if (time == 2)
        {
            TinyAudio.PlaySE(TinyAudio.SE.Click);
            time = time + 1;
        }

        if (time == 17)
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);

            float y = Random.Range(rangeA.position.y, rangeB.position.y);

            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation,transform.parent);

            TinyAudio.PlaySE(TinyAudio.SE.Hit);
            time = time + 1;
        }

        if (time == 22 )
        {
            TinyAudio.PlaySE(TinyAudio.SE.Magic);
            time = time + 1;
            dead = dead - 1;
        }
        if (time == 24)
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
            TinyAudio.PlaySE(TinyAudio.SE.death);
            time = time + 1;
        }
    }
}