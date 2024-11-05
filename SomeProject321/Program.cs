string pathToRead = "C:\\Users\\prdb\\Desktop\\SomeProject321\\INPUT.txt";
StreamReader Reader = new StreamReader(pathToRead);

string pathToWrite = "C:\\Users\\prdb\\Desktop\\SomeProject321\\OUTPUT.txt";
StreamWriter Writer = new StreamWriter(pathToWrite,false);

int N = Convert.ToInt32(Reader.ReadLine());// размер матрицы
int[,] matrix = new int[N, N];

// заполнение
for (int i = 0; i < N; i++) 
{
    for (int j = 0; j < N; j++) 
    {
        int D = i + j + 1; // номер диагонали
        int M = (D * D + D) / 2 - ((D - N) * (D - N)) * (D / (N + 1)) - j * (D % 2)- i * ((D + 1) % 2);
        matrix[i, j] = M;
    }
}

// вывод
int count = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (count == N) 
        {
            count = 1;
            string str = Convert.ToString(matrix[i, j]);
            if (str.Length < 2)
            {
                str = $" {matrix[i, j]}";
            }
            Writer.Write("\n" + str + " ");
            Writer.Flush();
            Console.Write("\n" + str + " ");
        }
        else
        {
            count++;
            string str = Convert.ToString(matrix[i, j]);
            if (str.Length < 2) 
            {
                str = $" {matrix[i, j]}";
            }
            Writer.Write(str + " ");
            Writer.Flush();
            Console.Write(str + " ");
        }
    }
}