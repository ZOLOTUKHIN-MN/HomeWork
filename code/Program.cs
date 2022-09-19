// string[] array1 = new string[]{"hello","2","world",":-)"};
// string[] array1 = new string[]{"1234","1567","-2","computer science"};
string[] array1 = new string[]{"Russia","Denmark","Kazan"};

for (int i = 0; i < array1.Length; i++) 
    {
        if (array1[i].Length > 3)
        {
            string strToRemove = array1[i];
            array1 = array1.Where(str => str != strToRemove).ToArray();
            i -= 1;
        }
    }

var s = string.Join(", ", array1);
            Console.WriteLine(s);
            Console.ReadKey();

