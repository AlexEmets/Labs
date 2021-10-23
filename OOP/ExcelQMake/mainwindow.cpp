#include "mainwindow.h"
#include "ui_mainwindow.h"
#include<iostream>
#include<QDebug>
#include <QTextStream>
#include<QMessageBox>
#include<cmath>
#include<map>
#include<cstdlib>
MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{

    ui->setupUi(this);

    int rowCount = 4;
    int columnCount = 4;

    ui->tableWidget->setRowCount(4);
    ui->tableWidget->setColumnCount(4);

    for(int i = 0; i < columnCount; ++i) ui->tableWidget->setColumnWidth(i, 115);
    for(int i = 0; i < rowCount; ++i)  ui->tableWidget->setRowHeight(i, 50);


}

MainWindow::~MainWindow()
{
    delete ui;
}


int MainWindow::calculateExpression(const QString& cellText) {
    return RPNtoNumber(cellText.toStdString());
}


void MainWindow::on_pushButton_2_clicked()
{
    QTableWidgetItem * item= ui->tableWidget->currentItem();
    item->setText(QString::number(calculateExpression(item->text())));
}


void MainWindow::on_lineEdit_textChanged(const QString &arg1)
{
    data.push_back(arg1.toStdString());

}


void  MainWindow::printData() const {
    std::cout << getDataSize() << '\n';
    for(auto it: data) std::cout << it << '\n';
}

//после каждой строки стоит " "(для реализации алгоритма RPN)
std::vector<std::string> splitString(const std::string& str) {
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

bool isNumber(const std::string& s) {
    std::string::const_iterator it = s.begin();
    while (it != s.end() && std::isdigit(*it)) ++it;
    return !s.empty() && it == s.end();
}
double RPNtoNumber(std::string expression) {
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


