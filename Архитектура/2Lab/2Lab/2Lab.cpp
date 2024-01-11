//#include <iostream>
//#include <omp.h>
//#include <clocale>
//#include <stdio.h>
//using namespace std;
//int main(int agrc, char* argv[])
//{
//	setlocale(LC_ALL, "ru");
//	double ch1, ch2, ch;
//	cout << "Введите 2 числа: ";
//	cin >> ch1 >> ch2;
//	const int kolvo = 10;
//	double start = omp_get_wtime();
//	for (int i = 0; i < 1000000000; i++)
//		ch = ch1 * ch2;
//	double end = omp_get_wtime();
//	printf("Затраченное время: %lf\n", end - start);
//}
//#include <iostream>
//#include <omp.h>
//#include <clocale>
//
//using namespace std;
//
//int main(int argc, char* argv[]) {
//    setlocale(LC_ALL, "ru");
//    double ch1, ch2;
//
//    cout << "Введите 2 числа: ";
//    cin >> ch1 >> ch2;
//
//    const int kolvo = 1000000000;
//    double start = omp_get_wtime();
//
//#pragma omp parallel for
//    for (int i = 0; i < kolvo; i++) {
//        double ch = ch1 * ch2; // избыточное умножение
//    }
//
//    double end = omp_get_wtime();
//    printf("Затраченное время: %lf\n", end - start);
//
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//#include <clocale>
//#include <stdio.h>
//using namespace std;
//int main(int agrc, char* argv[])
//{
//	setlocale(LC_ALL, "ru");
//	double ch = 0, ch1_1 = 0, ch1_2 = 0, ch2_1 = 0, ch2_2 = 0;
//	printf_s("Введите 2 числа: ");
//	scanf_s("%d%d", &ch1_1, &ch2_1);
//
//		int i = 0;
//	const int N = 1000000000;
//	double start, end;
//#pragma omp parallel private(i,ch,ch1_2,ch2_2) num_threads(6)
//	{
//		ch1_2 = ch1_1;
//		ch2_2 = ch2_1;
//#pragma omp master
//		{
//			start = omp_get_wtime();
//		}
//#pragma omp for
//		for (i = 0; i < N; i++)
//			ch = ch1_2 * ch2_2;
//#pragma omp master
//		{
//			end = omp_get_wtime();
//			printf("Затраченное время: %lf\n", end - start);
//		}
//	}
//	return 0;
//}
//#include <iostream>
//#include <omp.h>
//#include <clocale>
//
//using namespace std;
//
//int main() {
//    setlocale(LC_ALL, "ru");
//
//    double num1, num2, result;
//
//    cout << "Введите 2 числа: ";
//    cin >> num1 >> num2;
//
//    const int iterations = 1000000000;
//    double start, end;
//
//#pragma omp parallel num_threads(6)
//    {
//        double localNum1 = num1;
//        double localNum2 = num2;
//
//#pragma omp master
//        start = omp_get_wtime();
//
//#pragma omp for
//        for (int i = 0; i < iterations; i++)
//            result = localNum1 * localNum2;
//
//#pragma omp master
//        end = omp_get_wtime();
//    }
//
//    printf("Затраченное время: %lf\n", end - start);
//
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//
//int main() {
//    double startTime = omp_get_wtime();
//
//#pragma omp parallel
//    {
//        // Пустая параллельная область
//    }
//
//    double endTime = omp_get_wtime();
//
//    printf("Время выполнения пустой параллельной области: %f секунд\n", endTime - startTime);
//
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//
//int main() {
//    setlocale(LC_ALL, "ru");
//    double startTime = omp_get_wtime();
//
//#pragma omp parallel
//    {
//       
//    }
//
//    double endTime = omp_get_wtime();
//
//    printf("Время выполнения пустой параллельной области: %f секунд\n", endTime - startTime);
//
//    return 0;
//}
//#include <omp.h>
//#include <iostream>
//#include<clocale>
//using namespace std;
//int main() {
//	setlocale(LC_ALL, "ru");
//	int ThreadId;
//	omp_set_num_threads(3);
//#pragma omp parallel
//	{
//		ThreadId = omp_get_thread_num();
//#pragma omp single nowait
//		cout << "Начало №" << ThreadId + 1 << endl;
//#pragma omp single nowait
//		cout << "Одна нить №" << ThreadId + 1 << endl;
//#pragma omp single nowait
//		cout << "Конец №" << ThreadId + 1 << endl;
//#pragma omp barrier
//	}
//	cout << "\n";
//#pragma omp parallel
//	{
//		ThreadId = omp_get_thread_num();
//#pragma omp single nowait
//		cout << "Начало №" << ThreadId + 1 << endl;
//#pragma omp single nowait
//		cout << "Одна нить №" << ThreadId + 1 << endl;
//#pragma omp single nowait
//		cout << "Конец №" << ThreadId + 1 << endl;
//	}
//	return 0;
//}
//#include <iostream>
//#include <omp.h>
//
//int main() {
//    setlocale(LC_ALL, "ru");
//    std::cout << "Основная область: Начало" << std::endl;
//
//#pragma omp parallel num_threads(3)
//    {
//        int threadNum = omp_get_thread_num();
//        std::cout << "Параллельная область: Начало нити " << threadNum << std::endl;
//
//#pragma omp critical
//        {
//           
//            if (threadNum == 1) {
//                std::cout << "Одна нить: Нить " << threadNum << std::endl;
//            }
//        }
//#pragma omp barrier
//#pragma omp critical
//        {
//            std::cout << "Параллельная область: Окончание нити " << threadNum << std::endl;
//        }
//
//    } 
//
//    std::cout << "Основная область: Окончание" << std::endl;
//
//    return 0;
//}
//#include <omp.h>
//#include <iostream>
//#include <clocale>
//using namespace std;
//int main()
//{
//	setlocale(LC_ALL, "ru");
//	int ThreadId;
//	omp_set_num_threads(3);
/////#pragma  parallel private(ThreadId)
//	{
//		ThreadId = omp_get_thread_num();
//		cout << "Начало №" << ThreadId + 1 << endl;
//#pragma omp barrier
//#pragma omp master
//		{
//			cout << "Главный поток №" << ThreadId + 1 << endl;
//			cout << "Главный поток №" << ThreadId + 1 << endl;
//		}
//#pragma omp barrier
//		cout << "Середина №" << ThreadId + 1 << endl;
//#pragma omp barrier
//#pragma omp master
//		{
//			cout << "Главный поток №" << ThreadId + 1 << endl;
//			cout << "Главный поток №" << ThreadId + 1 << endl;
//		}
//#pragma omp for
//		for (int i = 0; i < 3; i++)
//			cout << "Конец №" << ThreadId + 1 << endl;
//	}
//	return 0;
//}

//#include <omp.h>
//#include <iostream>
//#include <clocale>
//
//int main() {
//    setlocale(LC_ALL, "ru");
//
//#pragma omp parallel num_threads(3)
//    {
//        int ThreadId = omp_get_thread_num();
//        std::cout << "Начало №" << ThreadId + 1 << std::endl;
//
//#pragma omp barrier
//
//#pragma omp master
//        {
//            std::cout << "Главный поток №" << ThreadId + 1 << std::endl;
//            std::cout << "Главный поток №" << ThreadId + 1 << std::endl;
//        }
//
//#pragma omp barrier
//
//        std::cout << "Середина №" << ThreadId + 1 << std::endl;
//
//#pragma omp barrier
//
//#pragma omp master
//        {
//            std::cout << "Главный поток №" << ThreadId + 1 << std::endl;
//            std::cout << "Главный поток №" << ThreadId + 1 << std::endl;
//        }
//
//#pragma omp for
//        for (int i = 0; i < 3; i++)
//            std::cout << "Конец №" << ThreadId + 1 << std::endl;
//    }
//
//    return 0;
//}
//#include <omp.h>
//#include <clocale>
//#include <iostream>
//using namespace std;
//int main()
//{
//	setlocale(LC_ALL, "ru");
//	int ThreadId, n = 10;
//#pragma omp parallel private(ThreadId,n) num_threads(2)
//	{
//		n = 10;
//		ThreadId = omp_get_thread_num();
//		cout << "Параллельная область №" << ThreadId + 1 << " n=" << n << endl;
//#pragma omp barrier
//		n = omp_get_thread_num();
//		cout << "Параллельная область №" << ThreadId + 1 << " n=" << n << endl;
//#pragma omp barrier
//	}
//	cout << "Последовательная область n=" << n << endl;
//	return 0;
//}
//#include <iostream>
//#include <omp.h>
//
//int main() {
//    setlocale(LC_ALL, "ru");
//
//    const int size = 5;
//    int m[size] = { 0 };
//
//    std::cout << "Последовательная область: Исходный массив m: ";
//    for (int i = 0; i < size; ++i) {
//        std::cout << m[i] << " ";
//    }
//    std::cout << std::endl;
//
//#pragma omp parallel num_threads(2) shared(m)
//    {
//        int threadNum = omp_get_thread_num();
//
//        
//        m[threadNum] = 1;
//
//#pragma omp barrier  
//
//#pragma omp master
//        {
//            std::cout << "Параллельная область: Измененный массив m: ";
//            for (int i = 0; i < size; ++i) {
//                std::cout << m[i] << " ";
//            }
//            std::cout << std::endl;
//        }
//    } // Конец параллельной области
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//
//int main() {
//    setlocale(LC_ALL, "ru");
//
//    int totalThreads = 0;
//
//#pragma omp parallel reduction(+:totalThreads)
//    {
//        int threadNum = omp_get_thread_num();
//
//        // Редуцируемая переменная увеличивается на 1 для каждой нити
//        totalThreads += 1;
//
//        std::cout << "Номер потока: " << threadNum << std::endl;
//    } // Конец параллельной области
//
//    // После завершения параллельной области выводим общее количество нитей
//    std::cout << "Всего потоков:  " << totalThreads << std::endl;
//
//    return 0;
//}

//#include <omp.h>
//#include <iostream>
//#include <emmintrin.h>
//
//using namespace std;
//
//int main()
//{
//    setlocale(LC_ALL, "rus");
//
//    const int size = 4;
//    double a[size] = { 10.0, 20.0, 30.0, 40.0 };
//    double b[size] = { 1.5, 2.5, 3.5, 4.5 };
//    double c[size];
//
//    // Выполнение операций без SSE для типа double
//    double start_time = omp_get_wtime();
//    for (int i = 0; i < 1000000; i++) {
//        for (int j = 0; j < size; j++) {
//            c[j] = a[j] * b[j];
//        }
//    }
//    double elapsed_time = omp_get_wtime() - start_time;
//
//    cout << "Для типа double без SSE: " << elapsed_time << " сек." << endl;
//
//    // Вывод времени выполнения для double без SSE
//    for (int i = 0; i < size; i++) {
//        cout << "c[" << i << "] = " << c[i] << "\n";
//    }
//    cout << endl;
//
//    // Выполнение операций с SSE для типа double
//    start_time = omp_get_wtime();
//    __m128d xmm_a, xmm_b, xmm_c;
//    for (int i = 0; i < 1000000; i++) {
//        for (int j = 0; j < size; j += 2) {
//            xmm_a = _mm_loadu_pd(&a[j]);
//            xmm_b = _mm_loadu_pd(&b[j]);
//            xmm_c = _mm_mul_pd(xmm_a, xmm_b);
//            _mm_storeu_pd(&c[j], xmm_c);
//        }
//    }
//    elapsed_time = omp_get_wtime() - start_time;
//
//    // Вывод времени выполнения для double с SSE
//    cout << "Для типа double с SSE: " << elapsed_time << " сек." << endl;
//    for (int i = 0; i < size; i++) {
//        cout << "c[" << i << "] = " << c[i] << "\n";
//    }
//
//    return 0;
//}

#include <immintrin.h>
#include <omp.h>
#include <iostream>
#include <locale.h>


using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");

    // Для типа char
    char a[16] = { 10, 20, 30, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    char b[16] = { 1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    char c[16];

    // Выполнение операций без SSE для типа char
    double t = omp_get_wtime();
    for (int i = 0; i < 1000000; i++) {
        // Умножение элементов массивов a и b и сохранение результата в массив c
        for (int j = 0; j < 16; j++) {
            c[j] = a[j] * b[j];
        }
    }
    t = omp_get_wtime() - t;

    // Вывод времени выполнения для char без SSE
    cout << "Для типа char без SSE: " << t << " сек." << endl;
    for (int i = 0; i < 16; i++) {
        cout << "c[" << i << "] = " << static_cast<int>(c[i]) << "\n";
    }
    cout << endl;

    // Выполнение операций с SSE для типа char
    t = omp_get_wtime();
    for (int i = 0; i < 1000000; i++) {
        // Загрузка данных в регистры SSE и умножение
        __m128i xmm_a = _mm_load_si128((__m128i*)a);
        __m128i xmm_b = _mm_load_si128((__m128i*)b);
        __m128i xmm_c = _mm_mullo_epi16(xmm_a, xmm_b);
        // Сохранение результата в массив c
        _mm_store_si128((__m128i*)c, xmm_c);
    }
    t = omp_get_wtime() - t;

    // Вывод времени выполнения для char с SSE
    cout << "Для типа char с SSE: " << t << " сек." << endl;
    for (int i = 0; i < 16; i++) {
        cout << "c[" << i << "] = " << static_cast<int>(c[i]) << "\n";
    }

    return 0;
}










