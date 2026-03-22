using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        int newScore = 1;

        Events.Changet?.Invoke(newScore);// Вызываем событие, теперь запустится метод UpdateInt. В скобках указываем то, что должны получить все кто подписан на событие
    }
}
