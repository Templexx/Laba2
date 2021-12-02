# Лабороторная работы №2

##### Вариант 3

Задание:

> Обнаружить все пары целых чисел, сумма которых равна заданному значению. 
```csharp
var inputData = new int[] { 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25 };
var check = 24;

// Результат выполнения
// 2, 22
// 4, 20
// 6, 18
// 9, 15
```

Первым делом нужно отсортировать наш массив по возрастанию. После сортировки массив будет следующего вида:

`{ 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25 }`

Теперь пойдем с начала (first) и с конца массива (last) и будем проверять сумму.

Соот-но чтобы найти второе слагаемое к fisrt будем двигать last к началу.

Если inputData[first] + inputData[last] < check, значит второго слагаемого для first нет (т.к. массив отсортирован) и мы двигаем first к концу, пока first < last.
