#ifndef PARSER_H
#define PARSER_H
#include<vector>
#include<string>
#include<stack>
#include<map>
#include<cmath>
#include<cstdlib>
#include<iostream>
#include <functional>
class Parser{
    //после каждой строки стоит " "(для реализации алгоритма RPN)
public:
    std::vector<std::string> splitString(const std::string &str);
    bool isNumber(const std::string& s) {
        std::string::const_iterator it = s.begin();
        while (it != s.end() && std::isdigit(*it)) ++it;
        return !s.empty() && it == s.end();
    }
    bool isOperator(char b)
    {
        return b=='+' || b=='-' || b=='*' || b=='/' || b=='^';
    }
    bool isPriority(char a, char b) {
        if(a=='(') return true;
        if(a=='+' || a=='-') return true;
        if(b=='+' || b=='-') return false;
        return true;
    }
    std::string expressionToRPN(const std::string& a);


    double RPNtoNumber(std::string expression);


};



#endif // PARSER_H
