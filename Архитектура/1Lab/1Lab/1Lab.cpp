#include <omp.h>
#include <iostream>
#include <string>
#include <clocale>

using namespace std;

int main() {
    setlocale(LC_ALL, "ru");

    int NumOfThreads;

    int entrance;
    cout << "Выберите режим\n1) parallel\n2) serial\n";
    cin >> entrance;

    if (entrance == 1) {
        cout << "Параллельный режим" << endl;

#pragma omp parallel
        {
            int ThreadId;
            ThreadId = omp_get_thread_num();
            NumOfThreads = omp_get_num_threads();
            printf("Поток номер %d из %d\n", ThreadId, NumOfThreads);
        }
    }
    else if (entrance == 2) {
        cout << "Последовательный режим" << endl;
    }
    else {
        cout << "Неверное выражение" << endl;
        return 1;
    }

    return 0;
}
