List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> nelyginiai = list.Where(skaicius => skaicius % 2 != 0).ToList();

List<int> dalinasiIs5 = list.Where(x => x % 5 == 0).ToList();

bool arYra7 = list.Contains(7);

bool arVisiLyginiai = list.All(x => x % 2 == 0);

bool arBentVienasDalinasiIs8 = list.Any(x => x % 8 == 0);


List<int> listTwo = new List<int> {5, 6, 7 };


List<int> kvadratu = listTwo.Select(x => x * x).ToList();

int suma = listTwo.Sum();

double vidurkis = listTwo.Average(x => x);

Console.ReadKey();