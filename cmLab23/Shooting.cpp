#include <cmath>
#include <iostream>
#include "Shooting.h"

void Test_2() {
    double x_0 = 0, x_n = 1, h = 0.1,
            y_0 = 0, y_n = 2.71828, eps = 1e-3;

    double ans = Shooting(x_0, x_n, h, y_0, y_n, eps);
}

double f(const double& x, const double& y, const double& y_der) {
    return 2*y_der + y - 2*x*std::exp(x);
}

double Shooting(const double& x_0, const double& x_n, const double& h,
                const double& y_0, const double& y_n, const double& eps) {
    double x = x_0, y = y_0, tmp = 0, z = (y_n-y_0)/(x_n-x_0),
            alpha = std::atan(z), alpha_low = -M_PI_2, alpha_high = M_PI_2;

    std::cout << "Shooting method" << std::endl;

    for(int i = 1; std::fabs(y-y_n) > eps; i++) {
        if(i > 1) {
            if (y > y_n) {
                alpha_high = alpha;
            } else {
                alpha_low = alpha;
            }
            alpha = (alpha_low+alpha_high)/2;
        }
        x = x_0;
        y = y_0;
        z = std::tan(alpha);

        std::cout << "Cycle #" << i << std::endl;
        std::cout << "Alpha=" << alpha << std::endl;
        std::cout << "i | x | y" << std::endl;
        std::cout << 0 << " | " << x << " | " << y << std::endl;

        for(int j = 1; x + h <= x_n; j++) {
            tmp = y + h * z;
            z += h * f(x, y, z);
            y = tmp;
            x += h;
            std::cout << 0 << " | " << x << " | " << y << std::endl;
        }
    }

    return y;
}