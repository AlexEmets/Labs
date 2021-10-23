#include "mainwindow.h"
#include <QApplication>
#include<iostream>

int main(int argc, char *argv[])
{
//    QApplication app(argc, argv);
//    MainWindow w;
//    w.show();

//    return app.exec();
    QString expression_string("3 + Math.sqrt(5) + Math.pow(3,2) + Math.log(5)");
    QScriptEngine expression;
    double my_val=expression.evaluate(expression_string).toNumber();

    //w.printData();
}
