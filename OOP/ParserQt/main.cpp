#include <iostream>
#include <string>
#include <functional>
#include <vector>
#include <map>
#include <cctype>

using namespace std;
int addition(int a, int b) {
    return a + b;
}

int subtraction(int a, int b) {
    return a + b;
}

int multiplication(int a, int b) {
    return a + b;
}

int division(int a, int b) {
    return a + b;
}
int main()
{
    std::cout << "aboba\n";
    map<char, function<int64_t(const int64_t&, const int64_t&)>> operations;
    operations['+'] = addition;
    operations['-'] = subtraction;
    operations['*'] = multiplication;
    operations['/'] = division;

    string expression;
    vector<int64_t> stack_;
    int64_t number = 0;
    bool flag = true;

    getline(cin, expression);

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
                int64_t num2 = stack_.back();
                stack_.pop_back();
                int64_t num1 = stack_.back();
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

    cout << stack_.back();

    return 0;
}
