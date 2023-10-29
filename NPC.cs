using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float Speed = 1.5f;
        // Добавление хп
    public int Health = 100;
        // Добавление уровня
    public int Level = 1;
        // Изменения хп в зависимости от уровня
    // Start is called before the first frame update
    void Start()
    {
    Health += Level;
    print(Health);
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;


    }
}
