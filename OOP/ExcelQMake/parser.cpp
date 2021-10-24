#include"parser.h"

// example 2+2*(1+1)



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

std::string Parser::expressionToRPN(const std::string& a) {
    std::string res;
    std::stack<char> s;
    for(char i : a) {
        if(i!='(' && i!=')' && !isOperator(i))  {
            res+=i;
            res.push_back(' ');
        }

        if(i=='(') s.push(i) ;
        if(i==')') {
            while(s.top()!='(') {
                res+=s.top();
                res.push_back(' ');
                s.pop();
            }
            s.pop();
        }
        if(isOperator(i)) {
            if(s.empty() || (!s.empty() && isPriority(s.top(), i)) ) s.push(i);
            else {
                while(!s.empty() && !isPriority(s.top(), i)) {
                    res+=s.top();
                    res.push_back(' ');
                    s.pop();
                }
                s.push(i) ;
            }
        }
    }
    while(!s.empty())
    {
        res+=s.top();
        res.push_back(' ');
        s.pop();
    }
    res.pop_back();
    return res;
}

double Parser:: RPNtoNumber(std::string expression) {
   std::map<std::string, std::function<double(const double&, const double&)>> operations;

    operations["+"] = [](double a, double b){return a+b;};
    operations["-"] = [](double a, double b){return a-b;};
    operations["*"] = [](double a, double b){return a*b;};
    operations["/"] = [](double a, double b){return a/b;};
    operations["mod"] = [](double a, double b){return (int)a%(int)b;};
    operations["div"] = [](double a, double b){return (int)a/(int)b;};
    operations["^"] = [](double a, double b){return pow(a,b);};
    operations["min"] = [](double a, double b){return std::min(a,b);};
    operations["max"] = [](double a, double b){return std::max(a,b);};

    std::vector<double> stack_;

    std::vector<std::string> words = splitString(expression);
    //std::cout << "Vector:\n";
   // for(auto it: words) std::cout << it;
    double number = 0;
    bool flag = true;

    for (const auto& i : words)
    {
        if (isNumber(i))
        {
            number = std::atof(i.c_str());
            flag = true;
        }
        else
        {
            if (i != " ")
            {
                double num2 = stack_.back();
                stack_.pop_back();
                double num1 = stack_.back();
                stack_.pop_back();

                stack_.push_back(operations[i](num1, num2));
                flag = false;
            }
            else if (i == " " && flag)
            {
                stack_.push_back(number);
                number = 0;
            }
        }
    }

    return stack_.back();
}
