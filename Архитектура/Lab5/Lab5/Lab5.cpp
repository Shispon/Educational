//#include <omp.h>
//#include <iostream>
//#include <vector>
//#include <ctime>
//#include <clocale>
//#include <iomanip>
//
//using namespace std;
//
//void sumVectors(const vector<int>& a, const vector<int>& b, vector<int>& c, int start, int end) {
//    for (int i = start; i < end; i++) {
//        c[i] = a[i] + b[i];
//    }
//}
//
//int main() {
//    setlocale(LC_ALL, "ru");
//    const int N = 100;
//    srand(time(NULL));
//
//    vector<int> a(N), b(N), c(N);
//    double time_start, time_end;
//
//    
//    for (int j = 0; j < N; j++) {
//        a[j] = rand();
//        b[j] = rand();
//    }
//
//#pragma omp parallel sections num_threads(3)
//    {
//     
//#pragma omp section
//        {
//            time_start = omp_get_wtime();
//            sumVectors(a, b, c, 0, N / 3);
//        }
//
//      
//#pragma omp section
//        {
//            sumVectors(a, b, c, N / 3, 2 * N / 3);
//        }
//
//     
//#pragma omp section
//        {
//            sumVectors(a, b, c, 2 * N / 3, N);
//            time_end = omp_get_wtime();
//        }
//    }
//
//
//    cout << "Вектор A:" << endl;
//    for (int j = 0; j < N; j++) {
//        cout << " " << a[j] << "  ";
//    }
//    cout << endl << endl;
//
//    cout << "Вектор B:" << endl;
//    for (int j = 0; j < N; j++) {
//        cout << " " << b[j] << "  ";
//    }
//    cout << endl << endl;
//
//    cout << "Вектор C (результат суммы):" << endl;
//    for (int j = 0; j < N; j++) {
//        cout << " " << c[j] << "  ";
//    }
//    cout << endl << endl;
//
//
//    cout << "Параллельный режим. Время: " << fixed << setprecision(6) << time_end - time_start << " секунд" << endl;
//
//    return 0;
//}
//#include <iostream>
//#include <omp.h>
//#include <cstdlib>
//#include <ctime>
//#include <clocale>
//
//using namespace std;
//
//void merge(int arr[], int l, int m, int r) {
//    int i, j, k;
//    int n1 = m - l + 1;
//    int n2 = r - m;
//    int* L = new int[n1];
//    int* R = new int[n2];
//
//    for (i = 0; i < n1; i++)
//        L[i] = arr[l + i];
//    for (j = 0; j < n2; j++)
//        R[j] = arr[m + 1 + j];
//
//    i = 0;
//    j = 0;
//    k = l;
//
//    while (i < n1 && j < n2) {
//        if (L[i] <= R[j]) {
//            arr[k] = L[i];
//            i++;
//        }
//        else {
//            arr[k] = R[j];
//            j++;
//        }
//        k++;
//    }
//
//    while (i < n1) {
//        arr[k] = L[i];
//        i++;
//        k++;
//    }
//
//    while (j < n2) {
//        arr[k] = R[j];
//        j++;
//        k++;
//    }
//
//    delete[] L;
//    delete[] R;
//}
//
//void mergeSortNested(int arr[], int l, int r) {
//    if (l < r) {
//        int m = l + (r - l) / 2;
//
//#pragma omp parallel sections num_threads(2)
//        {
//#pragma omp section
//            mergeSortNested(arr, l, m);
//
//#pragma omp section
//            mergeSortNested(arr, m + 1, r);
//        }
//
//        merge(arr, l, m, r);
//    }
//}
//
//void mergeSortNoNested(int arr[], int l, int r) {
//    if (l < r) {
//        int m = l + (r - l) / 2;
//
//        // Используем директиву single, чтобы запретить вложенный параллелизм
//#pragma omp single
//        {
//            mergeSortNoNested(arr, l, m);
//            mergeSortNoNested(arr, m + 1, r);
//        }
//
//        merge(arr, l, m, r);
//    }
//}
//
//int main() {
//    srand(time(0));
//    setlocale(LC_ALL, "ru");
//    int N;
//
//    cout << "Введите размер массива: ";
//    cin >> N;
//
//    int* arrNested = new int[N];
//    int* arrNoNested = new int[N];
//
//    for (int i = 0; i < N; i++) {
//        arrNested[i] = rand() % 100;
//        arrNoNested[i] = arrNested[i];
//    }
//
//    cout << "Неотсортированный массив: ";
//    for (int i = 0; i < N; i++) {
//        cout << arrNested[i] << " ";
//    }
//    cout << endl << endl;
//
//    double start, end;
//
//    // Последовательное выполнение
//    start = omp_get_wtime();
//    mergeSortNested(arrNested, 0, N - 1);
//    end = omp_get_wtime();
//
//    cout << "Отсортированный массив (вложенный параллелизм): ";
//    for (int i = 0; i < N; i++) {
//        cout << arrNested[i] << " ";
//    }
//    cout << endl;
//    cout << "Время последовательного выполнения: " << end - start << " секунд" << endl;
//
//    // Параллельное выполнение с вложенным параллелизмом
//    start = omp_get_wtime();
//    mergeSortNested(arrNested, 0, N - 1);
//    end = omp_get_wtime();
//    cout << "Время параллельного выполнения (вложенный параллелизм): " << end - start << " секунд" << endl;
//
//    // Параллельное выполнение без вложенного параллелизма
//    start = omp_get_wtime();
//    mergeSortNoNested(arrNoNested, 0, N - 1);
//    end = omp_get_wtime();
//    cout << "Отсортированный массив (без вложенного параллелизма): ";
//    for (int i = 0; i < N; i++) {
//        cout << arrNoNested[i] << " ";
//    }
//    cout << endl;
//    cout << "Время параллельного выполнения (без вложенного параллелизма): " << end - start << " секунд" << endl;
//
//    delete[] arrNested;
//    delete[] arrNoNested;
//
//    return 0;
//}
#include <iostream>
#include <omp.h>
#include <cstdlib>
#include <ctime>
#include <clocale>

using namespace std;

int partition(int arr[], int low, int high) {
    int pivot = arr[high];
    int i = (low - 1);

    for (int j = low; j < high; j++) {
        if (arr[j] <= pivot) {
            i++;
            swap(arr[i], arr[j]);
        }
    }

    swap(arr[i + 1], arr[high]);
    return (i + 1);
}

void quickSort(int arr[], int low, int high) {
    if (low < high) {
        int pi = partition(arr, low, high);

#pragma omp parallel sections
        {
#pragma omp section
            quickSort(arr, low, pi - 1);
#pragma omp section
            quickSort(arr, pi + 1, high);
        }
    }
}

int main() {
    srand(time(0));
    setlocale(LC_ALL, "ru");
    int N;

    cout << "Введите размер массива: ";
    cin >> N;

    int* arr = new int[N];
    for (int i = 0; i < N; i++) {
        arr[i] = rand() % 100;
    }

    cout << "Неотсортированный массив: ";
    for (int i = 0; i < N; i++) {
        cout << arr[i] << " ";
    }
    cout << endl << endl;

    double start, end;

    // Последовательное выполнение
    start = omp_get_wtime();
    quickSort(arr, 0, N - 1);
    end = omp_get_wtime();

    cout << "Отсортированный массив: ";
    for (int i = 0; i < N; i++) {
        cout << arr[i] << " ";
    }
    cout << endl << endl;

    cout << "Время последовательного выполнения: " << end - start << " секунд" << endl;

    // Параллельное выполнение с запрещенным вложенным параллелизмом
    omp_set_nested(0);
    start = omp_get_wtime();
    quickSort(arr, 0, N - 1);
    end = omp_get_wtime();

    cout << "Время параллельного выполнения с запрещенным вложенным параллелизмом: " << end - start << " секунд" << endl;

    // Параллельное выполнение с разрешенным вложенным параллелизмом
    omp_set_nested(1);
    start = omp_get_wtime();
    quickSort(arr, 0, N - 1);
    end = omp_get_wtime();

    cout << "Время параллельного выполнения с разрешенным вложенным параллелизмом: " << end - start << " секунд" << endl;

    delete[] arr;
    return 0;
}
