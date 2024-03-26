# FinalTestForTheMainBlock
## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Решение:
1. Задаю массив строк.
2. Инициализирую новый массив с размером первого массива. 
3. Задаю переменную, согласно условию задачи, равную 3 символам. 
4. Инициализирую цикл прохождения по элементам начального массива, в котором сортируются элементы с длиной 3 символа и меньше. 
5. Помещаю их в конечный массив. 
6. Распечатываю элементы начального и конечного массива.
