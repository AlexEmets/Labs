//
// Created by oyemets on 24.10.21.
//

#include "parser.h"
using namespace std;
bool Parser::isInteger(const std::string & s)
{
    if(s.empty() || ((!isdigit(s[0])) && (s[0] != '-') && (s[0] != '+'))) return false;

    char * p;
    strtol(s.c_str(), &p, 10);

    return (*p == 0);
}

bool Parser::isDigit(char a) {
    string tmp = "0123456789";
    for(auto it: tmp) if(it == a) return true;
    return false;
}
bool Parser::isOperation(const string& s) {
    return s == "*" || s == "/" || s == "-" || s == "+" || s == "^";
}
bool Parser::isOperation(char s) {
    return s == '*' || s == '/' || s == '-' || s == '+' || s == '^';
}
std::vector<std::string> Parser::splitString(const std::string &str) {
    std::string word;
    std::vector<std::string> result;
    for (auto x : str) {
        if (x == ' ') {
            result.push_back(word);
            result.push_back(" ");
            word = "";
        }
        else word = word + x;
    }
    result.push_back(word);
    return result;
}

vector<string> Parser::parseExpression(const string& s) {
    vector<string> result;

    string resNumber;
    for(int i = 0; i < s.size(); ++i) {
        if(s[i] == ' ' || s[i] == '(' || s[i] == ')' || isOperation(s[i])) {
            if(!resNumber.empty()) {
                result.push_back(resNumber);
                resNumber = "";
            }
            string tmp(1, s[i]);
            result.push_back(tmp);

        }
        else { //если цифра
            resNumber+=s[i];
        }
    }
    if(!resNumber.empty()) result.push_back(resNumber);
    return result;
}
//template<class T>
//void printVector(const vector<T>& vec) {
//    std::cout << '\n';
//    for(const auto& itt: vec) std::cout << itt << " ";
//    std::cout << '\n';
//}
map<string, int> priorities = {{"+", 1},{"-", 1},{"*", 2},{"/", 2},{"^", 3} };
double Parser::calculateExpression(const string& inputExpression) {
    vector<string> tokens = parseExpression(inputExpression);
    tokens.emplace_back("X");
    vector<double> numbersStack;
    vector<string> operationsStack;
    map<std::string, std::function<double(const double&, const double&)>> operations;
    operations["+"] = [](double a, double b) {return a+b;};
    operations["-"] = [](double a, double b) {return a-b;};
    operations["*"] = [](double a, double b) {return a*b;};
    operations["/"] = [](double a, double b) {return a/b;};
    operations["^"] = [](double a, double b) {return pow(a,b);};
    for(const auto& it: tokens) {
        if(isInteger(it)) {
            numbersStack.push_back(atof(it.c_str()));
        }

        else {
            if(isOperation(it)) {
                while(!operationsStack.empty() && priorities[operationsStack.back()] >= priorities[it]) {
                    if(operationsStack.back() == "(" || operationsStack.back() == ")") break;
                    double secondOperand = numbersStack.back();
                    numbersStack.pop_back();
                    double firstOperand = numbersStack.back();
                    numbersStack.pop_back();
                    numbersStack.push_back(operations[operationsStack.back()](firstOperand, secondOperand));
                    operationsStack.pop_back();
                }
                operationsStack.push_back(it);
            }
            else if(it == "(") operationsStack.push_back(it);

            else if(it == ")") {
                while(operationsStack.back() != "(") {
                    double secondOperand = numbersStack.back();
                    numbersStack.pop_back();
                    double firstOperand = numbersStack.back();
                    numbersStack.pop_back();
                    numbersStack.push_back(operations[operationsStack.back()](firstOperand, secondOperand));
                    operationsStack.pop_back();
                }
                operationsStack.pop_back();
            }
            else if(it == "X") {
                //printVector(operationsStack);
                //printVector(numbersStack);
                //проверка на правильность арифметического выражения
                if(numbersStack.size() - operationsStack.size() == 1) { // должно быть так(наверное)
                    while(!operationsStack.empty()) {
                        double secondOperand = numbersStack.back();
                        numbersStack.pop_back();
                        double firstOperand = numbersStack.back();
                        numbersStack.pop_back();
                        numbersStack.push_back(operations[operationsStack.back()](firstOperand, secondOperand));
                        operationsStack.pop_back();
                    }
                    return numbersStack.back();
                }
                else {
                    return -10000;
                }
            }
        }
    }
    return numbersStack.back();
}
