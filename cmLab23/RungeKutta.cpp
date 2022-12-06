#include <iostream>
#include <iomanip>
#include "RungeKutta.h"

double f(const double& x, const double& y) {
    return 0.4*y - 0.002*x*(1 - 0.2*x);
}

void Test_1() {
    double x_0 = 0, x_n = 1,
            h = 0.1, y_0 = 1;

    double ans1 = RungeKutta_3(x_0, x_n, h, y_0);
    double ans2 = RungeKutta_4(x_0, x_n, h, y_0);
}

double RungeKutta_3(const double& x_0, const double& x_n, const double& h, const double& y_0) {
    double y = y_0, x = x_0,
            k_1 = 0, k_2 = 0, k_3 = 0;
    std::cout << "Runge-Kutta 3koef" << std::endl;
    std::cout << "i | x | y" << std::endl;
    std::cout << 0 << " | " << x << " | " << y << std::endl;
    for(int i = 0; x + h <= x_n; i++) {
        k_1 = h*f(x, y);
        k_2 = h*f(x + h/2, y + k_1/2);
        k_3 = h*f(x + h, y - k_1 + 2*k_2);
        y += 1./6*(k_1 + 4*k_2 + k_3);
        x += h;
        std::cout << i + 1 << " | " << x << " | " << std::setprecision(10) << y << std::endl;
    }

    return y;
}

double RungeKutta_4(const double& x_0, const double& x_n, const double& h, const double& y_0) {
    double y = y_0, x = x_0,
            k_1 = 0, k_2 = 0, k_3 = 0, k_4 = 0;
    std::cout << "Runge-Kutta 4koef" << std::endl;
    std::cout << "i | x | y" << std::endl;
    std::cout << 0 << " | " << x << " | " << y << std::endl;
    for(int i = 0; x + h <= x_n; i++) {
        k_1 = h*f(x, y);
        k_2 = h*f(x + h/2, y + k_1/2);
        k_3 = h*f(x + h/2, y + k_2/2);
        k_4 = h*f(x + h, y + k_3);
        y += 1./6*(k_1 + 2*k_2 + 2*k_3 + k_4);
        x += h;
        std::cout << i + 1 << " | " << x << " | " << std::setprecision(10) << y << std::endl;
    }

    return y;
}