using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class RotateAround : MonoBehaviour
{
    private static GameObject sphere;
    public float reversed;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        if (sphere == null)
        {
            sphere = GameObject.Find("Sphere");
        }
        if (Random.Range(0.0f, 1.0f) > .5f)
        {
            reversed = -1f;
        } else
        {
            reversed = 1f;
        }
        speed = Random.Range(5f, 15f);
        transform.GetChild(0).GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceTo = (sphere.transform.position - transform.position);
        speed = (distanceTo.magnitude - 1f) / (30f - 1f) * (15f - 5f) + 5f;
        transform.LookAt(sphere.transform.position);
        transform.position = transform.position + (speed * transform.right * reversed) * Time.deltaTime;
    }
}
