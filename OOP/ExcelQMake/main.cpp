#include "mainwindow.h"
#include <QApplication>
#include<iostream>

int main(int argc, char *argv[])
{
    QApplication app(argc, argv);
    MainWindow w;
    w.show();


   // std::cout << w.calculateExpression("2+2*3");
    //w.printData();
    return app.exec();
}
