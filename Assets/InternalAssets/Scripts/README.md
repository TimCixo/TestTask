Код проекту написано з використанням архітектурного патерну MVP.

> [!example] Зміст
> - [Click](#Click)
> - [Movement](#Movement)
> - [Bootstrap](#Bootstrap)

# Click
---
Обробка натискань по ігровій сцені. Додання натискань в структуру даних для зберігання.

Поділяється на 4 скрипти у відповідності з патерном MVP:
- Manager - ініціалізація компонентів MVP;
- Model - збергіає набір точок, по яким рухається коло;
- View - оброблює натискання гравця по ігровій сцені;
- Presenter - реалізує роботу з точками.
# Movement
---
Переміщення кола по ігровій сцені.

Поділяється на 4 скрипти у відповідності з патерном MVP:
- Manager - ініціалізація компонентів MVP;
- Model - зберігає швидкість переміщення кола;
- View - оброблює зміну значеня slider;
- Presenter - реалізує переміщення кола. Зв'язок між Model та View.
# Bootstrap
---
Ініціалізація менеджерів у необхідній послідовності.

Не реалізується за паттерном MVP - є самостійним скриптом.