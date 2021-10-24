#include "mainwindow.h"
#include "ui_mainwindow.h"
#include<iostream>
#include<QDebug>
#include <QTextStream>
#include<QMessageBox>
#include<cmath>
#include<map>
#include<cstdlib>
#include<stack>

#include"parser.h"
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


double MainWindow::calculateExpression(const QString& cellText) {
    Parser parser;

    return parser.calculateExpression(cellText.toStdString());

}


void MainWindow::on_pushButton_2_clicked()
{
    QTableWidgetItem * item= ui->tableWidget->currentItem();
    item->setText(QString::number(calculateExpression(item->text())));
}





void  MainWindow::printData() const {
    std::cout << getDataSize() << '\n';
    for(auto it: data) std::cout << it << '\n';
}




