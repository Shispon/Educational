//#include <iostream>
//#include <omp.h>
//#include <ctime>
//
//using namespace std;
//
//int main()
//{
//    setlocale(LC_ALL, "Russian");
//    srand(time(NULL));
//
//    const int n = 5;
//    int A[n] = { 0 }, B[n] = { 0 }, C[n] = { 0 };
//
//    // Инициализация массива A
//    cout << "Матрица A:" << endl;
//#pragma omp parallel for
//    for (int i = 0; i < n; i++)
//    {
//        A[i] = 1 + rand() % 100;
//        cout << "\t" << A[i] << endl;
//    }
//
//    // Инициализация массива B
//    cout << "Матрица B:" << endl;
//#pragma omp parallel for
//    for (int i = 0; i < n; i++)
//    {
//        B[i] = 1 + rand() % 100;
//        cout << "\t" << B[i] << endl;
//    }
//    cout << endl;
//
//    // Сложение массивов A и B в массив C в параллельной области
//#pragma omp parallel for
//    for (int i = 0; i < n; i++)
//    {
//        C[i] = A[i] + B[i];
//        cout << "Номер нити:" << omp_get_thread_num() << ", номер элемента: " << i << endl;
//    }
//
//    // Вывод результирующего массива C
//    cout << endl << "Матрица C:" << endl;
//    for (int i = 0; i < n; i++)
//        cout << "\t" << C[i] << endl;
//
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//#include <clocale>
//#include <stdio.h>
//#include <ctime>
//
//using namespace std;
//
//int main()
//{
//    setlocale(LC_ALL, "ru");
//    srand(time(NULL));
//    const int n = 100;
//    int A[n] = { 0 }, B[n] = { 0 };
//    int i = 0, sum = 0;
//    cout << "Матрица A:" << endl;
//    for (i = 0; i < n; i++)
//    {
//        A[i] = 1 + rand() % 100;
//        cout << "\t" << A[i];
//    }
//    cout << endl << endl << "Матрица B:" << endl;
//    for (i = 0; i < n; i++)
//    {
//        B[i] = 1 + rand() % 100;
//        cout << "\t" << B[i];
//    }
//    cout << endl;
//
//    // Используем reduction для переменной sum
//#pragma omp parallel for reduction(+:sum)
//    for (i = 0; i < n; i++)
//        sum += A[i] * B[i];
//
//    cout << endl << "Результат суммы произведений: " << sum << endl;
//
//    return 0;
//}

//#include <iostream>
//#include <omp.h>
//#include <clocale>
//#include <stdio.h>
//#include <ctime>
//
//using namespace std;
//
//int** createMatrix(int size) {
//    int** matrix = new int* [size];
//    for (int i = 0; i < size; i++)
//        matrix[i] = new int[size];
//
//    for (int i = 0; i < size; i++)
//        for (int j = 0; j < size; j++)
//            matrix[i][j] = 1 + rand() % 1000;
//
//    return matrix;
//}
//
//void printMatrix(int** matrix, int size) {
//    cout << " Матрица:" << endl;
//    for (int i = 0; i < size; i++) {
//        cout << "\t";
//        for (int j = 0; j < size; j++)
//            cout << matrix[i][j] << " ";
//        cout << endl;
//    }
//}
//
//void deleteMatrix(int** matrix, int size) {
//    for (int i = 0; i < size; i++)
//        delete[] matrix[i];
//    delete[] matrix;
//}
//
//int main()
//{
//    setlocale(LC_ALL, "ru");
//    srand(time(nullptr));
//    const int matrixSize = 3;
//    int** matrixA;
//    int vectorB[matrixSize] = { 0 }, resultVector[matrixSize] = { 0 };
//
//    matrixA = createMatrix(matrixSize);
//
//    for (int i = 0; i < matrixSize; i++)
//        vectorB[i] = 1 + rand() % 100;
//
//    printMatrix(matrixA, matrixSize);
//
//    cout << endl << " Вектор B:" << endl;
//    for (int i = 0; i < matrixSize; i++)
//        cout << "\tB[" << i << "] = " << vectorB[i] << endl;
//
//    cout << endl;
//
//    omp_set_nested(1);
//
//#pragma omp parallel for schedule(static) collapse(2)
//    for (int i = 0; i < matrixSize; i++) {
//        for (int j = 0; j < matrixSize; j++) {
//            resultVector[i] += matrixA[i][j] * vectorB[j];
//            cout << " Номер потока: " << omp_get_thread_num() << ", индекс: " << i << ", значение: " << resultVector[i] << endl;
//        }
//    }
//
//    cout << endl << " Итоговый вектор:" << endl;
//    for (int i = 0; i < matrixSize; i++)
//        cout << "\tResult[" << i << "] = " << resultVector[i] << endl;
//
//    deleteMatrix(matrixA, matrixSize);
//
//    return 0;
//}


#include <iostream>
#include <omp.h>
#include <clocale>

using namespace std;

int main() {
    setlocale(LC_ALL, "ru");

    const int n = 11;

    omp_set_nested(1);

#pragma omp parallel for ordered
    for (int i = 1; i < n; i++) {
#pragma omp ordered
        {
#pragma omp parallel for ordered num_threads(10)
            for (int j = 1; j < n; j++) {
#pragma omp ordered
                cout << "Номер потока: " << omp_get_thread_num() << " | " << i << " * " << j << " = " << i * j << endl;
            }
            cout << endl;
        }
    }

    return 0;
}



