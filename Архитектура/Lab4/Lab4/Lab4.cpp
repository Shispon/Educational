//#include <iostream>
//#include <omp.h>
//#include <ctime>
//#include <cmath>
//
//void computeIntegral(double a, double b, double epsilon, double timeStart)
//{
//    int count = 0;
//    double presentF = 0, nextF = 0, height = 0;
//
//    while (1)
//    {
//        if (!count)
//        {
//            count = 1;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:presentF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + (i * height);
//                presentF += sqrt(1 + 0.5 * x + log(x) * log(x)); 
//            }
//            presentF *= height;
//        }
//        else
//        {
//            count *= 2;
//            nextF = 0;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:nextF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + (i * height);
//                nextF += sqrt(1 + 0.5 * x + log(x) * log(x)); 
//            }
//            nextF *= height;
//
//            if (fabs((nextF - presentF)) <= epsilon)
//            {
//                std::cout << "Точность: " << epsilon << " знаков" << std::endl;
//                std::cout << "Общее количество итераций: " << count << std::endl;
//                std::cout << "Время вычисления значения: " << (omp_get_wtime() - timeStart) << " секунды" << std::endl;
//                break;
//            }
//            else
//            {
//                presentF = nextF;
//            }
//        }
//    }
//}
//
//int main()
//{
//    double a = 1.0;
//    double b = 3.0;
//    double epsilon[] = { 1e-5, 1e-6, 1e-7 };
//
//    setlocale(LC_ALL, "Russian");
//    srand(time(NULL));
//
//    for (int i = 0; i < 3; ++i)
//    {
//        std::cout << "Метод левых прямоугольников:" << std::endl;
//        double timeStart = omp_get_wtime();
//        computeIntegral(a, b, epsilon[i], timeStart);
//        std::cout << std::endl;
//    }
//
//    return 0;
//}

//#include <iostream>
//#include <omp.h>
//#include <cmath>
//#include <ctime>
//
//void computeIntegral(double a, double b, double epsilon, double timeStart);
//
//int main()
//{
//    double a = 1.0;
//    double b = 3.0;
//    double epsilon[] = { 1e-5, 1e-6, 1e-7 };
//
//    setlocale(LC_ALL, "Russian");
//
//    for (int i = 0; i < 3; ++i)
//    {
//        std::cout << "Метод правых прямоугольников:" << std::endl;
//        double timeStart = omp_get_wtime();
//        computeIntegral(a, b, epsilon[i], timeStart);
//        std::cout << std::endl;
//    }
//
//    return 0;
//}
//
//void computeIntegral(double a, double b, double epsilon, double timeStart)
//{
//    int count = 0;
//    double presentF = 0, nextF = 0, height = 0;
//
//    while (1)
//    {
//        if (!count)
//        {
//            count = 1;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:presentF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + ((i + 1) * height);
//                presentF += sqrt(1 + 0.5 * x + log(x) * log(x)); // ваша функция
//            }
//            presentF *= height;
//        }
//        else
//        {
//            count *= 2;
//            nextF = 0;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:nextF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + ((i + 1) * height);
//                nextF += sqrt(1 + 0.5 * x + log(x) * log(x)); // ваша функция
//            }
//            nextF *= height;
//
//            if (fabs((nextF - presentF)) <= epsilon)
//            {
//                std::cout << "Точность: " << epsilon << " знаков" << std::endl;
//                std::cout << "Общее количество итераций: " << count << std::endl;
//                std::cout << "Время вычисления значения: " << (omp_get_wtime() - timeStart) << " секунды" << std::endl;
//                break;
//            }
//            else
//            {
//                presentF = nextF;
//            }
//        }
//    }
//}

//#include <iostream>
//#include <omp.h>
//#include <cmath>
//#include <ctime>
//
//void computeIntegral(double a, double b, double epsilon, double timeStart);
//
//int main()
//{
//    double a = 1.0;
//    double b = 3.0;
//    double epsilon[] = { 1e-5, 1e-6, 1e-7 };
//
//    setlocale(LC_ALL, "Russian");
//
//    for (int i = 0; i < 3; ++i)
//    {
//        std::cout << "Метод средних прямоугольников:" << std::endl;
//        double timeStart = omp_get_wtime();
//        computeIntegral(a, b, epsilon[i], timeStart);
//        std::cout << std::endl;
//    }
//
//    return 0;
//}
//
//void computeIntegral(double a, double b, double epsilon, double timeStart)
//{
//    int count = 0;
//    double presentF = 0, nextF = 0, height = 0;
//
//    while (1)
//    {
//        if (!count)
//        {
//            count = 1;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:presentF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + (i * height) + (height / 2);
//                presentF += sqrt(1 + 0.5 * x + log(x) * log(x)); // ваша функция
//            }
//            presentF *= height;
//        }
//        else
//        {
//            count *= 2;
//            nextF = 0;
//            height = (b - a) / count;
//#pragma omp parallel for reduction(+:nextF)
//            for (int i = 0; i < count; i++)
//            {
//                double x = a + (i * height) + (height / 2);
//                nextF += sqrt(1 + 0.5 * x + log(x) * log(x)); // ваша функция
//            }
//            nextF *= height;
//
//            if (fabs((nextF - presentF)) <= epsilon)
//            {
//                std::cout << "Точность: " << epsilon << " знаков" << std::endl;
//                std::cout << "Общее количество итераций: " << count << std::endl;
//                std::cout << "Время вычисления значения: " << (omp_get_wtime() - timeStart) << " секунды" << std::endl;
//                break;
//            }
//            else
//            {
//                presentF = nextF;
//            }
//        }
//    }
//}
//#include <iostream>
#include <iostream>
#include <omp.h>
#include <cmath>
#include <ctime>

void computeIntegral(double a, double b, double epsilon, double timeStart);

int main()
{
    double a = 1.0;
    double b = 3.0;
    double epsilon[] = { 1e-5, 1e-6, 1e-7 };

    setlocale(LC_ALL, "Russian");

    for (int i = 0; i < 3; ++i)
    {
        std::cout << "Метод Симпсона:" << std::endl;
        double timeStart = omp_get_wtime();
        computeIntegral(a, b, epsilon[i], timeStart);
        std::cout << std::endl;
    }

    return 0;
}

void computeIntegral(double a, double b, double epsilon, double timeStart)
{
    int count = 0;
    double presentF = 0, nextF = 0, height = 0;

    while (1)
    {
        if (!count)
        {
            count = 1;
            height = (b - a) / count;
#pragma omp parallel for reduction(+:presentF)
            for (int i = 0; i < count; i++)
            {
                double x1 = a + i * height;
                double x2 = a + (i + 1) * height;
                double x3 = (x1 + x2) / 2;
                presentF += (sqrt(1 + 0.5 * x1 + log(x1) * log(x1)) + 4 * sqrt(1 + 0.5 * x3 + log(x3) * log(x3)) + sqrt(1 + 0.5 * x2 + log(x2) * log(x2))) / 6;
            }
            presentF *= height;
        }
        else
        {
            count *= 2;
            nextF = 0;
            height = (b - a) / count;
#pragma omp parallel for reduction(+:nextF)
            for (int i = 0; i < count; i++)
            {
                double x1 = a + i * height;
                double x2 = a + (i + 1) * height;
                double x3 = (x1 + x2) / 2;
                nextF += (sqrt(1 + 0.5 * x1 + log(x1) * log(x1)) + 4 * sqrt(1 + 0.5 * x3 + log(x3) * log(x3)) + sqrt(1 + 0.5 * x2 + log(x2) * log(x2))) / 6;
            }
            nextF *= height;

            if (fabs((nextF - presentF)) <= epsilon)
            {
                std::cout << "Точность: " << epsilon << " знаков" << std::endl;
                std::cout << "Общее количество итераций: " << count << std::endl;
                std::cout << "Время вычисления значения: " << (omp_get_wtime() - timeStart) << " секунды" << std::endl;
                break;
            }
            else
            {
                presentF = nextF;
            }
        }
    }
}
