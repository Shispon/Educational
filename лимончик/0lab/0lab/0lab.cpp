#include <iostream>
using namespace std;

double quadr(double a, double b, double c)
{
    double D = b * b - 4 * a * c;
    return (-b + sqrt(D)) / 2 / a;
}

double Quadr(double a, double b, double c)
{
    double _2 = 2, _4 = 4;
    __asm {
        fld b
        fmul b
        fld _4
        fmul a
        fmul c
        fsub
        fsqrt
        fsub b
        fdiv _2
        fdiv a
    }
}
int main()
{
    double a = 1, b = -3, c = 1, x, X;
    x = quadr(a, b, c);
    X = Quadr(a, b, c);

    cout << x << "  " << X << endl;
}
