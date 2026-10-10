using UnityEngine;
using UnityEngine.UIElements;

public class Collectables : MonoBehaviour
{
    [SerializeField] private GameObject ClearScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("恭喜你，成功抵達終點！");
            ClearScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
