using System;
using System.Linq;

namespace VectoriSiConversii
{

    
    class MainClass
    {
        public static void Main(string[] args)
        {

            // 1.
            Console.WriteLine(@"1. Scrieti un program care stocheaza intr-un vector 3
variabile de tip double declarate de voi si le
afiseaza parcurgand vectorul");
            Console.WriteLine("vector = {2.4, 4.5, 6.8 }");
            double[] vector = { 2.4, 4.5, 6.8 };
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.WriteLine();

            // 2. Scrieti un program care afiseaza minimul , respectiv maximul dintr-un array de lungime 10.
            Console.WriteLine(@"2.  Scrieti un program care afiseaza minimul ,
respectiv maximul dintr-un array de lungime 10.");
            int[] minMaxArray = { 3, 54, 65, 67, 32, 97, 64, 70, 92, 18 };
            
            int min = minMaxArray.Min();
            int max = minMaxArray.Max();
            Console.WriteLine("Min: " + min + " and max: " + max);
            Console.WriteLine();


            // 3. execute
            Console.WriteLine(@"3. Scrieti o clasa ce declara un array de tip int
cu o singura valoare negativa si restul pozitive.
Afisati pozitia valorii negative din array ");
            int[] input = { 23, 45, 84, 57, 93, -24, 58, 95 };
            ArrayNegativeInt inputArray  = new ArrayNegativeInt(input);
            Console.WriteLine();

            // 4. execute
            Console.WriteLine(@"4. Scrieti o clasa ce transforma un String
intr-un array de caractere.");
            string str = "C# programming course";
            StringToArray strToArray = new StringToArray(str);
            Console.WriteLine();

            // 5. Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.
            Console.WriteLine(@"5. Transformati un sir de caractere astfel:
fiecare litera de pe pozitie para sa fie uppercase.");
            Console.WriteLine();
            string sirDeCaractere1 = "Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase";
            string sirDeCaractere = sirDeCaractere1.ToLower();
            string[] words = sirDeCaractere.Split(' ');
            foreach (string word in words)
            {
                char[] stringToChar = word.ToCharArray();
                
                for (int i = 0; i < stringToChar.Length; i++)
                {
                    if (i%2 !=0)
                    {
                        stringToChar[i] = Char.ToUpper(stringToChar[i]);
                       
                    }
                    
                }
                Console.WriteLine(new String(stringToChar));
                
            }
            Console.WriteLine();

            // 6. Avand un vector de numere intregi, adunati un nr double la valorile stocate si
            // pastrati rezultatul in alt vector corespunzator.
            Console.WriteLine(@"6. Avand un vector de numere intregi, adunati un nr double la valorile stocate si
pastrati rezultatul in alt vector corespunzator.");
            Console.WriteLine();

            int[] vectorNumereIntregi = { 1, 4, 5, 6, 67, 76, 93 };
            Console.WriteLine("Vectorul initial:");
            for (int i = 0; i < vectorNumereIntregi.Length; i++)
            {
                Console.Write(vectorNumereIntregi[i].ToString()+"\t");
            }
            double doubleNumber = 97.4;
            double[] vectorSumaDoubleInteger = new double[vectorNumereIntregi.Length];
            for(int i = 0; i < vectorNumereIntregi.Length; i++)
            {
                vectorSumaDoubleInteger[i] = vectorNumereIntregi[i] + doubleNumber;
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul dupa adunare:");
            for (int i = 0; i < vectorSumaDoubleInteger.Length; i++)
            {
                Console.Write(vectorSumaDoubleInteger[i].ToString() + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            // Avand un sir (string) de forma unei propozitii,
            //creati un vector care tine pe fiecare pozitie cate un cuvant din propozitie. 
            //Exemplu:
            // String prop = “Acesta este un exercitiu mai interesant”
            // -> v: “acesta” , “este” , “un” , “exercitiu”, “mai”, “interesant”.
            // Lungimea sirului v este 6 in acest exemplu.
            Console.WriteLine(@"7. Avand un sir (string) de forma unei propozitii,
creati un vector care tine pe fiecare pozitie cate un cuvant din propozitie. ");
            Console.WriteLine();

            string prop = "Acesta este un exercitiu mai interesant";
            string[] wordsInProp = prop.Split(' ');
            foreach (string word in wordsInProp)
            {
                Console.WriteLine(word);

            }
            Console.WriteLine("Lungimea sirului este: " + wordsInProp.Length);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(@"8.Complicati primul exercitiu suplimentar atfel: verificati daca lungimea
fiecare cuvant din sir este aceeasi pentru toate cuvintele,
iar daca conditia aceasta e adevarata creati un array bidimensional ce
contine array-uri de caractere corespunzatoare fiecarui cuvant.");
            Console.WriteLine();

            // Complicati primul exercitiu suplimentar atfel: verificati daca lungimea
            // fiecare cuvant din sir este aceeasi pentru toate cuvintele,
            // iar daca conditia aceasta e adevarata creati un array bidimensional ce
            // contine array-uri de caractere corespunzatoare fiecarui cuvant.
            // Exemplu: “Mara este bine”. 
            // matricea are atatea linii cate cuvinte sunt in propozitie si atatea coloane
            // cate litere au cuvintele din propozitie matrix:
            // linia 1: m a r a
            // linia 2: e s t e
            // linia 3: b i n e
            string sirDeCuvinte1 = "Mara este bine";
            string sirDeCuvinte2 = "Mara nu este bine";
            TestString(sirDeCuvinte1);
            TestString(sirDeCuvinte2);
            

            

        }

        static void TestString(String input)
        {
            string sirDeCaractere = input.ToLower();
            string[] arrayDeCaractere = sirDeCaractere.Split(' ');
            bool suntEgale = true;

            

            int lungime = arrayDeCaractere.Length;
            int coloane = arrayDeCaractere[0].Length;
            char[,] rezultat = new char[lungime, coloane];

            foreach (string word in arrayDeCaractere)
            {
                if (word.Length != coloane)
                {
                    suntEgale = false;
                    break;
                }
            }
            if(suntEgale)
            {
                for (int i = 0; i < lungime; i++)
                {
                    if (arrayDeCaractere[i].Length == coloane)
                    {
                        for (int j = 0; j < coloane; j++)
                        {
                            rezultat[i, j] = arrayDeCaractere[i].ElementAt(j);
                        }
                    }
                }
            }
            



            for (int i = 0; i < rezultat.GetLength(0); i++)
            {
                for (int j = 0; j < rezultat.GetLength(1); j++)
                {
                    Console.Write(rezultat[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
   

    

    // 3. Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa si restul pozitive.
    // Afisati pozitia valorii negative din array.
    class ArrayNegativeInt
    {
        public ArrayNegativeInt(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                {
                    Console.WriteLine("Index of negative integer is: {0}", input[i]);
                    break;
                }
            }
        }

    }

    // 4. Scrieti o clasa ce transforma un String intr-un array de caractere.
    class StringToArray
    {
        public StringToArray(string input)
        
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
       
        }
    }

}

