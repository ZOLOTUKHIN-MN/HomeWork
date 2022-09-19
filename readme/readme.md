# Описание решения
1. Объявление массива строк

 string[] array1 = new string[]{"Russia","Denmark","Kazan"};

2. Проверяем каждый элемент массива на условие >3, если да, то удаяем этот элемент из массива

for (int i = 0; i < array1.Length; i++) 

    {
        if (array1[i].Length > 3)
        {
            string strToRemove = array1[i];
            array1 = array1.Where(str => str != strToRemove).ToArray();
т.к. после удаления индекс элемента смещается на 1 влево, важно не пропустить проверку этого элемента, поэтому уменьшаем индекс проверяемого элемента на 1

            i -= 1;
        }
    }

3. Объявляем строку из элементов изменённого массива и выводим её на экран

var s = string.Join(", ", array1);
            Console.WriteLine(s);
            Console.ReadKey();