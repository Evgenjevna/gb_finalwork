# FinalTask
## Задача : 
### *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*
## Описание алгоритма решения:
### После запуска, программа просит пользователя ввести массив строк с клавиатуры, разделяя элементы массива пробелами. После чего записывает введённые с клавиатуры данные в переменную **keyword**. Следующим действием программа преобразует переменную в массив строк **firstarray** используя пробел в качестве разделителя элементов массива.
### На основании массива **firstarray** создаётся массив **secondarray** с таким же количеством элементов. После чего метод **TransformArray** с помощью цикла, выполняет проверку условия (длина символов элемента массива <=3). В случае соблюдения условия, элемент первого массива заносится на место **carrent** (текущего) индекса элемента второго массива. После чего значение **carrent** индекса увеличивается на 1. Цикл выполняется до тех пор пока не будут перебраны все строковые элементы первого массива. По окончанию цикла метод **PrintArray** поэлементно выводит на печать строковые элементы массива **secondarray**.


### Блок-схема алгоритма представлена в файле *diagram.drawio* и *diagram.png*.
### Код программы представлен в файле *FinalTask.cs*