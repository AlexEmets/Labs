#include <iostream>
#include <string>
#include <functional>
#include <vector>
#include <map>
#include <cctype>

using namespace std;

double RPNtoNumber(std::string expression) {
    map<char, function<double(const double&, const double&)>> operations;

    operations['+'] = [](double a, double b){return a+b;};
    operations['-'] = [](double a, double b){return a-b;};
    operations['*'] = [](double a, double b){return a*b;};
    operations['/'] = [](double a, double b){return a/b;};

    vector<double> stack_;
    double number = 0;
    bool flag = true;

    for (const auto& i : expression)
    {
        if (isdigit(i))
        {
            number *= 10;
            number += (i - '0');
            flag = true;
        }
        else
        {
            if (i != ' ')
            {
                double num2 = stack_.back();
                stack_.pop_back();
                double num1 = stack_.back();
                stack_.pop_back();

                stack_.push_back(operations[i](num1, num2));
                flag = false;
            }
            else if (i == ' ' && flag)
            {
                stack_.push_back(number);
                number = 0;
            }
        }
    }

    return stack_.back();
}

int main()
{


    string expression = "2 2 3 + *";
    std::cout << RPNtoNumber(expression);

    return 0;
}
