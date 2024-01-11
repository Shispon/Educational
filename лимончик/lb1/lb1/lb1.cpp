// lb1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <omp.h>

using namespace std;

//int main()
//{
//    setlocale(LC_ALL, "Russian"); 
//
//    auto t1 = omp_get_wtime();
//
//#pragma omp parallel
//    {
//       
//    }
//
//    auto t2 = omp_get_wtime();
//    double elapsed_time = t2 - t1;
//    cout << "Прошло времени: " << elapsed_time << " секунд" << endl;
//}

//int main()
//{
//    setlocale(LC_ALL, "Russian");
//
//    auto t1 = omp_get_wtime();
//
//#pragma omp parallel
//    {
//        #pragma omp single[nowait]
//        {
//
//        }
//    }
//
//    auto t2 = omp_get_wtime();
//    double elapsed_time = t2 - t1;
//    cout << "Прошло времени: " << elapsed_time << " секунд" << endl;


int main()
{
    setlocale(LC_ALL, "Russian");

    auto t1 = omp_get_wtime();
    int a = 5;
    #pragma omp parallel private(a)
    {
        int b = a * a;
    }

    auto t2 = omp_get_wtime();
    double elapsed_time = t2 - t1;
    cout << "Прошло времени: " << elapsed_time << " секунд" << endl;
}



