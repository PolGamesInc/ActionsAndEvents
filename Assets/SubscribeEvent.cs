using UnityEngine;

public class SubscribeEvent : MonoBehaviour
{
    private void OnEnable()
    {
        Events.Changet += UpdateInt;// Подписка на событие созданное ранее, когда случится событие, будет вызван метод UpdateInt
    }

    private void OnDisable()
    {
        Events.Changet -= UpdateInt;// Отписка в случае несуществования объекта
    }

    private void UpdateInt(int score)
    {
        print(score);
    }
}
